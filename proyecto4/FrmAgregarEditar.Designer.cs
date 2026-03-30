// ============================================================
// ARCHIVO: FrmAgregarEditar.Designer.cs
// DESCRIPCIÓN: Diseño del formulario Agregar/Editar empleado.
// ============================================================

namespace SistemaEmpleados
{
    partial class FrmAgregarEditar
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
            this.pnlEncabezado   = new System.Windows.Forms.Panel();
            this.lblTituloForm   = new System.Windows.Forms.Label();
            this.pnlContenido    = new System.Windows.Forms.Panel();
            this.lblId           = new System.Windows.Forms.Label();
            this.txtId           = new System.Windows.Forms.TextBox();
            this.lblNombre       = new System.Windows.Forms.Label();
            this.txtNombre       = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblCargo        = new System.Windows.Forms.Label();
            this.txtCargo        = new System.Windows.Forms.TextBox();
            this.lblFechaInicio  = new System.Windows.Forms.Label();
            this.dtpFechaInicio  = new System.Windows.Forms.DateTimePicker();
            this.lblSalario      = new System.Windows.Forms.Label();
            this.txtSalario      = new System.Windows.Forms.TextBox();
            this.lblEstado       = new System.Windows.Forms.Label();
            this.cmbEstado       = new System.Windows.Forms.ComboBox();
            this.grpCalculos     = new System.Windows.Forms.GroupBox();
            this.lblAfpCalc      = new System.Windows.Forms.Label();
            this.lblArsCalc      = new System.Windows.Forms.Label();
            this.lblIsrCalc      = new System.Windows.Forms.Label();
            this.lblNetoCalc     = new System.Windows.Forms.Label();
            this.pnlBotones      = new System.Windows.Forms.Panel();
            this.btnGuardar      = new System.Windows.Forms.Button();
            this.btnCancelar     = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.grpCalculos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Font fuenteLabel = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fuenteInput = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Size tamanoInput = new System.Drawing.Size(300, 28);
            int xLabel = 20, xInput = 170, alturaFila = 42;

            // ---- pnlEncabezado ----
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(30, 86, 160);
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Size = new System.Drawing.Size(500, 55);

            // ---- lblTituloForm ----
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Text = "Agregar Nuevo Empleado";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ---- pnlContenido ----
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(10);

            // ---- Fila 1: ID ----
            this.lblId.AutoSize = true;
            this.lblId.Font = fuenteLabel;
            this.lblId.Location = new System.Drawing.Point(xLabel, 20);
            this.lblId.Text = "ID del Empleado *";

            this.txtId.Font = fuenteInput;
            this.txtId.Location = new System.Drawing.Point(xInput, 17);
            this.txtId.Size = tamanoInput;
            this.txtId.MaxLength = 15;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            // ---- Fila 2: Nombre ----
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = fuenteLabel;
            this.lblNombre.Location = new System.Drawing.Point(xLabel, 20 + alturaFila);
            this.lblNombre.Text = "Nombre *";

            this.txtNombre.Font = fuenteInput;
            this.txtNombre.Location = new System.Drawing.Point(xInput, 17 + alturaFila);
            this.txtNombre.Size = tamanoInput;
            this.txtNombre.MaxLength = 80;

