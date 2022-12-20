namespace PokePet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Eventos = new System.Windows.Forms.Timer(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refrescar = new System.Windows.Forms.Timer(this.components);
            this.Poke_slot1 = new System.Windows.Forms.PictureBox();
            this.Poke_slot6 = new System.Windows.Forms.PictureBox();
            this.Poke_slot4 = new System.Windows.Forms.PictureBox();
            this.Poke_slot5 = new System.Windows.Forms.PictureBox();
            this.Poke_slot3 = new System.Windows.Forms.PictureBox();
            this.Poke_slot2 = new System.Windows.Forms.PictureBox();
            this.PokemonIMG = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EstadoIMG = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cerrar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.z1 = new System.Windows.Forms.Label();
            this.z2 = new System.Windows.Forms.Label();
            this.z3 = new System.Windows.Forms.Label();
            this.z4 = new System.Windows.Forms.Label();
            this.z5 = new System.Windows.Forms.Label();
            this.z6 = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.min = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            this.onepersec = new System.Windows.Forms.Timer(this.components);
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Eventos
            // 
            this.Eventos.Enabled = true;
            this.Eventos.Interval = 300;
            this.Eventos.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.toolStripSeparator2,
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.toolStripSeparator1,
            this.opcionesToolStripMenuItem,
            this.toolStripSeparator3,
            this.salirToolStripMenuItem});
            this.crearToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.crearToolStripMenuItem.Text = "Archivo";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.crearToolStripMenuItem1.Text = "Nuevo";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.estadisticasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Poke_slot1
            // 
            this.Poke_slot1.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot1.BackgroundImage = global::PokePet.Properties.Resources.img_Poke1;
            this.Poke_slot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot1.Location = new System.Drawing.Point(54, 299);
            this.Poke_slot1.Name = "Poke_slot1";
            this.Poke_slot1.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot1.TabIndex = 47;
            this.Poke_slot1.TabStop = false;
            this.t.SetToolTip(this.Poke_slot1, "lol\r\n");
            this.Poke_slot1.Click += new System.EventHandler(this.Poke_slot1_Click);
            // 
            // Poke_slot6
            // 
            this.Poke_slot6.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poke_slot6.BackgroundImage")));
            this.Poke_slot6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot6.Location = new System.Drawing.Point(407, 299);
            this.Poke_slot6.Name = "Poke_slot6";
            this.Poke_slot6.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot6.TabIndex = 44;
            this.Poke_slot6.TabStop = false;
            this.Poke_slot6.Click += new System.EventHandler(this.Poke_slot6_Click);
            // 
            // Poke_slot4
            // 
            this.Poke_slot4.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poke_slot4.BackgroundImage")));
            this.Poke_slot4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot4.Location = new System.Drawing.Point(293, 342);
            this.Poke_slot4.Name = "Poke_slot4";
            this.Poke_slot4.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot4.TabIndex = 43;
            this.Poke_slot4.TabStop = false;
            this.Poke_slot4.Click += new System.EventHandler(this.Poke_slot5_Click);
            // 
            // Poke_slot5
            // 
            this.Poke_slot5.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poke_slot5.BackgroundImage")));
            this.Poke_slot5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot5.Location = new System.Drawing.Point(353, 326);
            this.Poke_slot5.Name = "Poke_slot5";
            this.Poke_slot5.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot5.TabIndex = 42;
            this.Poke_slot5.TabStop = false;
            this.Poke_slot5.Click += new System.EventHandler(this.Poke_slot4_Click);
            // 
            // Poke_slot3
            // 
            this.Poke_slot3.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poke_slot3.BackgroundImage")));
            this.Poke_slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot3.Location = new System.Drawing.Point(167, 342);
            this.Poke_slot3.Name = "Poke_slot3";
            this.Poke_slot3.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot3.TabIndex = 41;
            this.Poke_slot3.TabStop = false;
            this.Poke_slot3.Click += new System.EventHandler(this.Poke_slot3_Click);
            // 
            // Poke_slot2
            // 
            this.Poke_slot2.BackColor = System.Drawing.Color.Transparent;
            this.Poke_slot2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poke_slot2.BackgroundImage")));
            this.Poke_slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke_slot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Poke_slot2.Location = new System.Drawing.Point(110, 326);
            this.Poke_slot2.Name = "Poke_slot2";
            this.Poke_slot2.Size = new System.Drawing.Size(50, 50);
            this.Poke_slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke_slot2.TabIndex = 40;
            this.Poke_slot2.TabStop = false;
            this.Poke_slot2.Click += new System.EventHandler(this.Poke_slot2_Click);
            // 
            // PokemonIMG
            // 
            this.PokemonIMG.BackColor = System.Drawing.Color.Transparent;
            this.PokemonIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PokemonIMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PokemonIMG.Location = new System.Drawing.Point(148, 86);
            this.PokemonIMG.Name = "PokemonIMG";
            this.PokemonIMG.Size = new System.Drawing.Size(219, 181);
            this.PokemonIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonIMG.TabIndex = 8;
            this.PokemonIMG.TabStop = false;
            this.PokemonIMG.Click += new System.EventHandler(this.PokemonIMG_Click_1);
            this.PokemonIMG.DoubleClick += new System.EventHandler(this.PokemonIMG_Click);
            this.PokemonIMG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.PokemonIMG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PokemonIMG_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PokePet.Properties.Resources.icon_light;
            this.pictureBox3.Location = new System.Drawing.Point(379, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button2_Click);
            // 
            // EstadoIMG
            // 
            this.EstadoIMG.BackColor = System.Drawing.Color.Transparent;
            this.EstadoIMG.Location = new System.Drawing.Point(236, 35);
            this.EstadoIMG.Name = "EstadoIMG";
            this.EstadoIMG.Size = new System.Drawing.Size(49, 47);
            this.EstadoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EstadoIMG.TabIndex = 57;
            this.EstadoIMG.TabStop = false;
            this.EstadoIMG.Click += new System.EventHandler(this.EstadoIMG_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = " ";
            this.notifyIcon1.BalloonTipTitle = " ";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PokePet";
            this.notifyIcon1.Visible = true;
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.ForeColor = System.Drawing.Color.Black;
            this.cerrar.Location = new System.Drawing.Point(449, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(20, 20);
            this.cerrar.TabIndex = 59;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Nombre
            // 
            this.Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre.AutoEllipsis = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(149, 273);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(218, 0);
            this.Nombre.TabIndex = 60;
            this.Nombre.Text = "-";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // z1
            // 
            this.z1.AutoSize = true;
            this.z1.BackColor = System.Drawing.Color.Transparent;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1.Location = new System.Drawing.Point(77, 283);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(0, 13);
            this.z1.TabIndex = 61;
            // 
            // z2
            // 
            this.z2.AutoSize = true;
            this.z2.BackColor = System.Drawing.Color.Transparent;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.Location = new System.Drawing.Point(133, 308);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(0, 13);
            this.z2.TabIndex = 62;
            // 
            // z3
            // 
            this.z3.AutoSize = true;
            this.z3.BackColor = System.Drawing.Color.Transparent;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.Location = new System.Drawing.Point(190, 322);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(0, 13);
            this.z3.TabIndex = 63;
            // 
            // z4
            // 
            this.z4.AutoSize = true;
            this.z4.BackColor = System.Drawing.Color.Transparent;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z4.Location = new System.Drawing.Point(316, 326);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(0, 13);
            this.z4.TabIndex = 64;
            // 
            // z5
            // 
            this.z5.AutoSize = true;
            this.z5.BackColor = System.Drawing.Color.Transparent;
            this.z5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z5.Location = new System.Drawing.Point(376, 310);
            this.z5.Name = "z5";
            this.z5.Size = new System.Drawing.Size(0, 13);
            this.z5.TabIndex = 65;
            // 
            // z6
            // 
            this.z6.AutoSize = true;
            this.z6.BackColor = System.Drawing.Color.Transparent;
            this.z6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z6.ForeColor = System.Drawing.Color.Black;
            this.z6.Location = new System.Drawing.Point(430, 283);
            this.z6.Name = "z6";
            this.z6.Size = new System.Drawing.Size(0, 13);
            this.z6.TabIndex = 66;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.BackColor = System.Drawing.Color.Transparent;
            this.z.Location = new System.Drawing.Point(275, 35);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(0, 13);
            this.z.TabIndex = 67;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Pokesave.pks";
            this.openFileDialog1.Filter = "Archivo Pokesave|*.pks";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Pokesave.pks";
            this.saveFileDialog1.Filter = "Archivo Pokesave|*.pks";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::PokePet.Properties.Resources.icon_save;
            this.pictureBox7.Location = new System.Drawing.Point(423, 212);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 68;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::PokePet.Properties.Resources.icon_load;
            this.pictureBox6.Location = new System.Drawing.Point(379, 226);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(77, 237);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 77;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acerca de";
            this.linkLabel1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PokePet.Properties.Resources.img_Poke3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(231, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 79;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(100, 194);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(42, 13);
            this.linkLabel2.TabIndex = 80;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ayuda";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.ForeColor = System.Drawing.Color.Black;
            this.min.Location = new System.Drawing.Point(423, 12);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 20);
            this.min.TabIndex = 83;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.t.ForeColor = System.Drawing.Color.Lime;
            // 
            // onepersec
            // 
            this.onepersec.Enabled = true;
            this.onepersec.Interval = 1000;
            this.onepersec.Tick += new System.EventHandler(this.onepersec_Tick);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel4.Location = new System.Drawing.Point(293, 310);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(23, 13);
            this.linkLabel4.TabIndex = 84;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "XX";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel5.Location = new System.Drawing.Point(322, 308);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(23, 13);
            this.linkLabel5.TabIndex = 85;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "XX";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::PokePet.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.min);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.z);
            this.Controls.Add(this.z6);
            this.Controls.Add(this.z5);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.EstadoIMG);
            this.Controls.Add(this.Poke_slot1);
            this.Controls.Add(this.Poke_slot6);
            this.Controls.Add(this.Poke_slot4);
            this.Controls.Add(this.Poke_slot5);
            this.Controls.Add(this.Poke_slot3);
            this.Controls.Add(this.Poke_slot2);
            this.Controls.Add(this.PokemonIMG);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(293, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokegochi";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke_slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PokemonIMG;
        private System.Windows.Forms.Timer Eventos;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer Refrescar;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox Poke_slot2;
        private System.Windows.Forms.PictureBox Poke_slot3;
        private System.Windows.Forms.PictureBox Poke_slot5;
        private System.Windows.Forms.PictureBox Poke_slot4;
        private System.Windows.Forms.PictureBox Poke_slot6;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox Poke_slot1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox EstadoIMG;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label z1;
        private System.Windows.Forms.Label z2;
        private System.Windows.Forms.Label z3;
        private System.Windows.Forms.Label z4;
        private System.Windows.Forms.Label z5;
        private System.Windows.Forms.Label z6;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.ToolTip t;
        private System.Windows.Forms.Timer onepersec;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}

