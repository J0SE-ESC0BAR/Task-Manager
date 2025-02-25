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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prinsipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cB_Estudiante = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Aplicar = new System.Windows.Forms.Button();
            this.nUD_Horas = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.ckB_TutorPagado = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ckB_TareaEntregada = new System.Windows.Forms.CheckBox();
            this.ckB_TareaTerminada = new System.Windows.Forms.CheckBox();
            this.ckB_TareaIniciada = new System.Windows.Forms.CheckBox();
            this.ckB_TareaPagada = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarListaDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Buscar = new System.Windows.Forms.ToolStripComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ScrapearTareas = new System.Windows.Forms.Button();
            this.dGV_TScraped = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlTareas = new System.Windows.Forms.TabControl();
            this.tabPageScraper = new System.Windows.Forms.TabPage();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.rTB_Console = new System.Windows.Forms.RichTextBox();
            this.txB_DiaHoy = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Horas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TScraped)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControlTareas.SuspendLayout();
            this.tabPageScraper.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB_Estudiante
            // 
            this.cB_Estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cB_Estudiante.DisplayMember = "1";
            this.cB_Estudiante.Location = new System.Drawing.Point(109, 83);
            this.cB_Estudiante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Estudiante.MaxDropDownItems = 20;
            this.cB_Estudiante.Name = "cB_Estudiante";
            this.cB_Estudiante.Size = new System.Drawing.Size(128, 28);
            this.cB_Estudiante.TabIndex = 3;
            this.cB_Estudiante.MouseHover += new System.EventHandler(this.cBEstudiante_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Estudiante";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Terminado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 24);
            this.label14.TabIndex = 35;
            this.label14.Text = "Entregado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 24);
            this.label16.TabIndex = 39;
            this.label16.Text = "Iniciado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.btn_Aplicar);
            this.groupBox1.Controls.Add(this.nUD_Horas);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.ckB_TutorPagado);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.ckB_TareaEntregada);
            this.groupBox1.Controls.Add(this.ckB_TareaTerminada);
            this.groupBox1.Controls.Add(this.ckB_TareaIniciada);
            this.groupBox1.Controls.Add(this.ckB_TareaPagada);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(915, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(176, 401);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Tarea";
            // 
            // btn_Aplicar
            // 
            this.btn_Aplicar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Aplicar.Location = new System.Drawing.Point(53, 364);
            this.btn_Aplicar.Name = "btn_Aplicar";
            this.btn_Aplicar.Size = new System.Drawing.Size(77, 30);
            this.btn_Aplicar.TabIndex = 57;
            this.btn_Aplicar.Text = "Aplicar";
            this.btn_Aplicar.UseVisualStyleBackColor = false;
            this.btn_Aplicar.Click += new System.EventHandler(this.btn_Aplicar_Click);
            // 
            // nUD_Horas
            // 
            this.nUD_Horas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nUD_Horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Horas.ForeColor = System.Drawing.SystemColors.Info;
            this.nUD_Horas.Location = new System.Drawing.Point(101, 317);
            this.nUD_Horas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nUD_Horas.Name = "nUD_Horas";
            this.nUD_Horas.Size = new System.Drawing.Size(63, 26);
            this.nUD_Horas.TabIndex = 43;
            this.nUD_Horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 24);
            this.label19.TabIndex = 45;
            this.label19.Text = "Horas";
            // 
            // ckB_TutorPagado
            // 
            this.ckB_TutorPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckB_TutorPagado.BackColor = System.Drawing.Color.DimGray;
            this.ckB_TutorPagado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckB_TutorPagado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_TutorPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_TutorPagado.Location = new System.Drawing.Point(119, 264);
            this.ckB_TutorPagado.Margin = new System.Windows.Forms.Padding(0);
            this.ckB_TutorPagado.MaximumSize = new System.Drawing.Size(40, 20);
            this.ckB_TutorPagado.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckB_TutorPagado.Name = "ckB_TutorPagado";
            this.ckB_TutorPagado.Size = new System.Drawing.Size(40, 20);
            this.ckB_TutorPagado.TabIndex = 45;
            this.ckB_TutorPagado.UseVisualStyleBackColor = false;
            this.ckB_TutorPagado.MouseEnter += new System.EventHandler(this.ckB_TutorPagado_MouseEnter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 48);
            this.label17.TabIndex = 44;
            this.label17.Text = "Tutor\r\npagado";
            // 
            // ckB_TareaEntregada
            // 
            this.ckB_TareaEntregada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckB_TareaEntregada.BackColor = System.Drawing.Color.DimGray;
            this.ckB_TareaEntregada.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckB_TareaEntregada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_TareaEntregada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_TareaEntregada.Location = new System.Drawing.Point(119, 204);
            this.ckB_TareaEntregada.Margin = new System.Windows.Forms.Padding(0);
            this.ckB_TareaEntregada.MaximumSize = new System.Drawing.Size(40, 20);
            this.ckB_TareaEntregada.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckB_TareaEntregada.Name = "ckB_TareaEntregada";
            this.ckB_TareaEntregada.Size = new System.Drawing.Size(40, 20);
            this.ckB_TareaEntregada.TabIndex = 43;
            this.ckB_TareaEntregada.UseVisualStyleBackColor = false;
            this.ckB_TareaEntregada.MouseEnter += new System.EventHandler(this.ckB_TareaEntregada_MouseEnter);
            // 
            // ckB_TareaTerminada
            // 
            this.ckB_TareaTerminada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckB_TareaTerminada.BackColor = System.Drawing.Color.DimGray;
            this.ckB_TareaTerminada.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckB_TareaTerminada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_TareaTerminada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_TareaTerminada.Location = new System.Drawing.Point(119, 156);
            this.ckB_TareaTerminada.Margin = new System.Windows.Forms.Padding(0);
            this.ckB_TareaTerminada.MaximumSize = new System.Drawing.Size(40, 20);
            this.ckB_TareaTerminada.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckB_TareaTerminada.Name = "ckB_TareaTerminada";
            this.ckB_TareaTerminada.Size = new System.Drawing.Size(40, 20);
            this.ckB_TareaTerminada.TabIndex = 42;
            this.ckB_TareaTerminada.UseVisualStyleBackColor = false;
            this.ckB_TareaTerminada.MouseEnter += new System.EventHandler(this.ckB_TareaTerminada_MouseEnter);
            // 
            // ckB_TareaIniciada
            // 
            this.ckB_TareaIniciada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckB_TareaIniciada.BackColor = System.Drawing.Color.DimGray;
            this.ckB_TareaIniciada.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckB_TareaIniciada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_TareaIniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_TareaIniciada.Location = new System.Drawing.Point(119, 110);
            this.ckB_TareaIniciada.Margin = new System.Windows.Forms.Padding(0);
            this.ckB_TareaIniciada.MaximumSize = new System.Drawing.Size(40, 20);
            this.ckB_TareaIniciada.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckB_TareaIniciada.Name = "ckB_TareaIniciada";
            this.ckB_TareaIniciada.Size = new System.Drawing.Size(40, 20);
            this.ckB_TareaIniciada.TabIndex = 41;
            this.ckB_TareaIniciada.UseVisualStyleBackColor = false;
            this.ckB_TareaIniciada.MouseEnter += new System.EventHandler(this.ckB_TareaIniciada_MouseEnter);
            // 
            // ckB_TareaPagada
            // 
            this.ckB_TareaPagada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckB_TareaPagada.BackColor = System.Drawing.Color.DimGray;
            this.ckB_TareaPagada.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckB_TareaPagada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckB_TareaPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_TareaPagada.Location = new System.Drawing.Point(119, 56);
            this.ckB_TareaPagada.Margin = new System.Windows.Forms.Padding(0);
            this.ckB_TareaPagada.MaximumSize = new System.Drawing.Size(40, 40);
            this.ckB_TareaPagada.MinimumSize = new System.Drawing.Size(20, 20);
            this.ckB_TareaPagada.Name = "ckB_TareaPagada";
            this.ckB_TareaPagada.Size = new System.Drawing.Size(40, 21);
            this.ckB_TareaPagada.TabIndex = 40;
            this.ckB_TareaPagada.UseVisualStyleBackColor = false;
            this.ckB_TareaPagada.MouseEnter += new System.EventHandler(this.ckB_TareaPagada_MouseEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 48);
            this.label13.TabIndex = 34;
            this.label13.Text = "Tarea\r\npagada";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.Buscar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1103, 27);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Tag = "";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.nuevoEstudianteToolStripMenuItem,
            this.registrarTutorToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.actualizarListaDeTareasToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.BackColor = System.Drawing.Color.DimGray;
            this.nuevoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.nuevoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem1.Image")));
            this.nuevoToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(311, 26);
            this.nuevoToolStripMenuItem1.Text = "&Nueva tarea";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.nuevoEstudianteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.nuevoEstudianteToolStripMenuItem.Text = "&Registrar Estudiante";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // registrarTutorToolStripMenuItem
            // 
            this.registrarTutorToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.registrarTutorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarTutorToolStripMenuItem.Name = "registrarTutorToolStripMenuItem";
            this.registrarTutorToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.registrarTutorToolStripMenuItem.Text = "&Registrar Tutor";
            this.registrarTutorToolStripMenuItem.Click += new System.EventHandler(this.registrarTutorToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir tarea por linea de comandos";
            // 
            // actualizarListaDeTareasToolStripMenuItem
            // 
            this.actualizarListaDeTareasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.actualizarListaDeTareasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.actualizarListaDeTareasToolStripMenuItem.Name = "actualizarListaDeTareasToolStripMenuItem";
            this.actualizarListaDeTareasToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.actualizarListaDeTareasToolStripMenuItem.Text = "Actualizar lista de tareas";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar cambios en la base de datos";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.imprimirToolStripMenuItem.Text = "&Imprimir tiket de tarea";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.deshacerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.rehacerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.cortarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cortarToolStripMenuItem.Text = "Cor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.copiarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.pegarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.personalizarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 31);
            this.button2.TabIndex = 57;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
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
            this.panel1.Size = new System.Drawing.Size(1103, 36);
            this.panel1.TabIndex = 59;
            // 
            // btn_ScrapearTareas
            // 
            this.btn_ScrapearTareas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ScrapearTareas.Location = new System.Drawing.Point(835, 69);
            this.btn_ScrapearTareas.Name = "btn_ScrapearTareas";
            this.btn_ScrapearTareas.Size = new System.Drawing.Size(104, 54);
            this.btn_ScrapearTareas.TabIndex = 67;
            this.btn_ScrapearTareas.Text = "Scrapear Tareas";
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
            this.dGV_TScraped.Size = new System.Drawing.Size(802, 403);
            this.dGV_TScraped.TabIndex = 0;
            this.dGV_TScraped.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 801);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1103, 22);
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
            this.tabControlTareas.Location = new System.Drawing.Point(13, 254);
            this.tabControlTareas.Name = "tabControlTareas";
            this.tabControlTareas.SelectedIndex = 0;
            this.tabControlTareas.Size = new System.Drawing.Size(816, 442);
            this.tabControlTareas.TabIndex = 71;
            this.tabControlTareas.SelectedIndexChanged += new System.EventHandler(this.tabControlTareas_SelectedIndexChanged);
            // 
            // tabPageScraper
            // 
            this.tabPageScraper.Controls.Add(this.dGV_TScraped);
            this.tabPageScraper.Location = new System.Drawing.Point(4, 29);
            this.tabPageScraper.Name = "tabPageScraper";
            this.tabPageScraper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScraper.Size = new System.Drawing.Size(808, 409);
            this.tabPageScraper.TabIndex = 1;
            this.tabPageScraper.Text = "Scraper";
            this.tabPageScraper.UseVisualStyleBackColor = true;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.Color.Gray;
            this.btn_Cargar.Enabled = false;
            this.btn_Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar.Location = new System.Drawing.Point(835, 423);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(74, 36);
            this.btn_Cargar.TabIndex = 74;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // rTB_Console
            // 
            this.rTB_Console.BackColor = System.Drawing.SystemColors.WindowText;
            this.rTB_Console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTB_Console.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB_Console.ForeColor = System.Drawing.SystemColors.Window;
            this.rTB_Console.Location = new System.Drawing.Point(0, 705);
            this.rTB_Console.Name = "rTB_Console";
            this.rTB_Console.ReadOnly = true;
            this.rTB_Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTB_Console.Size = new System.Drawing.Size(1103, 96);
            this.rTB_Console.TabIndex = 62;
            this.rTB_Console.Text = "";
            // 
            // txB_DiaHoy
            // 
            this.txB_DiaHoy.BackColor = System.Drawing.Color.RoyalBlue;
            this.txB_DiaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_DiaHoy.ForeColor = System.Drawing.SystemColors.Window;
            this.txB_DiaHoy.Location = new System.Drawing.Point(995, 176);
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
            this.textBox2.Location = new System.Drawing.Point(995, 152);
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
            this.lbl_Dia.Location = new System.Drawing.Point(1019, 227);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(47, 20);
            this.lbl_Dia.TabIndex = 79;
            this.lbl_Dia.Text = "Dom.";
            this.lbl_Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Gray;
            this.btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.Location = new System.Drawing.Point(835, 378);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(74, 35);
            this.btn_Borrar.TabIndex = 62;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Gray;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(835, 327);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(74, 35);
            this.btn_Cancelar.TabIndex = 63;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Gray;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(835, 283);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(74, 36);
            this.btn_Editar.TabIndex = 64;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Prinsipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1103, 823);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.txB_DiaHoy);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rTB_Console);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.tabControlTareas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_ScrapearTareas);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cB_Estudiante);
            this.Controls.Add(this.label9);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Horas)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckB_TareaTerminada;
        private System.Windows.Forms.CheckBox ckB_TareaIniciada;
        private System.Windows.Forms.CheckBox ckB_TareaEntregada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox Buscar;
        private System.Windows.Forms.ToolStripMenuItem actualizarListaDeTareasToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nUD_Horas;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTutorToolStripMenuItem;
        private System.Windows.Forms.Button btn_Aplicar;
        private System.Windows.Forms.ComboBox cB_Estudiante;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private Button btn_ScrapearTareas;
        private DataGridView dGV_TScraped;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControlTareas;
        private TabPage tabPageScraper;
        private Button btn_Cargar;
        private RichTextBox rTB_Console;
        private TextBox txB_DiaHoy;
        private TextBox textBox2;
        private Label lbl_Dia;
        private CheckBox ckB_TutorPagado;
        private Label label17;
        private CheckBox ckB_TareaPagada;
        private Label label13;
        private Button btn_Borrar;
        private Button btn_Cancelar;
        private Button btn_Editar;
    }
}