            // ---- Fila 3: Departamento ----
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = fuenteLabel;
            this.lblDepartamento.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 2);
            this.lblDepartamento.Text = "Departamento *";

            this.txtDepartamento.Font = fuenteInput;
            this.txtDepartamento.Location = new System.Drawing.Point(xInput, 17 + alturaFila * 2);
            this.txtDepartamento.Size = tamanoInput;
            this.txtDepartamento.MaxLength = 60;

            // ---- Fila 4: Cargo ----
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = fuenteLabel;
            this.lblCargo.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 3);
            this.lblCargo.Text = "Cargo *";

            this.txtCargo.Font = fuenteInput;
            this.txtCargo.Location = new System.Drawing.Point(xInput, 17 + alturaFila * 3);
            this.txtCargo.Size = tamanoInput;
            this.txtCargo.MaxLength = 60;

            // ---- Fila 5: Fecha de Inicio ----
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = fuenteLabel;
            this.lblFechaInicio.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 4);
            this.lblFechaInicio.Text = "Fecha de Inicio *";

            this.dtpFechaInicio.Font = fuenteInput;
            this.dtpFechaInicio.Location = new System.Drawing.Point(xInput, 17 + alturaFila * 4);
            this.dtpFechaInicio.Size = tamanoInput;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.MaxDate = System.DateTime.Today;

            // ---- Fila 6: Salario ----
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = fuenteLabel;
            this.lblSalario.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 5);
            this.lblSalario.Text = "Salario (RD$) *";

            this.txtSalario.Font = fuenteInput;
            this.txtSalario.Location = new System.Drawing.Point(xInput, 17 + alturaFila * 5);
            this.txtSalario.Size = tamanoInput;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);

            // ---- Fila 7: Estado ----
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = fuenteLabel;
            this.lblEstado.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 6);
            this.lblEstado.Text = "Estado *";

            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = fuenteInput;
            this.cmbEstado.Items.AddRange(new object[] { "Vigente", "No Vigente" });
            this.cmbEstado.Location = new System.Drawing.Point(xInput, 17 + alturaFila * 6);
            this.cmbEstado.Size = tamanoInput;
            this.cmbEstado.SelectedIndex = 0;

            // ---- grpCalculos (grupo de cálculos automáticos) ----
            this.grpCalculos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCalculos.ForeColor = System.Drawing.Color.FromArgb(30, 86, 160);
            this.grpCalculos.Location = new System.Drawing.Point(xLabel, 20 + alturaFila * 7 + 5);
            this.grpCalculos.Size = new System.Drawing.Size(450, 100);
            this.grpCalculos.Text = "Cálculos Automáticos (previsualización)";
            this.grpCalculos.Controls.Add(this.lblAfpCalc);
            this.grpCalculos.Controls.Add(this.lblArsCalc);
            this.grpCalculos.Controls.Add(this.lblIsrCalc);
            this.grpCalculos.Controls.Add(this.lblNetoCalc);

            System.Drawing.Font fuenteCalc = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Color colorCalc = System.Drawing.Color.FromArgb(50, 50, 50);

            this.lblAfpCalc.AutoSize = true;
            this.lblAfpCalc.Font = fuenteCalc;
            this.lblAfpCalc.ForeColor = colorCalc;
            this.lblAfpCalc.Location = new System.Drawing.Point(10, 22);
            this.lblAfpCalc.Text = "AFP  (2.87%): —";

            this.lblArsCalc.AutoSize = true;
            this.lblArsCalc.Font = fuenteCalc;
            this.lblArsCalc.ForeColor = colorCalc;
            this.lblArsCalc.Location = new System.Drawing.Point(10, 42);
            this.lblArsCalc.Text = "ARS  (3.04%): —";

            this.lblIsrCalc.AutoSize = true;
            this.lblIsrCalc.Font = fuenteCalc;
            this.lblIsrCalc.ForeColor = colorCalc;
            this.lblIsrCalc.Location = new System.Drawing.Point(10, 62);
            this.lblIsrCalc.Text = "ISR  (variable): —";

            this.lblNetoCalc.AutoSize = true;
            this.lblNetoCalc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNetoCalc.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblNetoCalc.Location = new System.Drawing.Point(240, 42);
            this.lblNetoCalc.Text = "Neto estimado: —";

            // Agregamos todos los controles al pnlContenido
            this.pnlContenido.Controls.Add(this.lblId);
            this.pnlContenido.Controls.Add(this.txtId);
            this.pnlContenido.Controls.Add(this.lblNombre);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Controls.Add(this.lblDepartamento);
            this.pnlContenido.Controls.Add(this.txtDepartamento);
            this.pnlContenido.Controls.Add(this.lblCargo);
            this.pnlContenido.Controls.Add(this.txtCargo);
            this.pnlContenido.Controls.Add(this.lblFechaInicio);
            this.pnlContenido.Controls.Add(this.dtpFechaInicio);
            this.pnlContenido.Controls.Add(this.lblSalario);
            this.pnlContenido.Controls.Add(this.txtSalario);
            this.pnlContenido.Controls.Add(this.lblEstado);
            this.pnlContenido.Controls.Add(this.cmbEstado);
            this.pnlContenido.Controls.Add(this.grpCalculos);

            // ---- pnlBotones ----
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Size = new System.Drawing.Size(500, 55);

            // ---- btnGuardar ----
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(250, 10);
            this.btnGuardar.Size = new System.Drawing.Size(110, 36);
            this.btnGuardar.Text = "💾  Guardar";
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ---- btnCancelar ----
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(370, 10);
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.Text = "✕  Cancelar";
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ---- FrmAgregarEditar ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.ClientSize = new System.Drawing.Size(500, 620);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.grpCalculos.ResumeLayout(false);
            this.grpCalculos.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Declaración de controles
        private System.Windows.Forms.Panel           pnlEncabezado;
        private System.Windows.Forms.Label           lblTituloForm;
        private System.Windows.Forms.Panel           pnlContenido;
        private System.Windows.Forms.Label           lblId;
        private System.Windows.Forms.TextBox         txtId;
        private System.Windows.Forms.Label           lblNombre;
        private System.Windows.Forms.TextBox         txtNombre;
        private System.Windows.Forms.Label           lblDepartamento;
        private System.Windows.Forms.TextBox         txtDepartamento;
        private System.Windows.Forms.Label           lblCargo;
        private System.Windows.Forms.TextBox         txtCargo;
        private System.Windows.Forms.Label           lblFechaInicio;
        private System.Windows.Forms.DateTimePicker  dtpFechaInicio;
        private System.Windows.Forms.Label           lblSalario;
        private System.Windows.Forms.TextBox         txtSalario;
        private System.Windows.Forms.Label           lblEstado;
        private System.Windows.Forms.ComboBox        cmbEstado;
        private System.Windows.Forms.GroupBox        grpCalculos;
        private System.Windows.Forms.Label           lblAfpCalc;
        private System.Windows.Forms.Label           lblArsCalc;
        private System.Windows.Forms.Label           lblIsrCalc;
        private System.Windows.Forms.Label           lblNetoCalc;
        private System.Windows.Forms.Panel           pnlBotones;
        private System.Windows.Forms.Button          btnGuardar;
        private System.Windows.Forms.Button          btnCancelar;
    }
}
