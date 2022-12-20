namespace PokePet
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.Pokeball_timer = new System.Windows.Forms.Timer(this.components);
            this.pc = new System.Windows.Forms.Label();
            this.Refrescar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Enemy_HP = new System.Windows.Forms.ProgressBar();
            this.Enemy_Image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Ally_Name = new System.Windows.Forms.Label();
            this.Ally_Image = new System.Windows.Forms.PictureBox();
            this.Ally_HP = new System.Windows.Forms.ProgressBar();
            this.Enemy_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.racha = new System.Windows.Forms.Label();
            this.poke_cant = new System.Windows.Forms.Button();
            this.pokeball_cant = new System.Windows.Forms.Label();
            this.golpe_enemigo = new System.Windows.Forms.Timer(this.components);
            this.skill1 = new System.Windows.Forms.Button();
            this.skill2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cd1 = new System.Windows.Forms.Label();
            this.cd2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.atajos_teclado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_Image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ally_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Pokeball_timer
            // 
            this.Pokeball_timer.Enabled = true;
            this.Pokeball_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(226, 259);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(114, 13);
            this.pc.TabIndex = 12;
            this.pc.Text = "0";
            this.pc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Refrescar
            // 
            this.Refrescar.Enabled = true;
            this.Refrescar.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokePet.Properties.Resources.img_Pokedolares;
            this.pictureBox1.Location = new System.Drawing.Point(346, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 13);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Enemy_HP
            // 
            this.Enemy_HP.BackColor = System.Drawing.Color.White;
            this.Enemy_HP.Location = new System.Drawing.Point(50, 19);
            this.Enemy_HP.Maximum = 1000;
            this.Enemy_HP.Name = "Enemy_HP";
            this.Enemy_HP.Size = new System.Drawing.Size(110, 10);
            this.Enemy_HP.TabIndex = 13;
            // 
            // Enemy_Image
            // 
            this.Enemy_Image.BackColor = System.Drawing.Color.White;
            this.Enemy_Image.Location = new System.Drawing.Point(179, 3);
            this.Enemy_Image.Name = "Enemy_Image";
            this.Enemy_Image.Size = new System.Drawing.Size(110, 77);
            this.Enemy_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Enemy_Image.TabIndex = 14;
            this.Enemy_Image.TabStop = false;
            this.Enemy_Image.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ally_Name);
            this.panel1.Controls.Add(this.Ally_Image);
            this.panel1.Controls.Add(this.Ally_HP);
            this.panel1.Controls.Add(this.Enemy_Name);
            this.panel1.Controls.Add(this.Enemy_HP);
            this.panel1.Controls.Add(this.Enemy_Image);
            this.panel1.Location = new System.Drawing.Point(16, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 207);
            this.panel1.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(132, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Info.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "-";
            // 
            // Ally_Name
            // 
            this.Ally_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ally_Name.Location = new System.Drawing.Point(176, 123);
            this.Ally_Name.Name = "Ally_Name";
            this.Ally_Name.Size = new System.Drawing.Size(113, 13);
            this.Ally_Name.TabIndex = 18;
            this.Ally_Name.Text = "-";
            this.Ally_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Ally_Image
            // 
            this.Ally_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ally_Image.BackColor = System.Drawing.Color.White;
            this.Ally_Image.Location = new System.Drawing.Point(50, 123);
            this.Ally_Image.Name = "Ally_Image";
            this.Ally_Image.Size = new System.Drawing.Size(110, 77);
            this.Ally_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ally_Image.TabIndex = 17;
            this.Ally_Image.TabStop = false;
            // 
            // Ally_HP
            // 
            this.Ally_HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ally_HP.BackColor = System.Drawing.Color.White;
            this.Ally_HP.Location = new System.Drawing.Point(176, 139);
            this.Ally_HP.Maximum = 1000;
            this.Ally_HP.Name = "Ally_HP";
            this.Ally_HP.Size = new System.Drawing.Size(110, 10);
            this.Ally_HP.TabIndex = 16;
            // 
            // Enemy_Name
            // 
            this.Enemy_Name.AutoSize = true;
            this.Enemy_Name.Location = new System.Drawing.Point(47, 3);
            this.Enemy_Name.Name = "Enemy_Name";
            this.Enemy_Name.Size = new System.Drawing.Size(10, 13);
            this.Enemy_Name.TabIndex = 15;
            this.Enemy_Name.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Racha:";
            // 
            // racha
            // 
            this.racha.AutoSize = true;
            this.racha.Location = new System.Drawing.Point(64, 259);
            this.racha.Name = "racha";
            this.racha.Size = new System.Drawing.Size(13, 13);
            this.racha.TabIndex = 17;
            this.racha.Text = "0";
            // 
            // poke_cant
            // 
            this.poke_cant.BackColor = System.Drawing.Color.Silver;
            this.poke_cant.BackgroundImage = global::PokePet.Properties.Resources.item_Pokeball;
            this.poke_cant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.poke_cant.Enabled = false;
            this.poke_cant.Location = new System.Drawing.Point(257, 275);
            this.poke_cant.Name = "poke_cant";
            this.poke_cant.Size = new System.Drawing.Size(45, 45);
            this.poke_cant.TabIndex = 18;
            this.poke_cant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.poke_cant.UseVisualStyleBackColor = false;
            this.poke_cant.Click += new System.EventHandler(this.button10_Click);
            // 
            // pokeball_cant
            // 
            this.pokeball_cant.AutoSize = true;
            this.pokeball_cant.BackColor = System.Drawing.Color.Transparent;
            this.pokeball_cant.Location = new System.Drawing.Point(254, 307);
            this.pokeball_cant.Name = "pokeball_cant";
            this.pokeball_cant.Size = new System.Drawing.Size(18, 13);
            this.pokeball_cant.TabIndex = 19;
            this.pokeball_cant.Text = "x0";
            // 
            // golpe_enemigo
            // 
            this.golpe_enemigo.Enabled = true;
            this.golpe_enemigo.Interval = 500;
            this.golpe_enemigo.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // skill1
            // 
            this.skill1.BackColor = System.Drawing.Color.Transparent;
            this.skill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skill1.Location = new System.Drawing.Point(131, 275);
            this.skill1.Name = "skill1";
            this.skill1.Size = new System.Drawing.Size(45, 45);
            this.skill1.TabIndex = 21;
            this.skill1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skill1.UseVisualStyleBackColor = false;
            this.skill1.Click += new System.EventHandler(this.skill1_Click);
            // 
            // skill2
            // 
            this.skill2.BackColor = System.Drawing.Color.Transparent;
            this.skill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skill2.Location = new System.Drawing.Point(196, 275);
            this.skill2.Name = "skill2";
            this.skill2.Size = new System.Drawing.Size(45, 45);
            this.skill2.TabIndex = 22;
            this.skill2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skill2.UseVisualStyleBackColor = false;
            this.skill2.Click += new System.EventHandler(this.skill2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(67, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Golpe";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cd1
            // 
            this.cd1.AutoSize = true;
            this.cd1.Location = new System.Drawing.Point(144, 291);
            this.cd1.Name = "cd1";
            this.cd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cd1.Size = new System.Drawing.Size(13, 13);
            this.cd1.TabIndex = 24;
            this.cd1.Text = "0";
            this.cd1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cd2
            // 
            this.cd2.AutoSize = true;
            this.cd2.BackColor = System.Drawing.Color.Transparent;
            this.cd2.Location = new System.Drawing.Point(208, 291);
            this.cd2.Name = "cd2";
            this.cd2.Size = new System.Drawing.Size(13, 13);
            this.cd2.TabIndex = 25;
            this.cd2.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "Pradera"});
            this.comboBox1.Location = new System.Drawing.Point(235, 12);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pausa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ir a";
            // 
            // atajos_teclado
            // 
            this.atajos_teclado.Interval = 10;
            this.atajos_teclado.Tick += new System.EventHandler(this.atajos_teclado_Tick);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cd2);
            this.Controls.Add(this.cd1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skill2);
            this.Controls.Add(this.skill1);
            this.Controls.Add(this.pokeball_cant);
            this.Controls.Add(this.poke_cant);
            this.Controls.Add(this.racha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_Image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ally_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Pokeball_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Timer Refrescar;
        private System.Windows.Forms.ProgressBar Enemy_HP;
        private System.Windows.Forms.PictureBox Enemy_Image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Enemy_Name;
        private System.Windows.Forms.Label Ally_Name;
        private System.Windows.Forms.PictureBox Ally_Image;
        private System.Windows.Forms.ProgressBar Ally_HP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label racha;
        private System.Windows.Forms.Button poke_cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pokeball_cant;
        private System.Windows.Forms.Timer golpe_enemigo;
        private System.Windows.Forms.Button skill1;
        private System.Windows.Forms.Button skill2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cd1;
        private System.Windows.Forms.Label cd2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer atajos_teclado;
    }
}