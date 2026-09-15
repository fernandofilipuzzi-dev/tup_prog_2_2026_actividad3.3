namespace Ejercicio1.Vistas.Adms
{
    partial class FormUnaActividadAdm
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
            lsbLotes = new ListBox();
            btnActualizar = new Button();
            btnAsignarLote = new Button();
            btnCerrarActividad = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbTipo = new Label();
            lbPeriodo = new Label();
            lbDescripcion = new Label();
            lbSuperficieOcupada = new Label();
            lbEstado = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(242, 546);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 13;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbLotes);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAsignarLote);
            groupBox1.Controls.Add(btnCerrarActividad);
            groupBox1.Location = new Point(12, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 314);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de lotes asignados";
            // 
            // lsbLotes
            // 
            lsbLotes.FormattingEnabled = true;
            lsbLotes.Location = new Point(7, 29);
            lsbLotes.Margin = new Padding(4);
            lsbLotes.Name = "lsbLotes";
            lsbLotes.Size = new Size(394, 277);
            lsbLotes.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.DialogResult = DialogResult.Retry;
            btnActualizar.Location = new Point(410, 64);
            btnActualizar.Margin = new Padding(5, 6, 5, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(171, 65);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar Listado";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAsignarLote
            // 
            btnAsignarLote.DialogResult = DialogResult.TryAgain;
            btnAsignarLote.Location = new Point(410, 141);
            btnAsignarLote.Margin = new Padding(5, 6, 5, 6);
            btnAsignarLote.Name = "btnAsignarLote";
            btnAsignarLote.Size = new Size(171, 65);
            btnAsignarLote.TabIndex = 8;
            btnAsignarLote.Text = "Asignar Lote";
            btnAsignarLote.UseVisualStyleBackColor = true;
            // 
            // btnCerrarActividad
            // 
            btnCerrarActividad.DialogResult = DialogResult.Continue;
            btnCerrarActividad.Location = new Point(410, 218);
            btnCerrarActividad.Margin = new Padding(5, 6, 5, 6);
            btnCerrarActividad.Name = "btnCerrarActividad";
            btnCerrarActividad.Size = new Size(171, 65);
            btnCerrarActividad.TabIndex = 9;
            btnCerrarActividad.Text = "Cerrar Actividad";
            btnCerrarActividad.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lbTipo);
            groupBox2.Controls.Add(lbPeriodo);
            groupBox2.Controls.Add(lbDescripcion);
            groupBox2.Controls.Add(lbSuperficieOcupada);
            groupBox2.Controls.Add(lbEstado);
            groupBox2.Location = new Point(12, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 215);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de la actividad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 72);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Periodo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 107);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 142);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 3;
            label4.Text = "Superficie ocupada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 177);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // lbTipo
            // 
            lbTipo.BackColor = SystemColors.ActiveCaption;
            lbTipo.Location = new Point(230, 34);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(181, 24);
            lbTipo.TabIndex = 5;
            // 
            // lbPeriodo
            // 
            lbPeriodo.BackColor = SystemColors.ActiveCaption;
            lbPeriodo.Location = new Point(230, 69);
            lbPeriodo.Name = "lbPeriodo";
            lbPeriodo.Size = new Size(181, 24);
            lbPeriodo.TabIndex = 6;
            // 
            // lbDescripcion
            // 
            lbDescripcion.BackColor = SystemColors.ActiveCaption;
            lbDescripcion.Location = new Point(230, 104);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(181, 24);
            lbDescripcion.TabIndex = 7;
            // 
            // lbSuperficieOcupada
            // 
            lbSuperficieOcupada.BackColor = SystemColors.ActiveCaption;
            lbSuperficieOcupada.Location = new Point(230, 139);
            lbSuperficieOcupada.Name = "lbSuperficieOcupada";
            lbSuperficieOcupada.Size = new Size(181, 24);
            lbSuperficieOcupada.TabIndex = 8;
            // 
            // lbEstado
            // 
            lbEstado.BackColor = SystemColors.ActiveCaption;
            lbEstado.Location = new Point(230, 174);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(181, 24);
            lbEstado.TabIndex = 9;
            // 
            // FormUnaActividadAdm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 610);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormUnaActividadAdm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administrar una actividad (12)";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        public ListBox lsbLotes;
        private Button btnActualizar;
        private Button btnAsignarLote;
        private Button btnCerrarActividad;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public Label lbTipo;
        public Label lbPeriodo;
        public Label lbDescripcion;
        public Label lbSuperficieOcupada;
        public Label lbEstado;
    }
}
