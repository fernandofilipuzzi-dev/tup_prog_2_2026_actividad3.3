namespace Ejercicio1.Vistas.Adms
{
    partial class FormActividadAdm
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
            groupBox1 = new GroupBox();
            lsbActividades = new ListBox();
            btnAltaCampo = new Button();
            button1 = new Button();
            btnAdministrarCampo = new Button();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbActividades);
            groupBox1.Controls.Add(btnAltaCampo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdministrarCampo);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 327);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Actividades";
            // 
            // lsbActividades
            // 
            lsbActividades.FormattingEnabled = true;
            lsbActividades.Location = new Point(7, 29);
            lsbActividades.Margin = new Padding(4);
            lsbActividades.Name = "lsbActividades";
            lsbActividades.Size = new Size(394, 277);
            lsbActividades.TabIndex = 7;
            // 
            // btnAltaCampo
            // 
            btnAltaCampo.DialogResult = DialogResult.Retry;
            btnAltaCampo.Location = new Point(410, 56);
            btnAltaCampo.Margin = new Padding(5, 6, 5, 6);
            btnAltaCampo.Name = "btnAltaCampo";
            btnAltaCampo.Size = new Size(171, 65);
            btnAltaCampo.TabIndex = 6;
            btnAltaCampo.Text = "Actualizar Listado";
            btnAltaCampo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.TryAgain;
            button1.Location = new Point(410, 133);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(171, 65);
            button1.TabIndex = 8;
            button1.Text = "Agregar Actividad";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarCampo
            // 
            btnAdministrarCampo.DialogResult = DialogResult.Continue;
            btnAdministrarCampo.Location = new Point(410, 226);
            btnAdministrarCampo.Margin = new Padding(5, 6, 5, 6);
            btnAdministrarCampo.Name = "btnAdministrarCampo";
            btnAdministrarCampo.Size = new Size(171, 65);
            btnAdministrarCampo.TabIndex = 9;
            btnAdministrarCampo.Text = "Administrar Actividad";
            btnAdministrarCampo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(249, 348);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 15;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 58);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 14;
            label1.Text = "Administración de campos";
            // 
            // FormActividadAdm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 398);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormActividadAdm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormActividadAdm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        public ListBox lsbActividades;
        private Button btnAltaCampo;
        private Button button1;
        private Button btnAdministrarCampo;
        private Button button2;
        private Label label1;
    }
}