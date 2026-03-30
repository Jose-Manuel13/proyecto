using System;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaEmpleados
{
    public partial class FrmMenuPrincipal : Form
    {
        private GestorEmpleados gestor;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            gestor = new GestorEmpleados();
            ActualizarContador();
        }

        private void ActualizarContador()
        {
            lblTotalEmpleados.Text = $"Empleados registrados: {gestor.TotalEmpleados}";
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados frm = new FrmListaEmpleados(gestor);
            frm.ShowDialog();
            ActualizarContador();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEditar frm = new FrmAgregarEditar(gestor, null);
            frm.ShowDialog();
            ActualizarContador();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del empleado que desea actualizar:",
                "Actualizar Empleado",
                ""
            );

            if (string.IsNullOrWhiteSpace(id))
                return;

            Empleado empleado = gestor.BuscarPorId(id.Trim());

            if (empleado == null)
            {
                MessageBox.Show(
                    $"No se encontró ningún empleado con el ID: {id}",
                    "Empleado No Encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            FrmAgregarEditar frm = new FrmAgregarEditar(gestor, empleado);
            frm.ShowDialog();
            ActualizarContador();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del empleado que desea eliminar:",
                "Eliminar Empleado",
                ""
            );

            if (string.IsNullOrWhiteSpace(id))
                return;

            Empleado empleado = gestor.BuscarPorId(id.Trim());

            if (empleado == null)
            {
                MessageBox.Show(
                    $"No se encontró ningún empleado con el ID: {id}",
                    "Empleado No Encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar al empleado:\n" +
                $"ID: {empleado.IdEmpleado}\n" +
                $"Nombre: {empleado.Nombre}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                gestor.EliminarEmpleado(id.Trim());
                MessageBox.Show(
                    "Empleado eliminado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ActualizarContador();
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            if (gestor.TotalEmpleados == 0)
            {
                MessageBox.Show(
                    "No hay empleados registrados para exportar.",
                    "Sin Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Title = "Exportar Empleados a CSV";
            dialogo.Filter = "Archivo CSV (*.csv)|*.csv";
            dialogo.FileName = $"Empleados_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            dialogo.DefaultExt = "csv";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                bool exito = gestor.ExportarCSV(dialogo.FileName);

                if (exito)
                {
                    MessageBox.Show(
                        $"Archivo exportado exitosamente:\n{dialogo.FileName}",
                        "Exportación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrió un error al exportar el archivo.\n" +
                        "Verifique que tenga permisos de escritura en la carpeta seleccionada.",
                        "Error de Exportación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?\n" +
                "Los datos no guardados se perderán.",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}