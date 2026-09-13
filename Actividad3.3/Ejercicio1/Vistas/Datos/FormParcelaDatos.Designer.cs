namespace Ejercicio1.Vistas
{
    partial class FormParcelaDatos
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
            button2 = new Button();
            btnAltaCampo = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            tbIdentificadorCampo = new TextBox();
            tbSuperficieCampo = new TextBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(301, 149);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(171, 61);
            button2.TabIndex = 24;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAltaCampo
            // 
            btnAltaCampo.DialogResult = DialogResult.OK;
            btnAltaCampo.Location = new Point(42, 149);
            btnAltaCampo.Margin = new Padding(5);
            btnAltaCampo.Name = "btnAltaCampo";
            btnAltaCampo.Size = new Size(170, 61);
            btnAltaCampo.TabIndex = 23;
            btnAltaCampo.Text = "Confirmar";
            btnAltaCampo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbIdentificadorCampo);
            groupBox2.Controls.Add(tbSuperficieCampo);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(13, 12);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(490, 127);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alta de parcela";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 13;
            label1.Text = "Hectareas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 12;
            label4.Text = "Identificador";
            // 
            // tbIdentificadorCampo
            // 
            tbIdentificadorCampo.Location = new Point(174, 42);
            tbIdentificadorCampo.Margin = new Padding(4, 3, 4, 3);
            tbIdentificadorCampo.Name = "tbIdentificadorCampo";
            tbIdentificadorCampo.Size = new Size(300, 29);
            tbIdentificadorCampo.TabIndex = 11;
            // 
            // tbSuperficieCampo
            // 
            tbSuperficieCampo.Location = new Point(174, 81);
            tbSuperficieCampo.Margin = new Padding(4, 3, 4, 3);
            tbSuperficieCampo.Name = "tbSuperficieCampo";
            tbSuperficieCampo.Size = new Size(124, 29);
            tbSuperficieCampo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 84);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 9;
            label5.Text = "Superficie";
            // 
            // FormParcelaDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 227);
            Controls.Add(button2);
            Controls.Add(btnAltaCampo);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormParcelaDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDatosParcela";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btnAltaCampo;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        public TextBox tbIdentificadorCampo;
        public TextBox tbSuperficieCampo;
        private Label label5;
    }
}