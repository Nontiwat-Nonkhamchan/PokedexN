namespace PokemondexN
{
    partial class Form1
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
            btnPikachu = new Button();
            btnEspeon = new Button();
            bthHatterene = new Button();
            btnSwirlix = new Button();
            bthJigglypuff = new Button();
            bthAlcremie = new Button();
            lbName = new Label();
            lbType = new Label();
            lbStats = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPikachu
            // 
            btnPikachu.BackColor = Color.White;
            btnPikachu.ForeColor = Color.MediumVioletRed;
            btnPikachu.Location = new Point(40, 35);
            btnPikachu.Name = "btnPikachu";
            btnPikachu.Size = new Size(94, 29);
            btnPikachu.TabIndex = 0;
            btnPikachu.Text = "Pikachu";
            btnPikachu.UseVisualStyleBackColor = false;
            btnPikachu.Click += btnPikachu_Click;
            // 
            // btnblastoise
            // 
            btnblastoise.ForeColor = Color.DeepPink;
            btnblastoise.Location = new Point(40, 103);
            btnblastoise.Name = "btnblastoise";
            btnblastoise.Size = new Size(94, 29);
            btnblastoise.TabIndex = 1;
            btnblastoise.Text = "blastoise";
            btnblastoise.UseVisualStyleBackColor = true;
            btnblastoise.Click += btnblastoise_Click;
            // 
            // bthweedle
            // 
            bthweedle.ForeColor = Color.HotPink;
            bthweedle.Location = new Point(40, 165);
            bthweedle.Name = "bthweedle";
            bthweedle.Size = new Size(94, 29);
            bthweedle.TabIndex = 2;
            bthweedle.Text = "weedle";
            bthweedle.UseVisualStyleBackColor = true;
            bthweedle.Click += bthweedle_Click;
            // 
            // btnrattata
            // 
            btnrattata.ForeColor = Color.PaleVioletRed;
            btnrattata.Location = new Point(40, 233);
            btnrattata.Name = "btnrattata";
            btnrattata.Size = new Size(94, 29);
            btnrattata.TabIndex = 3;
            btnrattata.Text = "rattata";
            btnrattata.UseVisualStyleBackColor = true;
            btnrattata.Click += btnrattata_Click;
            // 
            // bthpidgey
            // 
            bthpidgey.ForeColor = Color.Pink;
            bthpidgey.Location = new Point(40, 301);
            bthpidgey.Name = "bthpidgey";
            bthpidgey.Size = new Size(94, 29);
            bthpidgey.TabIndex = 4;
            bthpidgey.Text = "pidgey";
            bthpidgey.UseVisualStyleBackColor = true;
            bthpidgey.Click += bthpidgey_Click;
            // 
            // bthcaterpie
            // 
            bthcaterpie.ForeColor = Color.LightPink;
            bthcaterpie.Location = new Point(40, 362);
            bthcaterpie.Name = "bthcaterpie";
            bthcaterpie.Size = new Size(94, 29);
            bthcaterpie.TabIndex = 5;
            bthcaterpie.Text = "caterpie";
            bthcaterpie.UseVisualStyleBackColor = true;
            bthcaterpie.Click += bthcaterpie_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.MediumVioletRed;
            lbName.Location = new Point(479, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.ForeColor = Color.DeepPink;
            lbType.Location = new Point(479, 125);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 20);
            lbType.TabIndex = 7;
            lbType.Text = "Type";
            // 
            // lbStats
            // 
            lbStats.AutoSize = true;
            lbStats.ForeColor = Color.HotPink;
            lbStats.Location = new Point(479, 165);
            lbStats.Name = "lbStats";
            lbStats.Size = new Size(75, 20);
            lbStats.TabIndex = 8;
            lbStats.Text = "BasicStats";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pikachu;
            pictureBox1.Location = new Point(172, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbStats);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(bthAlcremie);
            Controls.Add(bthJigglypuff);
            Controls.Add(btnSwirlix);
            Controls.Add(bthHatterene);
            Controls.Add(btnEspeon);
            Controls.Add(btnPikachu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPikachu;
        private Button btnEspeon;
        private Button bthHatterene;
        private Button btnSwirlix;
        private Button bthJigglypuff;
        private Button bthAlcremie;
        private Label lbName;
        private Label lbType;
        private Label lbStats;
        private PictureBox pictureBox1;
    }
}
