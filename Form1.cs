using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDungRun.Entities;
using ProjectDungRun.Models;
using System.IO;

namespace ProjectDungRun
{
    public partial class Form1 : Form
    {

        public Image archeolsheet;
        public Image Dwarfsheet;
        public Entity player;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 94;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);
            Init();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
            player.SetAnimationConfiguration(0);
        }
        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    // player.Move(0, -2); <-- when dirx under argument player.move
                    player.dirY = -2;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.S:
                    //  player.Move(0, 2);
                    player.dirY = 2;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.A:
                    // player.Move(-2, 0);
                    player.dirX = -2;
                    player.isMoving = true;
                    player.flip = -1;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.D:
                    //player.Move(2, 0);
                    player.dirX = 2;
                    player.isMoving = true;
                    player.flip = 1;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.Space:
                    player.dirX = 0;
                    player.dirY = 0;
                    player.isMoving = false;
                    player.SetAnimationConfiguration(2);
                    break;
            }
            //player.isMoving = true;
            //player.SetAnimationConfiguration(1);
        }
        public void Init()
        {

            // MapController.Init();

            //this.Width = MapController.cellSize * MapController.mapWidth; (2) instead moved to mapcontroller class
            //this.Width = MapController.GetWidth();
            //this.Height = MapController.GetHeight();

            archeolsheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Archeol.png"));
            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, archeolsheet);
            timer1.Start();
        }
        public void Update(object sender, EventArgs e)
        {
            Invalidate();
            if (player.isMoving)
            {
                player.Move();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

          //  g.DrawImage(archeolsheet, new PointF(100, 100)); 

            // g.DrawImage(player.spriteSheet, player.posX, player.posY, new Rectangle(new Point(0, 0), new Size(player.size, player.size)),GraphicsUnit.Pixel); 

            //g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.posX, player.posY), new Size(player.size, player.size)), 20, 0, player.size,player.size, GraphicsUnit.Pixel);

            //MapController.DrawMap(g);
            player.PlayAnimation(g);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
