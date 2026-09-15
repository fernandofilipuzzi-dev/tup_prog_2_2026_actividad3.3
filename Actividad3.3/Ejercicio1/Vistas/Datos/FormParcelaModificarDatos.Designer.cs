namespace Ejercicio1.Vistas
{
    partial class FormParcelaModificarDatos
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
            btnConfirmar = new Button();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            lbIdentificador = new Label();
            tbSuperficie = new TextBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(378, 152);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(160, 61);
            button2.TabIndex = 24;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = DialogResult.OK;
            btnConfirmar.Location = new Point(22, 152);
            btnConfirmar.Margin = new Padding(5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(160, 61);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.DialogResult = DialogResult.Yes;
            btnEliminar.Location = new Point(200, 152);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 61);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbIdentificador);
            groupBox2.Controls.Add(tbSuperficie);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(13, 12);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(534, 127);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificación de parcela";
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
            label4.Size = new Size(100, 21);
            label4.TabIndex = 12;
            label4.Text = "Identificador:";
            // 
            // lbIdentificador
            // 
            lbIdentificador.BackColor = SystemColors.ActiveCaption;
            lbIdentificador.Location = new Point(174, 42);
            lbIdentificador.Name = "lbIdentificador";
            lbIdentificador.Size = new Size(300, 26);
            lbIdentificador.TabIndex = 11;
            // 
            // tbSuperficie
            // 
            tbSuperficie.Location = new Point(174, 81);
            tbSuperficie.Margin = new Padding(4, 3, 4, 3);
            tbSuperficie.Name = "tbSuperficie";
            tbSuperficie.Size = new Size(124, 29);
            tbSuperficie.TabIndex = 10;
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
            // FormParcelaModificarDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 232);
            Controls.Add(button2);
            Controls.Add(btnEliminar);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormParcelaModificarDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar parcela (8)";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btnConfirmar;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        public Label lbIdentificador;
        public TextBox tbSuperficie;
        private Label label5;
    }
}
