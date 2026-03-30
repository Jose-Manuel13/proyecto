namespace SistemaEmpleados
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotalEmpleados = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(30, 86, 160);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(480, 100);
            this.pnlEncabezado.TabIndex = 0;

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.None;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(460, 38);
            this.lblTitulo.Text = "Sistema de Gestión de Empleados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightBlue;
            this.lblSubtitulo.Location = new System.Drawing.Point(10, 57);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(460, 25);
            this.lblSubtitulo.Text = "Menú Principal";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlBotones.Controls.Add(this.btnMostrarEmpleados);
            this.pnlBotones.Controls.Add(this.btnAgregarEmpleado);
            this.pnlBotones.Controls.Add(this.btnActualizarEmpleado);
            this.pnlBotones.Controls.Add(this.btnEliminarEmpleado);
            this.pnlBotones.Controls.Add(this.btnExportarCSV);
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.lblTotalEmpleados);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 100);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(480, 430);
            this.pnlBotones.TabIndex = 1;
            this.pnlBotones.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);

            System.Drawing.Font fuenteBoton = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            System.Drawing.Size tamanoBoton = new System.Drawing.Size(360, 52);
            int xBoton = 60;
            int espaciado = 62;

            this.btnMostrarEmpleados.BackColor = System.Drawing.Color.FromArgb(30, 86, 160);
            this.btnMostrarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEmpleados.Font = fuenteBoton;
            this.btnMostrarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(xBoton, 30);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = tamanoBoton;
            this.btnMostrarEmpleados.TabIndex = 0;
            this.btnMostrarEmpleados.Text = "  Mostrar Empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = false;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            this.btnMostrarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnMostrarEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = fuenteBoton;
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(xBoton, 30 + espaciado);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = tamanoBoton;
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "  Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = fuenteBoton;
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(xBoton, 30 + espaciado * 2);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = tamanoBoton;
            this.btnActualizarEmpleado.TabIndex = 2;
            this.btnActualizarEmpleado.Text = "  Actualizar Empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = fuenteBoton;
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(xBoton, 30 + espaciado * 3);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = tamanoBoton;
            this.btnEliminarEmpleado.TabIndex = 3;
            this.btnEliminarEmpleado.Text = "  Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnExportarCSV.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnExportarCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarCSV.Font = fuenteBoton;
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.Location = new System.Drawing.Point(xBoton, 30 + espaciado * 4);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = tamanoBoton;
            this.btnExportarCSV.TabIndex = 4;
            this.btnExportarCSV.Text = "  Exportar a CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            this.btnExportarCSV.FlatAppearance.BorderSize = 0;
            this.btnExportarCSV.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = fuenteBoton;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(xBoton, 30 + espaciado * 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = tamanoBoton;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblTotalEmpleados.AutoSize = false;
            this.lblTotalEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTotalEmpleados.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalEmpleados.Location = new System.Drawing.Point(xBoton, 30 + espaciado * 6 + 5);
            this.lblTotalEmpleados.Name = "lblTotalEmpleados";
            this.lblTotalEmpleados.Size = new System.Drawing.Size(360, 20);
            this.lblTotalEmpleados.Text = "Empleados registrados: 0";
            this.lblTotalEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.ClientSize = new System.Drawing.Size(480, 530);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Empleados — Menú Principal";

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTotalEmpleados;
    }
}