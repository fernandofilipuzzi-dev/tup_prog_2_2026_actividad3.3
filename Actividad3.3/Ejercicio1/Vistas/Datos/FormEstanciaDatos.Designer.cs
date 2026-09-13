namespace Ejercicio1.Vistas
{
    partial class FormEstanciaDatos
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
            groupBox5 = new GroupBox();
            label13 = new Label();
            tbNombre = new TextBox();
            groupBox6 = new GroupBox();
            label9 = new Label();
            button1 = new Button();
            lbDescripcionGeneral = new Label();
            button2 = new Button();
            btnAltaCampo = new Button();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(tbNombre);
            groupBox5.Location = new Point(15, 15);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(513, 91);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Información general";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(103, 38);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(68, 21);
            label13.TabIndex = 12;
            label13.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(212, 35);
            tbNombre.Margin = new Padding(4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(225, 29);
            tbNombre.TabIndex = 10;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(lbDescripcionGeneral);
            groupBox6.Location = new Point(15, 114);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(516, 99);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Solicitud de datos del primer campo";
            // 
            // label9
            // 
            label9.Location = new Point(8, 44);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 43);
            label9.TabIndex = 13;
            label9.Text = "Descripción general";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.TryAgain;
            button1.Location = new Point(369, 36);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(123, 52);
            button1.TabIndex = 15;
            button1.Text = "Editar Campo";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbDescripcionGeneral
            // 
            lbDescripcionGeneral.BackColor = SystemColors.ActiveCaption;
            lbDescripcionGeneral.ForeColor = SystemColors.ActiveCaptionText;
            lbDescripcionGeneral.Location = new Point(114, 44);
            lbDescripcionGeneral.Margin = new Padding(4, 0, 4, 0);
            lbDescripcionGeneral.Name = "lbDescripcionGeneral";
            lbDescripcionGeneral.Size = new Size(233, 43);
            lbDescripcionGeneral.TabIndex = 14;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(307, 221);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(171, 61);
            button2.TabIndex = 19;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAltaCampo
            // 
            btnAltaCampo.DialogResult = DialogResult.OK;
            btnAltaCampo.Location = new Point(48, 221);
            btnAltaCampo.Margin = new Padding(5);
            btnAltaCampo.Name = "btnAltaCampo";
            btnAltaCampo.Size = new Size(170, 61);
            btnAltaCampo.TabIndex = 18;
            btnAltaCampo.Text = "Confirmar";
            btnAltaCampo.UseVisualStyleBackColor = true;
            // 
            // FormEstanciaDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 289);
            Controls.Add(groupBox6);
            Controls.Add(button2);
            Controls.Add(btnAltaCampo);
            Controls.Add(groupBox5);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormEstanciaDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alta estancia datos (1)";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label9;
        private Button button1;
        private Label label13;
        private Button button2;
        private Button btnAltaCampo;
        public TextBox tbNombre;
        public Label lbDescripcionGeneral;
    }
}