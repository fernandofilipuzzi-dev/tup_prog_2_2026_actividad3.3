namespace Ejercicio1.Vistas
{
    partial class FormLoteDatos
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
            label1 = new Label();
            cmbCampos = new ComboBox();
            label2 = new Label();
            lsbParcelas = new ListBox();
            btnConfirmar = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCampos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lsbParcelas);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asignación de lote";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 42);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "Elegir campo";
            // 
            // cmbCampos
            // 
            cmbCampos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCampos.FormattingEnabled = true;
            cmbCampos.Location = new Point(185, 38);
            cmbCampos.Margin = new Padding(4);
            cmbCampos.Name = "cmbCampos";
            cmbCampos.Size = new Size(199, 29);
            cmbCampos.TabIndex = 1;
            cmbCampos.SelectedIndexChanged += cmbCampos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 2;
            label2.Text = "Parcelas del campo";
            // 
            // lsbParcelas
            // 
            lsbParcelas.FormattingEnabled = true;
            lsbParcelas.Location = new Point(40, 120);
            lsbParcelas.Margin = new Padding(4);
            lsbParcelas.Name = "lsbParcelas";
            lsbParcelas.Size = new Size(460, 193);
            lsbParcelas.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = DialogResult.OK;
            btnConfirmar.Location = new Point(170, 352);
            btnConfirmar.Margin = new Padding(5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 58);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(355, 352);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(170, 58);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormLoteDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 420);
            Controls.Add(button2);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormLoteDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Asignar lote (13)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        public ComboBox cmbCampos;
        private Label label2;
        public ListBox lsbParcelas;
        private Button btnConfirmar;
        private Button button2;
    }
}
