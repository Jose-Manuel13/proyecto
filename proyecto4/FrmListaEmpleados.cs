using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaEmpleados
{
    public partial class FrmListaEmpleados : Form
    {
        private GestorEmpleados gestor;

        public FrmListaEmpleados(GestorEmpleados gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            ConfigurarTabla();
            CargarEmpleados();
        }

        private void ConfigurarTabla()
        {
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 86, 160);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvEmpleados.EnableHeadersVisualStyles = false;

            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 243, 255);

            AgregarColumna("IdEmpleado", "ID", 80);
            AgregarColumna("Nombre", "Nombre", 160);
            AgregarColumna("Departamento", "Departamento", 130);
            AgregarColumna("Cargo", "Cargo", 130);
            AgregarColumna("FechaInicio", "Fecha Inicio", 100);
            AgregarColumna("Salario", "Salario", 90);
            AgregarColumna("EstadoTexto", "Estado", 80);
            AgregarColumna("TiempoEnEmpresa", "Tiempo", 130);
            AgregarColumna("AFP", "AFP", 70);
            AgregarColumna("ARS", "ARS", 70);
            AgregarColumna("ISR", "ISR", 70);
            AgregarColumna("SalarioNeto", "Sal. Neto", 90);
        }

        private void AgregarColumna(string nombrePropiedad, string encabezado, int ancho)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.DataPropertyName = nombrePropiedad;
            columna.HeaderText = encabezado;
            columna.Width = ancho;
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns.Add(columna);
        }

        private void CargarEmpleados()
        {
            List<Empleado> empleados = gestor.ObtenerTodos();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            lblTotal.Text = $"Total: {empleados.Count} empleado(s)";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}