namespace PokePet
{
    partial class Crear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Poke4 = new System.Windows.Forms.PictureBox();
            this.Poke3 = new System.Windows.Forms.PictureBox();
            this.Poke2 = new System.Windows.Forms.PictureBox();
            this.Poke1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Poke4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Pikachu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Empezar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(227, 279);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Macho";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(227, 302);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(62, 17);
            this.radioButton.TabIndex = 2;
            this.radioButton.Tag = "1";
            this.radioButton.Text = "Hembra";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PokePet.Properties.Resources.img_Poke3;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.Poke4);
            this.groupBox1.Controls.Add(this.Poke3);
            this.groupBox1.Controls.Add(this.Poke2);
            this.groupBox1.Controls.Add(this.Poke1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elige un Pokemon inicial";
            // 
            // Poke4
            // 
            this.Poke4.BackColor = System.Drawing.Color.Transparent;
            this.Poke4.BackgroundImage = global::PokePet.Properties.Resources.img_Poke2;
            this.Poke4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke4.Image = global::PokePet.Properties.Resources.Pikachu_icon;
            this.Poke4.Location = new System.Drawing.Point(108, 100);
            this.Poke4.Name = "Poke4";
            this.Poke4.Size = new System.Drawing.Size(56, 56);
            this.Poke4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke4.TabIndex = 51;
            this.Poke4.TabStop = false;
            this.Poke4.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Poke3
            // 
            this.Poke3.BackColor = System.Drawing.Color.Transparent;
            this.Poke3.BackgroundImage = global::PokePet.Properties.Resources.img_Poke1;
            this.Poke3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke3.Image = global::PokePet.Properties.Resources.Squirtle_icon_gif;
            this.Poke3.Location = new System.Drawing.Point(196, 38);
            this.Poke3.Name = "Poke3";
            this.Poke3.Size = new System.Drawing.Size(56, 56);
            this.Poke3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke3.TabIndex = 50;
            this.Poke3.TabStop = false;
            this.Poke3.Click += new System.EventHandler(this.opcion3_CheckedChanged);
            // 
            // Poke2
            // 
            this.Poke2.BackColor = System.Drawing.Color.Transparent;
            this.Poke2.BackgroundImage = global::PokePet.Properties.Resources.img_Poke1;
            this.Poke2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke2.Image = global::PokePet.Properties.Resources.Charmander_icon_gif;
            this.Poke2.Location = new System.Drawing.Point(108, 199);
            this.Poke2.Name = "Poke2";
            this.Poke2.Size = new System.Drawing.Size(56, 56);
            this.Poke2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke2.TabIndex = 49;
            this.Poke2.TabStop = false;
            this.Poke2.Click += new System.EventHandler(this.opcion2_CheckedChanged);
            // 
            // Poke1
            // 
            this.Poke1.BackColor = System.Drawing.Color.Transparent;
            this.Poke1.BackgroundImage = global::PokePet.Properties.Resources.img_Poke1;
            this.Poke1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke1.Image = global::PokePet.Properties.Resources.Bulbasaur_icon_gif;
            this.Poke1.Location = new System.Drawing.Point(18, 38);
            this.Poke1.Name = "Poke1";
            this.Poke1.Size = new System.Drawing.Size(56, 56);
            this.Poke1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Poke1.TabIndex = 48;
            this.Poke1.TabStop = false;
            this.Poke1.Click += new System.EventHandler(this.opcion1_CheckedChanged);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Juego";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Poke4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Poke3;
        private System.Windows.Forms.PictureBox Poke2;
        private System.Windows.Forms.PictureBox Poke1;
        private System.Windows.Forms.PictureBox Poke4;
    }
}