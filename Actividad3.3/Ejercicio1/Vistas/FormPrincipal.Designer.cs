namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            camposToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            estanciaToolStripMenuItem = new ToolStripMenuItem();
            verDatosToolStripMenuItem = new ToolStripMenuItem();
            camposToolStripMenuItem1 = new ToolStripMenuItem();
            administrarCamposToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            administracionGeneralToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            actividadesToolStripMenuItem = new ToolStripMenuItem();
            puestosToolStripMenuItem = new ToolStripMenuItem();
            cascoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { camposToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 26);
            // 
            // camposToolStripMenuItem
            // 
            camposToolStripMenuItem.Name = "camposToolStripMenuItem";
            camposToolStripMenuItem.Size = new Size(118, 22);
            camposToolStripMenuItem.Text = "Campos";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { estanciaToolStripMenuItem, camposToolStripMenuItem1, administracionGeneralToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(458, 29);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // estanciaToolStripMenuItem
            // 
            estanciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verDatosToolStripMenuItem });
            estanciaToolStripMenuItem.Name = "estanciaToolStripMenuItem";
            estanciaToolStripMenuItem.Size = new Size(78, 25);
            estanciaToolStripMenuItem.Text = "Estancia";
            // 
            // verDatosToolStripMenuItem
            // 
            verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            verDatosToolStripMenuItem.Size = new Size(147, 26);
            verDatosToolStripMenuItem.Text = "Ver Datos";
            // 
            // camposToolStripMenuItem1
            // 
            camposToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { administrarCamposToolStripMenuItem, toolStripSeparator1, actividadesToolStripMenuItem, toolStripSeparator2, puestosToolStripMenuItem, cascoToolStripMenuItem });
            camposToolStripMenuItem1.Name = "camposToolStripMenuItem1";
            camposToolStripMenuItem1.Size = new Size(127, 25);
            camposToolStripMenuItem1.Text = "Administracion";
            // 
            // administrarCamposToolStripMenuItem
            // 
            administrarCamposToolStripMenuItem.Name = "administrarCamposToolStripMenuItem";
            administrarCamposToolStripMenuItem.Size = new Size(180, 26);
            administrarCamposToolStripMenuItem.Text = "Campos";
            administrarCamposToolStripMenuItem.Click += administrarCamposToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // administracionGeneralToolStripMenuItem
            // 
            administracionGeneralToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informesToolStripMenuItem });
            administracionGeneralToolStripMenuItem.Name = "administracionGeneralToolStripMenuItem";
            administracionGeneralToolStripMenuItem.Size = new Size(185, 25);
            administracionGeneralToolStripMenuItem.Text = "Administracion General";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(235, 26);
            informesToolStripMenuItem.Text = "Informe productividad";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // actividadesToolStripMenuItem
            // 
            actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            actividadesToolStripMenuItem.Size = new Size(180, 26);
            actividadesToolStripMenuItem.Text = "Actividades";
            actividadesToolStripMenuItem.Click += actividadesToolStripMenuItem_Click;
            // 
            // puestosToolStripMenuItem
            // 
            puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            puestosToolStripMenuItem.Size = new Size(180, 26);
            puestosToolStripMenuItem.Text = "Puestos";
            puestosToolStripMenuItem.Click += puestosToolStripMenuItem_Click;
            // 
            // cascoToolStripMenuItem
            // 
            cascoToolStripMenuItem.Name = "cascoToolStripMenuItem";
            cascoToolStripMenuItem.Size = new Size(180, 26);
            cascoToolStripMenuItem.Text = "Casco";
            cascoToolStripMenuItem.Click += cascoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(156, 6);
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 181);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            Load += FormPrincipal_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem camposToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem estanciaToolStripMenuItem;
        private ToolStripMenuItem verDatosToolStripMenuItem;
        private ToolStripMenuItem camposToolStripMenuItem1;
        private ToolStripMenuItem administrarCamposToolStripMenuItem;
        private ToolStripMenuItem administracionGeneralToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem actividadesToolStripMenuItem;
        private ToolStripMenuItem puestosToolStripMenuItem;
        private ToolStripMenuItem cascoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}
