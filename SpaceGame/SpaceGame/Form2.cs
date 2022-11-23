using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceGame
{
    public partial class Form2 : Form
    {
        List<PictureBox> playerAmmo = new List<PictureBox>();
        List<PictureBox> enemyAmmo = new List<PictureBox>();
        List<PictureBox> enemy_hits = new List<PictureBox>();
        List<PictureBox> player_hits = new List<PictureBox>();
        int[] highScores = new int[10];
        Random r;
        SoundPlayer s1,s2;
        int z;
        int score = 0;
        int t = 100;
        bool b1,b2;
        public Form2()
        {
            InitializeComponent();
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.SetChildIndex(pictureBox1, 2);
            Controls.SetChildIndex(pictureBox2, 1);
            Controls.SetChildIndex(pictureBox3, 1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox1.Location = new Point(0, 0);
            pictureBox3.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;


            score_label.Text = score.ToString();
            r = new Random();
            s1 = new SoundPlayer("./sounds/laser_sound.wav" );
            s2 = new SoundPlayer("./sounds/enemy_laser_sound.wav");
            try
            {
                using (StreamReader sr = new StreamReader("highScores.txt"))
                {
                    z = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        highScores[z] = int.Parse(line);
                        z++;
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("The file could not be read:");
                Console.WriteLine(s.Message);
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Left"))
            {
                if (pictureBox2.Location.X > 0)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
                }
            }
            else if (e.KeyCode.ToString().Equals("Right"))
            {
                if (pictureBox2.Location.X < 900)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
                }
            }
            else if (e.KeyCode.ToString().Equals("Up"))
            {
                if (pictureBox2.Location.Y > 280)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
                }
            }
            else if (e.KeyCode.ToString().Equals("Down"))
            {
                if (pictureBox2.Location.Y < 560)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
                }
            }
            else if (e.KeyCode.ToString().Equals("Space"))
            {
                playerAmmo_fire(pictureBox2.Location.X);
            }
        }
        private void playerAmmo_fire(int startX)
        {
            s1.Play();
            PictureBox p1 = new PictureBox();
            p1.ImageLocation = "./icons/player_ammo.gif";
            p1.Location = new Point(startX + 15, pictureBox2.Location.Y + 30);
            p1.Size = new Size(20, 20);
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.BackColor = Color.Transparent;
            playerAmmo.Add(p1);

            pictureBox1.Controls.Add(p1);

            PictureBox p2 = new PictureBox();
            p2.ImageLocation = "./icons/player_ammo.gif";
            p2.Location = new Point(startX + 100, pictureBox2.Location.Y + 30);
            p2.Size = new Size(20, 20);
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.BackColor = Color.Transparent;
            playerAmmo.Add(p2);

            pictureBox1.Controls.Add(p2);
        }

        private void enemyAmmo_fire(int startX)
        {
            s2.Play();
            PictureBox p3 = new PictureBox();
            p3.ImageLocation = "./icons/enemy_ammo.gif";
            p3.Location = new Point(startX + 53, pictureBox3.Location.Y + 155);
            p3.Size = new Size(30, 100);
            p3.SizeMode = PictureBoxSizeMode.StretchImage;
            p3.BackColor = Color.Transparent;
            enemyAmmo.Add(p3);

            pictureBox1.Controls.Add(p3);
        }
        private void enemyMove_timer_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(r.Next(0,720),r.Next(0,170));
            enemyAmmo_fire(pictureBox3.Location.X);
        }

        private void enemyAmmo_timer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox p in enemyAmmo)
            {
                p.Location = new Point(p.Location.X, p.Location.Y + 10);
                b2 = p.Bounds.IntersectsWith(pictureBox2.Bounds);
                if (b2)
                {
                    score -= 10;
                    score_label.Text = score.ToString();
                    enemy_hits.Add(p);
                    p.Visible = false; p.Invalidate();
                }
            }
            foreach (PictureBox i in enemy_hits)
            {
                enemyAmmo.Remove(i);
            }
        }

        private void countdown_timer_Tick(object sender, EventArgs e)
        {
            countdown_label.Text = t.ToString();
            t -= 1;
            if (t == -1) 
            {
                for(int i = 0; i <=9 ; i++)
                {
                    if (score >= highScores[i]) 
                    {
                        for (int k = 9; k > i  ; k--)
                        {
                            highScores[k] = highScores[k-1];
                        }
                        highScores[i] = score;
                        break;
                    }
                }
                countdown_timer.Stop();
                using (StreamWriter sw = new StreamWriter("highScores.txt"))
                {
                    foreach (int i in highScores)
                    {
                        sw.WriteLine(i.ToString());
                    }
                }
                MessageBox.Show("Congrats!You scored: " + score.ToString());
                this.Close();

            }
        }

        private void playerAmmo_timer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox p in playerAmmo)
            {
                p.Location = new Point(p.Location.X, p.Location.Y - 10);
                b1 = p.Bounds.IntersectsWith(pictureBox3.Bounds);
                if(b1)
                {
                    score += 1;
                    score_label.Text = score.ToString();
                    player_hits.Add(p);
                    p.Visible = false; p.Invalidate();
                }
            }
            foreach (PictureBox i in player_hits)
            {
                playerAmmo.Remove(i);
            }
            if (playerAmmo.Count == 40)
            {
                playerAmmo.RemoveRange(0,20);
            }
        }
    }
}