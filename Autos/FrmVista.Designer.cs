namespace Carreras
{
    partial class FrmVista
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
            this.components = new System.ComponentModel.Container();
            this.tmrDibujar = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDibujar
            // 
            this.tmrDibujar.Enabled = true;
            this.tmrDibujar.Interval = 25;
            this.tmrDibujar.Tick += new System.EventHandler(this.tmrPaint_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.lblDistancia);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblPrimero);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(520, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 63);
            this.panel3.TabIndex = 10;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(169, 42);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(13, 13);
            this.lblDistancia.TabIndex = 12;
            this.lblDistancia.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distancia Recorrida (en Metros):";
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimero.Location = new System.Drawing.Point(80, 26);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(31, 13);
            this.lblPrimero.TabIndex = 10;
            this.lblPrimero.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Primer Lugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informacion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.seleccionarCamaraToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem1.Text = "Iniciar Carrera";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem2.Text = "Reiniciar Carrera";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // seleccionarCamaraToolStripMenuItem
            // 
            this.seleccionarCamaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camara1ToolStripMenuItem,
            this.camara2ToolStripMenuItem,
            this.camara3ToolStripMenuItem,
            this.camara4ToolStripMenuItem,
            this.cToolStripMenuItem});
            this.seleccionarCamaraToolStripMenuItem.Name = "seleccionarCamaraToolStripMenuItem";
            this.seleccionarCamaraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.seleccionarCamaraToolStripMenuItem.Text = "Seleccionar Camara";
            // 
            // camara1ToolStripMenuItem
            // 
            this.camara1ToolStripMenuItem.Name = "camara1ToolStripMenuItem";
            this.camara1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camara1ToolStripMenuItem.Tag = "0";
            this.camara1ToolStripMenuItem.Text = "Camara 1";
            this.camara1ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // camara2ToolStripMenuItem
            // 
            this.camara2ToolStripMenuItem.Name = "camara2ToolStripMenuItem";
            this.camara2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camara2ToolStripMenuItem.Tag = "1";
            this.camara2ToolStripMenuItem.Text = "Camara 2";
            this.camara2ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // camara3ToolStripMenuItem
            // 
            this.camara3ToolStripMenuItem.Name = "camara3ToolStripMenuItem";
            this.camara3ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camara3ToolStripMenuItem.Tag = "2";
            this.camara3ToolStripMenuItem.Text = "Camara 3";
            this.camara3ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // camara4ToolStripMenuItem
            // 
            this.camara4ToolStripMenuItem.Name = "camara4ToolStripMenuItem";
            this.camara4ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.camara4ToolStripMenuItem.Tag = "3";
            this.camara4ToolStripMenuItem.Text = "Camara 4";
            this.camara4ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cToolStripMenuItem.Tag = "4";
            this.cToolStripMenuItem.Text = "Camara 5";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // FrmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C A R R E R A";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer tmrDibujar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem seleccionarCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}

