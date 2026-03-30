// ============================================================
// ARCHIVO: FrmAgregarEditar.cs
// DESCRIPCIÓN: Formulario para agregar un nuevo empleado
//              o editar uno existente.
//              Si se pasa un empleado, entra en modo "Edición".
//              Si se pasa null, entra en modo "Agregar".
// CURSO: Programación 1
// ============================================================

using System;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaEmpleados
{
    /// <summary>
    /// FrmAgregarEditar: Formulario de doble uso.
    ///   - Modo Agregar: cuando empleadoExistente es null.
    ///   - Modo Editar: cuando empleadoExistente tiene datos.
    /// </summary>
    public partial class FrmAgregarEditar : Form
    {
        // Referencia al gestor de empleados
        private GestorEmpleados gestor;

        // El empleado que estamos editando (null si es nuevo)
        private Empleado empleadoExistente;

        // Bandera para saber si estamos en modo edición
        private bool modoEdicion;

        /// <summary>
        /// Constructor: recibe el gestor y el empleado a editar (o null si es nuevo).
        /// </summary>
        /// <param name="gestor">El gestor de empleados.</param>
        /// <param name="empleado">El empleado a editar, o null si es nuevo.</param>
        public FrmAgregarEditar(GestorEmpleados gestor, Empleado empleado)
        {
            InitializeComponent();

            this.gestor            = gestor;
            this.empleadoExistente = empleado;
            this.modoEdicion       = (empleado != null); // Es modo edición si se pasó un empleado

            // Configuramos el formulario según el modo
            if (modoEdicion)
            {
                // Modo edición: cargamos los datos del empleado en los campos
                this.Text         = "✏  Actualizar Empleado";
                lblTituloForm.Text = "Actualizar Empleado";
                CargarDatosEmpleado();

                // En modo edición, el ID no se puede cambiar
                txtId.ReadOnly   = true;
                txtId.BackColor  = Color.LightGray;
            }
            else
            {
                // Modo agregar: el formulario empieza vacío
                this.Text         = "➕  Agregar Nuevo Empleado";
                lblTituloForm.Text = "Agregar Nuevo Empleado";
                dtpFechaInicio.Value = DateTime.Today;

                // Estado por defecto: Vigente
                cmbEstado.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Carga los datos del empleado existente en los campos del formulario.
        /// Esto permite que el usuario vea y modifique los valores actuales.
        /// </summary>
        private void CargarDatosEmpleado()
        {
            // Llenamos cada campo con el valor del empleado
            txtId.Text              = empleadoExistente.IdEmpleado;
            txtNombre.Text          = empleadoExistente.Nombre;
            txtDepartamento.Text    = empleadoExistente.Departamento;
            txtCargo.Text           = empleadoExistente.Cargo;
            dtpFechaInicio.Value    = empleadoExistente.FechaInicio;
            txtSalario.Text         = empleadoExistente.Salario.ToString("0.00");

            // Seleccionamos el estado correcto en el ComboBox
            cmbEstado.SelectedIndex = empleadoExistente.Estado ? 0 : 1;
        }

        /// <summary>
        /// Evento: Clic en el botón "Guardar".
        /// Valida todos los campos y guarda el empleado (nuevo o actualizado).
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // ---- VALIDACIONES ----
            // Verificamos cada campo antes de guardar.
            // Si alguna validación falla, mostramos un mensaje y salimos.

            // 1. ID del empleado
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MostrarError("El ID del empleado es obligatorio.");
                txtId.Focus();
                return;
            }

            // Verificamos que el ID solo tenga letras, números y guiones
            string id = txtId.Text.Trim().ToUpper();
            if (id.Length < 3 || id.Length > 15)
            {
                MostrarError("El ID debe tener entre 3 y 15 caracteres.");
                txtId.Focus();
                return;
            }

            // 2. Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError("El nombre del empleado es obligatorio.");
                txtNombre.Focus();
                return;
            }

            if (txtNombre.Text.Trim().Length < 3)
            {
                MostrarError("El nombre debe tener al menos 3 caracteres.");
                txtNombre.Focus();
                return;
            }

            // 3. Departamento
            if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MostrarError("El departamento es obligatorio.");
                txtDepartamento.Focus();
                return;
            }

            // 4. Cargo
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MostrarError("El cargo es obligatorio.");
                txtCargo.Focus();
                return;
            }

            // 5. Fecha de inicio
            DateTime fechaInicio = dtpFechaInicio.Value.Date;

            // La fecha no puede ser en el futuro
            if (fechaInicio > DateTime.Today)
            {
                MostrarError("La fecha de inicio no puede ser una fecha futura.");
                dtpFechaInicio.Focus();
                return;
            }

            // La fecha no puede ser demasiado antigua (más de 60 años)
            if (fechaInicio < DateTime.Today.AddYears(-60))
            {
                MostrarError("La fecha de inicio no puede ser mayor a 60 años atrás.");
                dtpFechaInicio.Focus();
                return;
            }

            // 6. Salario
            decimal salario;

            // TryParse intenta convertir el texto a número decimal
            // Si no puede convertirlo, devuelve false
            if (!decimal.TryParse(txtSalario.Text.Trim(), out salario))
            {
                MostrarError("El salario debe ser un número válido.\nEjemplo: 35000 o 35000.50");
                txtSalario.Focus();
                return;
            }

            // El salario no puede ser negativo ni cero
            if (salario <= 0)
            {
                MostrarError("El salario debe ser mayor a cero.");
                txtSalario.Focus();
                return;
            }

            // 7. Estado
            if (cmbEstado.SelectedIndex < 0)
            {
                MostrarError("Debe seleccionar el estado del empleado.");
                cmbEstado.Focus();
                return;
            }

            // ---- CREAMOS EL OBJETO EMPLEADO CON LOS DATOS ----
            Empleado empleado = new Empleado
            {
                IdEmpleado   = id,
                Nombre       = txtNombre.Text.Trim(),
                Departamento = txtDepartamento.Text.Trim(),
                Cargo        = txtCargo.Text.Trim(),
                FechaInicio  = fechaInicio,
                Salario      = salario,
                Estado       = (cmbEstado.SelectedIndex == 0) // 0 = Vigente, 1 = No Vigente
            };

            // ---- GUARDAR SEGÚN EL MODO ----
            if (modoEdicion)
            {
                // Modo edición: actualizamos el empleado existente
                bool actualizado = gestor.ActualizarEmpleado(empleado);

                if (actualizado)
                {
                    MessageBox.Show(
                        "Empleado actualizado correctamente.",
                        "Actualización Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MostrarError("No se pudo actualizar el empleado. ID no encontrado.");
                }
            }
            else
            {
                // Modo agregar: intentamos agregar el nuevo empleado
                bool agregado = gestor.AgregarEmpleado(empleado);

                if (agregado)
                {
                    MessageBox.Show(
                        $"Empleado '{empleado.Nombre}' agregado correctamente.",
                        "Empleado Agregado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Limpiamos el formulario para agregar otro empleado
                    LimpiarFormulario();
                }
                else
                {
                    // El ID ya existe
                    MostrarError($"Ya existe un empleado con el ID '{id}'.\nEl ID debe ser único.");
                    txtId.Focus();
                }
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario para ingresar otro empleado.
        /// </summary>
        private void LimpiarFormulario()
        {
            txtId.Text           = "";
            txtNombre.Text       = "";
            txtDepartamento.Text = "";
            txtCargo.Text        = "";
            dtpFechaInicio.Value = DateTime.Today;
            txtSalario.Text      = "";
            cmbEstado.SelectedIndex = 0;
            txtId.Focus();
        }

        /// <summary>
        /// Muestra un mensaje de error con formato uniforme.
        /// Método auxiliar para no repetir el mismo código de MessageBox.
        /// </summary>
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Error de Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        /// <summary>
        /// Evento: Clic en el botón "Cancelar".
        /// Cierra el formulario sin guardar cambios.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento: Cambio en el campo de salario.
        /// Recalcula y muestra los descuentos en tiempo real.
        /// </summary>
        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            decimal salario;

            if (decimal.TryParse(txtSalario.Text.Trim(), out salario) && salario > 0)
            {
                // Creamos un empleado temporal solo para calcular los descuentos
                Empleado temp = new Empleado
                {
                    Salario     = salario,
                    FechaInicio = DateTime.Today  // Solo para evitar error de cálculo
                };

                // Mostramos los cálculos en los labels de previsualización
                lblAfpCalc.Text  = $"AFP  (2.87%): RD$ {temp.AFP:N2}";
                lblArsCalc.Text  = $"ARS  (3.04%): RD$ {temp.ARS:N2}";
                lblIsrCalc.Text  = $"ISR  (variable): RD$ {temp.ISR:N2}";
                lblNetoCalc.Text = $"Neto estimado: RD$ {temp.SalarioNeto:N2}";
            }
            else
            {
                // Si el salario no es válido, limpiamos los cálculos
                lblAfpCalc.Text  = "AFP  (2.87%): —";
                lblArsCalc.Text  = "ARS  (3.04%): —";
                lblIsrCalc.Text  = "ISR  (variable): —";
                lblNetoCalc.Text = "Neto estimado: —";
            }
        }
    }
}
