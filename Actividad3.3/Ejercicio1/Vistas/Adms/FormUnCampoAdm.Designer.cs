namespace Ejercicio1.Vistas
{
    partial class FormUnCampoAdm
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
            groupBox1 = new GroupBox();
            lsbParcelas = new ListBox();
            btnAltaCampo = new Button();
            button1 = new Button();
            btnAdministrarCampo = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            lbSuperficieSinParcelar = new Label();
            lbSuperficieTotal = new Label();
            lbIdentificador = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(242, 490);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 13;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbParcelas);
            groupBox1.Controls.Add(btnAltaCampo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdministrarCampo);
            groupBox1.Location = new Point(12, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 314);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de parcelas";
            // 
            // lsbParcelas
            // 
            lsbParcelas.FormattingEnabled = true;
            lsbParcelas.Location = new Point(7, 29);
            lsbParcelas.Margin = new Padding(4);
            lsbParcelas.Name = "lsbParcelas";
            lsbParcelas.Size = new Size(394, 277);
            lsbParcelas.TabIndex = 7;
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
            // button1
            // 
            button1.DialogResult = DialogResult.TryAgain;
            button1.Location = new Point(410, 141);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(171, 65);
            button1.TabIndex = 8;
            button1.Text = "Agregar Parcela";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarCampo
            // 
            btnAdministrarCampo.DialogResult = DialogResult.Continue;
            btnAdministrarCampo.Location = new Point(410, 218);
            btnAdministrarCampo.Margin = new Padding(5, 6, 5, 6);
            btnAdministrarCampo.Name = "btnAdministrarCampo";
            btnAdministrarCampo.Size = new Size(171, 65);
            btnAdministrarCampo.TabIndex = 9;
            btnAdministrarCampo.Text = "Modificar Parcela";
            btnAdministrarCampo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbIdentificador);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lbSuperficieSinParcelar);
            groupBox2.Controls.Add(lbSuperficieTotal);
            groupBox2.Location = new Point(12, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 160);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado del campo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 117);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 3;
            label2.Text = "Supeficie Sin Parcelar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 75);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 2;
            label1.Text = "Superficie Total:";
            // 
            // lbSuperficieSinParcelar
            // 
            lbSuperficieSinParcelar.BackColor = SystemColors.ActiveCaption;
            lbSuperficieSinParcelar.Location = new Point(230, 114);
            lbSuperficieSinParcelar.Name = "lbSuperficieSinParcelar";
            lbSuperficieSinParcelar.Size = new Size(181, 24);
            lbSuperficieSinParcelar.TabIndex = 1;
            // 
            // lbSuperficieTotal
            // 
            lbSuperficieTotal.BackColor = SystemColors.ActiveCaption;
            lbSuperficieTotal.Location = new Point(230, 75);
            lbSuperficieTotal.Name = "lbSuperficieTotal";
            lbSuperficieTotal.Size = new Size(181, 24);
            lbSuperficieTotal.TabIndex = 0;
            // 
            // lbIdentificador
            // 
            lbIdentificador.BackColor = SystemColors.ActiveCaption;
            lbIdentificador.Location = new Point(230, 37);
            lbIdentificador.Name = "lbIdentificador";
            lbIdentificador.Size = new Size(181, 24);
            lbIdentificador.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 37);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 5;
            label4.Text = "Identificador:";
            // 
            // FormUnCampoAdm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 555);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormUnCampoAdm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administrar un campo";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        public ListBox lsbParcelas;
        private Button btnAltaCampo;
        private Button button1;
        private Button btnAdministrarCampo;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        public Label lbIdentificador;
        public Label lbSuperficieSinParcelar;
        public Label lbSuperficieTotal;
    }
}