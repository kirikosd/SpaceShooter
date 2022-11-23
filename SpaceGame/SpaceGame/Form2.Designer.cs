namespace SpaceGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playerAmmo_timer = new System.Windows.Forms.Timer(this.components);
            this.enemyMove_timer = new System.Windows.Forms.Timer(this.components);
            this.enemyAmmo_timer = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.countdown_label = new System.Windows.Forms.Label();
            this.countdown_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(428, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // playerAmmo_timer
            // 
            this.playerAmmo_timer.Enabled = true;
            this.playerAmmo_timer.Interval = 20;
            this.playerAmmo_timer.Tick += new System.EventHandler(this.playerAmmo_timer_Tick);
            // 
            // enemyMove_timer
            // 
            this.enemyMove_timer.Enabled = true;
            this.enemyMove_timer.Interval = 3000;
            this.enemyMove_timer.Tick += new System.EventHandler(this.enemyMove_timer_Tick);
            // 
            // enemyAmmo_timer
            // 
            this.enemyAmmo_timer.Enabled = true;
            this.enemyAmmo_timer.Interval = 20;
            this.enemyAmmo_timer.Tick += new System.EventHandler(this.enemyAmmo_timer_Tick);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.MidnightBlue;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.Silver;
            this.score_label.Location = new System.Drawing.Point(0, -2);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(30, 32);
            this.score_label.TabIndex = 3;
            this.score_label.Text = "0";
            // 
            // countdown_label
            // 
            this.countdown_label.AutoSize = true;
            this.countdown_label.BackColor = System.Drawing.Color.MidnightBlue;
            this.countdown_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown_label.ForeColor = System.Drawing.Color.Silver;
            this.countdown_label.Location = new System.Drawing.Point(484, -2);
            this.countdown_label.Name = "countdown_label";
            this.countdown_label.Size = new System.Drawing.Size(62, 32);
            this.countdown_label.TabIndex = 4;
            this.countdown_label.Text = "100";
            // 
            // countdown_timer
            // 
            this.countdown_timer.Enabled = true;
            this.countdown_timer.Interval = 1000;
            this.countdown_timer.Tick += new System.EventHandler(this.countdown_timer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.countdown_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer playerAmmo_timer;
        private System.Windows.Forms.Timer enemyMove_timer;
        private System.Windows.Forms.Timer enemyAmmo_timer;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label countdown_label;
        private System.Windows.Forms.Timer countdown_timer;
    }
}