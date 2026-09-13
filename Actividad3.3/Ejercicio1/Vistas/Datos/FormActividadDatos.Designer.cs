namespace Ejercicio1.Vistas
{
    partial class FormActividadDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbPeriodoActividad = new TextBox();
            tbDescripcionActividad = new TextBox();
            label8 = new Label();
            label6 = new Label();
            cmbTipoActividad = new ComboBox();
            btnAltaActividad = new Button();
            button1 = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbPeriodoActividad);
            groupBox3.Controls.Add(tbDescripcionActividad);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmbTipoActividad);
            groupBox3.Controls.Add(btnAltaActividad);
            groupBox3.Location = new Point(15, 17);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(649, 175);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alta de actividad (4)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 83);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 16;
            label7.Text = "Periodo";
            // 
            // tbPeriodoActividad
            // 
            tbPeriodoActividad.Location = new Point(257, 80);
            tbPeriodoActividad.Margin = new Padding(4);
            tbPeriodoActividad.Name = "tbPeriodoActividad";
            tbPeriodoActividad.Size = new Size(127, 29);
            tbPeriodoActividad.TabIndex = 15;
            // 
            // tbDescripcionActividad
            // 
            tbDescripcionActividad.Location = new Point(257, 128);
            tbDescripcionActividad.Margin = new Padding(4);
            tbDescripcionActividad.Name = "tbDescripcionActividad";
            tbDescripcionActividad.Size = new Size(127, 29);
            tbDescripcionActividad.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 13;
            label8.Text = "Descripcion";
            // 
            // label6
            // 
            label6.Location = new Point(34, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 74);
            label6.TabIndex = 9;
            label6.Text = "Elegir tipo de Actividad";
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Items.AddRange(new object[] { "Agricola", "Ganadera" });
            cmbTipoActividad.Location = new Point(185, 35);
            cmbTipoActividad.Margin = new Padding(4);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(199, 29);
            cmbTipoActividad.TabIndex = 8;
            // 
            // btnAltaActividad
            // 
            btnAltaActividad.DialogResult = DialogResult.OK;
            btnAltaActividad.Location = new Point(412, 47);
            btnAltaActividad.Margin = new Padding(5, 6, 5, 6);
            btnAltaActividad.Name = "btnAltaActividad";
            btnAltaActividad.Size = new Size(215, 92);
            btnAltaActividad.TabIndex = 6;
            btnAltaActividad.Text = "Alta de Actividad";
            btnAltaActividad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(263, 202);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormActividadDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 271);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormActividadDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDatosActividad";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label6;
        private Button btnAltaActividad;
        private Button button1;
        public TextBox tbPeriodoActividad;
        public TextBox tbDescripcionActividad;
        public ComboBox cmbTipoActividad;
    }
}