using System;
using System.Drawing;
using System.Windows.Forms;

namespace Battleship_Fight
{
    public partial class Form1 : Form
    {
        bool TurnedD = false;



        int BulletDistance = 0;




        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (TurnedD == true)
                {
                    TurnedD = false;
                    MainShip.Image = Properties.Resources.MainSHturn;
                }
                MainShip.Location = new Point(MainShip.Location.X - 5, MainShip.Location.Y);
            }
            if (e.KeyCode == Keys.D)
            {
                if (TurnedD == false)
                {
                    TurnedD = true;
                    MainShip.Image = Properties.Resources.MainSH;
                }
                MainShip.Location = new Point(MainShip.Location.X + 5, MainShip.Location.Y);
            }
            if (e.KeyCode == Keys.F)
            {
                if (TurnedD == false)
                {
                    Bullet.Location = new Point(MainShip.Location.X-13, MainShip.Location.Y+30);
                    Bullet.Visible = true;
                    for (BulletDistance = 0; BulletDistance < 600; ++BulletDistance)
                    {
                        Bullet.Location = new Point(Bullet.Location.X - 1, Bullet.Location.Y);
                        if (Bullet.Location.X > EnemyAI.Location.X && Bullet.Location.X < EnemyAI.Location.X + 200)
                        {
                            EnemyAI.Visible = false;
                            Bullet.Visible = false;
                        }
                        if (Bullet.Location.X > EnemyAI2.Location.X && Bullet.Location.X < EnemyAI2.Location.X + 200)
                        {
                            EnemyAI2.Visible = false;
                            Bullet.Visible = false;
                        }
                    }
                }
                if (TurnedD == true)
                {
                    Bullet.Location = new Point(MainShip.Location.X+180, MainShip.Location.Y+30);
                    Bullet.Visible = true;
                    for (BulletDistance = 0; BulletDistance < 600; ++BulletDistance)
                    {
                        Bullet.Location = new Point(Bullet.Location.X + 1, Bullet.Location.Y);
                        if (Bullet.Location.X > EnemyAI.Location.X && Bullet.Location.X < EnemyAI.Location.X + 200)
                        {
                            EnemyAI.Visible = false;
                            Bullet.Visible = false;
                        }
                        if (Bullet.Location.X > EnemyAI2.Location.X && Bullet.Location.X < EnemyAI2.Location.X + 200)
                        {
                            EnemyAI2.Visible = false;
                            Bullet.Visible = false;
                        }
                    }
                }
            }

        }
        private void keyup(object sender, KeyEventArgs e)
        {

        }

        private void b1click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

    } 
}
