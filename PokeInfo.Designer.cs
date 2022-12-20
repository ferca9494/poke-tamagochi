namespace PokePet
{
    partial class Pokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            this.poke_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.poke_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.poke_sx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.poke_type1 = new System.Windows.Forms.Label();
            this.poke_type2 = new System.Windows.Forms.Label();
            this.poke_agi = new System.Windows.Forms.Label();
            this.poke_fue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.poke_res = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Feliz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vita = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.felibar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poke_img)).BeginInit();
            this.SuspendLayout();
            // 
            // poke_img
            // 
            this.poke_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.poke_img.Location = new System.Drawing.Point(12, 12);
            this.poke_img.Name = "poke_img";
            this.poke_img.Size = new System.Drawing.Size(160, 160);
            this.poke_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poke_img.TabIndex = 0;
            this.poke_img.TabStop = false;
            this.poke_img.Click += new System.EventHandler(this.poke_img_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // poke_name
            // 
            this.poke_name.AutoSize = true;
            this.poke_name.Location = new System.Drawing.Point(243, 13);
            this.poke_name.Name = "poke_name";
            this.poke_name.Size = new System.Drawing.Size(10, 13);
            this.poke_name.TabIndex = 4;
            this.poke_name.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(370, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "[Editar]";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo:";
            // 
            // poke_sx
            // 
            this.poke_sx.AutoSize = true;
            this.poke_sx.Location = new System.Drawing.Point(243, 36);
            this.poke_sx.Name = "poke_sx";
            this.poke_sx.Size = new System.Drawing.Size(10, 13);
            this.poke_sx.TabIndex = 9;
            this.poke_sx.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo2:";
            // 
            // poke_type1
            // 
            this.poke_type1.AutoSize = true;
            this.poke_type1.Location = new System.Drawing.Point(243, 61);
            this.poke_type1.Name = "poke_type1";
            this.poke_type1.Size = new System.Drawing.Size(10, 13);
            this.poke_type1.TabIndex = 5;
            this.poke_type1.Text = "-";
            // 
            // poke_type2
            // 
            this.poke_type2.AutoSize = true;
            this.poke_type2.Location = new System.Drawing.Point(243, 84);
            this.poke_type2.Name = "poke_type2";
            this.poke_type2.Size = new System.Drawing.Size(10, 13);
            this.poke_type2.TabIndex = 6;
            this.poke_type2.Text = "-";
            // 
            // poke_agi
            // 
            this.poke_agi.AutoSize = true;
            this.poke_agi.Location = new System.Drawing.Point(282, 133);
            this.poke_agi.Name = "poke_agi";
            this.poke_agi.Size = new System.Drawing.Size(10, 13);
            this.poke_agi.TabIndex = 13;
            this.poke_agi.Text = "-";
            // 
            // poke_fue
            // 
            this.poke_fue.AutoSize = true;
            this.poke_fue.Location = new System.Drawing.Point(234, 133);
            this.poke_fue.Name = "poke_fue";
            this.poke_fue.Size = new System.Drawing.Size(10, 13);
            this.poke_fue.TabIndex = 12;
            this.poke_fue.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Agilidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Fuerza";
            // 
            // poke_res
            // 
            this.poke_res.AutoSize = true;
            this.poke_res.Location = new System.Drawing.Point(335, 133);
            this.poke_res.Name = "poke_res";
            this.poke_res.Size = new System.Drawing.Size(10, 13);
            this.poke_res.TabIndex = 15;
            this.poke_res.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Resistencia";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nivel.Location = new System.Drawing.Point(56, 155);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(10, 13);
            this.nivel.TabIndex = 16;
            this.nivel.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(246, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(359, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Feliz
            // 
            this.Feliz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Feliz.Location = new System.Drawing.Point(342, 159);
            this.Feliz.Name = "Feliz";
            this.Feliz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Feliz.Size = new System.Drawing.Size(80, 13);
            this.Feliz.TabIndex = 20;
            this.Feliz.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Felicidad:";
            // 
            // Vita
            // 
            this.Vita.AutoSize = true;
            this.Vita.Location = new System.Drawing.Point(179, 133);
            this.Vita.Name = "Vita";
            this.Vita.Size = new System.Drawing.Size(10, 13);
            this.Vita.TabIndex = 22;
            this.Vita.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Vitalidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nivel:";
            // 
            // felibar
            // 
            this.felibar.BackColor = System.Drawing.Color.Green;
            this.felibar.BorderRadius = 5;
            this.felibar.Location = new System.Drawing.Point(12, 178);
            this.felibar.MaximumValue = 100;
            this.felibar.Name = "felibar";
            this.felibar.ProgressColor = System.Drawing.Color.Lime;
            this.felibar.Size = new System.Drawing.Size(407, 10);
            this.felibar.TabIndex = 25;
            this.felibar.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(131, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(429, 198);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.felibar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Vita);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Feliz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.poke_res);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.poke_agi);
            this.Controls.Add(this.poke_fue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.poke_sx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.poke_type2);
            this.Controls.Add(this.poke_type1);
            this.Controls.Add(this.poke_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poke_img);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pokedex";
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.PokeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poke_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poke_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label poke_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label poke_sx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label poke_type1;
        private System.Windows.Forms.Label poke_type2;
        private System.Windows.Forms.Label poke_agi;
        private System.Windows.Forms.Label poke_fue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label poke_res;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Feliz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Vita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuProgressBar felibar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}