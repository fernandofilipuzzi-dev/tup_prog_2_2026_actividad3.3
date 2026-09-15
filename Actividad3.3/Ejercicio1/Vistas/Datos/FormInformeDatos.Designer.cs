namespace Ejercicio1.Vistas
{
    partial class FormInformeDatos
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            lbProduccionTotal = new Label();
            lbProductividad = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbActividades);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle por actividad";
            // 
            // lsbActividades
            // 
            lsbActividades.FormattingEnabled = true;
            lsbActividades.HorizontalScrollbar = true;
            lsbActividades.Location = new Point(8, 28);
            lsbActividades.Margin = new Padding(4);
            lsbActividades.Name = "lsbActividades";
            lsbActividades.Size = new Size(600, 256);
            lsbActividades.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lbProduccionTotal);
            groupBox2.Controls.Add(lbProductividad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(616, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totales de la estancia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Producción total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 1;
            label2.Text = "Productividad general:";
            // 
            // lbProduccionTotal
            // 
            lbProduccionTotal.BackColor = SystemColors.ActiveCaption;
            lbProduccionTotal.Location = new Point(218, 29);
            lbProduccionTotal.Name = "lbProduccionTotal";
            lbProduccionTotal.Size = new Size(181, 24);
            lbProduccionTotal.TabIndex = 2;
            lbProduccionTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbProductividad
            // 
            lbProductividad.BackColor = SystemColors.ActiveCaption;
            lbProductividad.Location = new Point(218, 65);
            lbProductividad.Name = "lbProductividad";
            lbProductividad.Size = new Size(181, 24);
            lbProductividad.TabIndex = 3;
            lbProductividad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 32);
            label3.Name = "label3";
            label3.Size = new Size(18, 21);
            label3.TabIndex = 4;
            label3.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 68);
            label4.Name = "label4";
            label4.Size = new Size(22, 21);
            label4.TabIndex = 5;
            label4.Text = "%";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(255, 428);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(129, 44);
            button2.TabIndex = 2;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormInformeDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 480);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormInformeDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Informe de productividad (15)";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public ListBox lsbActividades;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        public Label lbProduccionTotal;
        public Label lbProductividad;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
