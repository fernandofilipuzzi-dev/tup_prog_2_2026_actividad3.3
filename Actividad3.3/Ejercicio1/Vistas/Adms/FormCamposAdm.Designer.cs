namespace Ejercicio1.Vistas
{
    partial class FormCamposAdm
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
            button1 = new Button();
            lsbCampos = new ListBox();
            btnAltaCampo = new Button();
            btnAdministrarCampo = new Button();
            label1 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.TryAgain;
            button1.Location = new Point(410, 141);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(171, 65);
            button1.TabIndex = 8;
            button1.Text = "Agregar Campo";
            button1.UseVisualStyleBackColor = true;
            // 
            // lsbCampos
            // 
            lsbCampos.FormattingEnabled = true;
            lsbCampos.Location = new Point(7, 38);
            lsbCampos.Margin = new Padding(4);
            lsbCampos.Name = "lsbCampos";
            lsbCampos.Size = new Size(394, 277);
            lsbCampos.TabIndex = 7;
            // 
            // btnAltaCampo
            // 
            btnAltaCampo.DialogResult = DialogResult.Retry;
            btnAltaCampo.Location = new Point(410, 64);
            btnAltaCampo.Margin = new Padding(5, 6, 5, 6);
            btnAltaCampo.Name = "btnAltaCampo";
            btnAltaCampo.Size = new Size(171, 65);
            btnAltaCampo.TabIndex = 6;
            btnAltaCampo.Text = "Actualizar Listado";
            btnAltaCampo.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarCampo
            // 
            btnAdministrarCampo.DialogResult = DialogResult.Continue;
            btnAdministrarCampo.Location = new Point(410, 218);
            btnAdministrarCampo.Margin = new Padding(5, 6, 5, 6);
            btnAdministrarCampo.Name = "btnAdministrarCampo";
            btnAdministrarCampo.Size = new Size(171, 65);
            btnAdministrarCampo.TabIndex = 9;
            btnAdministrarCampo.Text = "Administrar Campo";
            btnAdministrarCampo.UseVisualStyleBackColor = true;
            btnAdministrarCampo.Click += btnAdministrarCampo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 58);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 10;
            label1.Text = "Administración de campos";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(249, 348);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 12;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbCampos);
            groupBox1.Controls.Add(btnAltaCampo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdministrarCampo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 327);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de campos";
            // 
            // FormCamposAdm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 395);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormCamposAdm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administracion de campos (2)";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnAltaCampo;
        private Button btnAdministrarCampo;
        private Label label1;
        private Button button2;
        private GroupBox groupBox1;
        public ListBox lsbCampos;
    }
}