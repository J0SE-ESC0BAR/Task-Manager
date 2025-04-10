using System.Drawing;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    partial class Prinsipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prinsipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Buscar = new System.Windows.Forms.ToolStripComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ScrapearTareas = new System.Windows.Forms.Button();
            this.dGV_TScraped = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlTareas = new System.Windows.Forms.TabControl();
            this.tabPageScraper = new System.Windows.Forms.TabPage();
            this.rTB_Console = new System.Windows.Forms.RichTextBox();
            this.txB_DiaHoy = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TScraped)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControlTareas.SuspendLayout();
            this.tabPageScraper.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.Buscar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1010, 27);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Tag = "";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEstudianteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.nuevoEstudianteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ayudaToolStripMenuItem.Checked = true;
            this.ayudaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.acercadeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = false;
            this.Buscar.BackColor = System.Drawing.Color.DimGray;
            this.Buscar.IntegralHeight = false;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(136, 23);
            this.Buscar.Sorted = true;
            this.Buscar.Tag = "";
            this.Buscar.Text = "Buscar";
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "Gestor de TAREAS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 36);
            this.panel1.TabIndex = 59;
            // 
            // btn_ScrapearTareas
            // 
            this.btn_ScrapearTareas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ScrapearTareas.Location = new System.Drawing.Point(908, 220);
            this.btn_ScrapearTareas.Name = "btn_ScrapearTareas";
            this.btn_ScrapearTareas.Size = new System.Drawing.Size(95, 54);
            this.btn_ScrapearTareas.TabIndex = 67;
            this.btn_ScrapearTareas.Text = "Actualizar";
            this.btn_ScrapearTareas.UseVisualStyleBackColor = true;
            this.btn_ScrapearTareas.Click += new System.EventHandler(this.btn_ScrapearTareas_Click);
            // 
            // dGV_TScraped
            // 
            this.dGV_TScraped.AllowUserToAddRows = false;
            this.dGV_TScraped.AllowUserToDeleteRows = false;
            this.dGV_TScraped.AllowUserToResizeColumns = false;
            this.dGV_TScraped.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dGV_TScraped.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_TScraped.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TScraped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_TScraped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_TScraped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_TScraped.GridColor = System.Drawing.Color.DimGray;
            this.dGV_TScraped.Location = new System.Drawing.Point(3, 3);
            this.dGV_TScraped.Name = "dGV_TScraped";
            this.dGV_TScraped.ReadOnly = true;
            this.dGV_TScraped.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dGV_TScraped.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_TScraped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_TScraped.Size = new System.Drawing.Size(876, 403);
            this.dGV_TScraped.TabIndex = 0;
            this.dGV_TScraped.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1010, 22);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControlTareas
            // 
            this.tabControlTareas.Controls.Add(this.tabPageScraper);
            this.tabControlTareas.Location = new System.Drawing.Point(12, 80);
            this.tabControlTareas.Name = "tabControlTareas";
            this.tabControlTareas.SelectedIndex = 0;
            this.tabControlTareas.Size = new System.Drawing.Size(890, 442);
            this.tabControlTareas.TabIndex = 71;
            this.tabControlTareas.SelectedIndexChanged += new System.EventHandler(this.tabControlTareas_SelectedIndexChanged);
            // 
            // tabPageScraper
            // 
            this.tabPageScraper.Controls.Add(this.dGV_TScraped);
            this.tabPageScraper.Location = new System.Drawing.Point(4, 29);
            this.tabPageScraper.Name = "tabPageScraper";
            this.tabPageScraper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScraper.Size = new System.Drawing.Size(882, 409);
            this.tabPageScraper.TabIndex = 1;
            this.tabPageScraper.Text = "Scraper";
            this.tabPageScraper.UseVisualStyleBackColor = true;
            // 
            // rTB_Console
            // 
            this.rTB_Console.BackColor = System.Drawing.SystemColors.WindowText;
            this.rTB_Console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTB_Console.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB_Console.ForeColor = System.Drawing.SystemColors.Window;
            this.rTB_Console.Location = new System.Drawing.Point(0, 541);
            this.rTB_Console.Name = "rTB_Console";
            this.rTB_Console.ReadOnly = true;
            this.rTB_Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTB_Console.Size = new System.Drawing.Size(1010, 96);
            this.rTB_Console.TabIndex = 62;
            this.rTB_Console.Text = "";
            // 
            // txB_DiaHoy
            // 
            this.txB_DiaHoy.BackColor = System.Drawing.Color.RoyalBlue;
            this.txB_DiaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_DiaHoy.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_DiaHoy.Location = new System.Drawing.Point(912, 133);
            this.txB_DiaHoy.Multiline = true;
            this.txB_DiaHoy.Name = "txB_DiaHoy";
            this.txB_DiaHoy.ReadOnly = true;
            this.txB_DiaHoy.Size = new System.Drawing.Size(85, 73);
            this.txB_DiaHoy.TabIndex = 77;
            this.txB_DiaHoy.Text = "01";
            this.txB_DiaHoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Location = new System.Drawing.Point(912, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(85, 26);
            this.textBox2.TabIndex = 78;
            this.textBox2.Text = "Hoy";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Dia.Location = new System.Drawing.Point(936, 184);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(47, 20);
            this.lbl_Dia.TabIndex = 79;
            this.lbl_Dia.Text = "Dom.";
            this.lbl_Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prinsipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1010, 659);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.txB_DiaHoy);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rTB_Console);
            this.Controls.Add(this.tabControlTareas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_ScrapearTareas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Prinsipal";
            this.Text = "Task Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TScraped)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlTareas.ResumeLayout(false);
            this.tabPageScraper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox Buscar;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private Button btn_ScrapearTareas;
        private DataGridView dGV_TScraped;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControlTareas;
        private TabPage tabPageScraper;
        private RichTextBox rTB_Console;
        private TextBox txB_DiaHoy;
        private TextBox textBox2;
        private Label lbl_Dia;
    }
}

