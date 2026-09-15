namespace Ejercicio1.Vistas
{
    partial class FormActividadCierreDatos
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
            label0 = new Label();
            lbActividad = new Label();
            btnCerrarActividad = new Button();
            button2 = new Button();
            gbAgricola = new GroupBox();
            label1 = new Label();
            tbToneladas = new TextBox();
            label2 = new Label();
            tbPrecioTonelada = new TextBox();
            gbCria = new GroupBox();
            label3 = new Label();
            tbVacasMadres = new TextBox();
            label4 = new Label();
            tbTernerosDestete = new TextBox();
            label5 = new Label();
            tbPrecioTernero = new TextBox();
            gbIvernada = new GroupBox();
            label6 = new Label();
            tbKilosIniciales = new TextBox();
            label7 = new Label();
            tbKilosFinales = new TextBox();
            label8 = new Label();
            tbPrecioKilo = new TextBox();
            gbReCria = new GroupBox();
            label9 = new Label();
            tbKilosLogrados = new TextBox();
            label10 = new Label();
            tbPrecioKiloReCria = new TextBox();
            gbAgricola.SuspendLayout();
            gbCria.SuspendLayout();
            gbIvernada.SuspendLayout();
            gbReCria.SuspendLayout();
            SuspendLayout();
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(20, 14);
            label0.Name = "label0";
            label0.Size = new Size(80, 21);
            label0.TabIndex = 0;
            label0.Text = "Actividad:";
            // 
            // lbActividad
            // 
            lbActividad.BackColor = SystemColors.ActiveCaption;
            lbActividad.Location = new Point(110, 11);
            lbActividad.Name = "lbActividad";
            lbActividad.Size = new Size(570, 26);
            lbActividad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Toneladas cosechadas";
            // 
            // tbToneladas
            // 
            tbToneladas.Location = new Point(212, 32);
            tbToneladas.Margin = new Padding(4);
            tbToneladas.Name = "tbToneladas";
            tbToneladas.Size = new Size(110, 29);
            tbToneladas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 2;
            label2.Text = "Precio de la tonelada";
            // 
            // tbPrecioTonelada
            // 
            tbPrecioTonelada.Location = new Point(212, 72);
            tbPrecioTonelada.Margin = new Padding(4);
            tbPrecioTonelada.Name = "tbPrecioTonelada";
            tbPrecioTonelada.Size = new Size(110, 29);
            tbPrecioTonelada.TabIndex = 3;
            // 
            // gbAgricola
            // 
            gbAgricola.Controls.Add(label1);
            gbAgricola.Controls.Add(tbToneladas);
            gbAgricola.Controls.Add(label2);
            gbAgricola.Controls.Add(tbPrecioTonelada);
            gbAgricola.Location = new Point(13, 50);
            gbAgricola.Margin = new Padding(4);
            gbAgricola.Name = "gbAgricola";
            gbAgricola.Size = new Size(330, 160);
            gbAgricola.TabIndex = 0;
            gbAgricola.TabStop = false;
            gbAgricola.Text = "Agricola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 35);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 0;
            label3.Text = "Vacas madres";
            // 
            // tbVacasMadres
            // 
            tbVacasMadres.Location = new Point(212, 32);
            tbVacasMadres.Margin = new Padding(4);
            tbVacasMadres.Name = "tbVacasMadres";
            tbVacasMadres.Size = new Size(110, 29);
            tbVacasMadres.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 75);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 2;
            label4.Text = "Terneros destetados";
            // 
            // tbTernerosDestete
            // 
            tbTernerosDestete.Location = new Point(212, 72);
            tbTernerosDestete.Margin = new Padding(4);
            tbTernerosDestete.Name = "tbTernerosDestete";
            tbTernerosDestete.Size = new Size(110, 29);
            tbTernerosDestete.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 115);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 4;
            label5.Text = "Precio del ternero";
            // 
            // tbPrecioTernero
            // 
            tbPrecioTernero.Location = new Point(212, 112);
            tbPrecioTernero.Margin = new Padding(4);
            tbPrecioTernero.Name = "tbPrecioTernero";
            tbPrecioTernero.Size = new Size(110, 29);
            tbPrecioTernero.TabIndex = 5;
            // 
            // gbCria
            // 
            gbCria.Controls.Add(label3);
            gbCria.Controls.Add(tbVacasMadres);
            gbCria.Controls.Add(label4);
            gbCria.Controls.Add(tbTernerosDestete);
            gbCria.Controls.Add(label5);
            gbCria.Controls.Add(tbPrecioTernero);
            gbCria.Location = new Point(357, 50);
            gbCria.Margin = new Padding(4);
            gbCria.Name = "gbCria";
            gbCria.Size = new Size(330, 160);
            gbCria.TabIndex = 0;
            gbCria.TabStop = false;
            gbCria.Text = "Ganadera - Cria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 35);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 0;
            label6.Text = "Kilos iniciales";
            // 
            // tbKilosIniciales
            // 
            tbKilosIniciales.Location = new Point(212, 32);
            tbKilosIniciales.Margin = new Padding(4);
            tbKilosIniciales.Name = "tbKilosIniciales";
            tbKilosIniciales.Size = new Size(110, 29);
            tbKilosIniciales.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 75);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 2;
            label7.Text = "Kilos finales";
            // 
            // tbKilosFinales
            // 
            tbKilosFinales.Location = new Point(212, 72);
            tbKilosFinales.Margin = new Padding(4);
            tbKilosFinales.Name = "tbKilosFinales";
            tbKilosFinales.Size = new Size(110, 29);
            tbKilosFinales.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 115);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 4;
            label8.Text = "Precio del kilo";
            // 
            // tbPrecioKilo
            // 
            tbPrecioKilo.Location = new Point(212, 112);
            tbPrecioKilo.Margin = new Padding(4);
            tbPrecioKilo.Name = "tbPrecioKilo";
            tbPrecioKilo.Size = new Size(110, 29);
            tbPrecioKilo.TabIndex = 5;
            // 
            // gbIvernada
            // 
            gbIvernada.Controls.Add(label6);
            gbIvernada.Controls.Add(tbKilosIniciales);
            gbIvernada.Controls.Add(label7);
            gbIvernada.Controls.Add(tbKilosFinales);
            gbIvernada.Controls.Add(label8);
            gbIvernada.Controls.Add(tbPrecioKilo);
            gbIvernada.Location = new Point(13, 222);
            gbIvernada.Margin = new Padding(4);
            gbIvernada.Name = "gbIvernada";
            gbIvernada.Size = new Size(330, 160);
            gbIvernada.TabIndex = 0;
            gbIvernada.TabStop = false;
            gbIvernada.Text = "Ganadera - Ivernada";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 35);
            label9.Name = "label9";
            label9.Size = new Size(150, 21);
            label9.TabIndex = 0;
            label9.Text = "Kilos de carne logrados";
            // 
            // tbKilosLogrados
            // 
            tbKilosLogrados.Location = new Point(212, 32);
            tbKilosLogrados.Margin = new Padding(4);
            tbKilosLogrados.Name = "tbKilosLogrados";
            tbKilosLogrados.Size = new Size(110, 29);
            tbKilosLogrados.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 75);
            label10.Name = "label10";
            label10.Size = new Size(150, 21);
            label10.TabIndex = 2;
            label10.Text = "Precio del kilo";
            // 
            // tbPrecioKiloReCria
            // 
            tbPrecioKiloReCria.Location = new Point(212, 72);
            tbPrecioKiloReCria.Margin = new Padding(4);
            tbPrecioKiloReCria.Name = "tbPrecioKiloReCria";
            tbPrecioKiloReCria.Size = new Size(110, 29);
            tbPrecioKiloReCria.TabIndex = 3;
            // 
            // gbReCria
            // 
            gbReCria.Controls.Add(label9);
            gbReCria.Controls.Add(tbKilosLogrados);
            gbReCria.Controls.Add(label10);
            gbReCria.Controls.Add(tbPrecioKiloReCria);
            gbReCria.Location = new Point(357, 222);
            gbReCria.Margin = new Padding(4);
            gbReCria.Name = "gbReCria";
            gbReCria.Size = new Size(330, 160);
            gbReCria.TabIndex = 0;
            gbReCria.TabStop = false;
            gbReCria.Text = "Ganadera - ReCria";
            // 
            // btnCerrarActividad
            // 
            btnCerrarActividad.DialogResult = DialogResult.OK;
            btnCerrarActividad.Location = new Point(300, 400);
            btnCerrarActividad.Margin = new Padding(5);
            btnCerrarActividad.Name = "btnCerrarActividad";
            btnCerrarActividad.Size = new Size(215, 92);
            btnCerrarActividad.TabIndex = 10;
            btnCerrarActividad.Text = "Cerrar Actividad";
            btnCerrarActividad.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(535, 400);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(151, 92);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormActividadCierreDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 520);
            Controls.Add(button2);
            Controls.Add(btnCerrarActividad);
            Controls.Add(gbAgricola);
            Controls.Add(gbCria);
            Controls.Add(gbIvernada);
            Controls.Add(gbReCria);
            Controls.Add(lbActividad);
            Controls.Add(label0);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormActividadCierreDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cierre de actividad (14)";
            gbAgricola.ResumeLayout(false);
            gbAgricola.PerformLayout();
            gbCria.ResumeLayout(false);
            gbCria.PerformLayout();
            gbIvernada.ResumeLayout(false);
            gbIvernada.PerformLayout();
            gbReCria.ResumeLayout(false);
            gbReCria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label0;
        public Label lbActividad;
        private Button btnCerrarActividad;
        private Button button2;
        private Label label1;
        public TextBox tbToneladas;
        private Label label2;
        public TextBox tbPrecioTonelada;
        public GroupBox gbAgricola;
        private Label label3;
        public TextBox tbVacasMadres;
        private Label label4;
        public TextBox tbTernerosDestete;
        private Label label5;
        public TextBox tbPrecioTernero;
        public GroupBox gbCria;
        private Label label6;
        public TextBox tbKilosIniciales;
        private Label label7;
        public TextBox tbKilosFinales;
        private Label label8;
        public TextBox tbPrecioKilo;
        public GroupBox gbIvernada;
        private Label label9;
        public TextBox tbKilosLogrados;
        private Label label10;
        public TextBox tbPrecioKiloReCria;
        public GroupBox gbReCria;
    }
}
