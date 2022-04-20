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
using ProjectDungRun.Controllers;


namespace ProjectDungRun
{
    public partial class Form1 : Form
    {

        public Image archeolsheet;
        public Image Dwarfsheet;
        public Entity player;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);
            Init();
        }
        private void RestartGame()
        {
            ProjectDungRun.MenuStart newWindow = new ProjectDungRun.MenuStart();
            newWindow.Show();
            this.Hide();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = 0;
                    break;
                case Keys.S:
                    player.dirY = 0;
                    break;
                case Keys.A:
                    player.dirX = 0;
                    break;
                case Keys.D:
                    player.dirX = 0;
                    break;
            }

            if (player.dirX == 0 && player.dirY == 0)
            {
                player.isMoving = false;
                //if (player.flip == 1)
                    player.SetAnimationConfiguration(0);
                //else player.SetAnimationConfiguration(5);
            }

            //player.dirX = 0;
            //player.dirY = 0;
            //player.isMoving = false;
            //player.SetAnimationConfiguration(0);

        }
        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -3;
                    player.isMoving = true;
                    //if (player.flip == 1)
                        player.SetAnimationConfiguration(1);
                    //else player.SetAnimationConfiguration(6);
                    break;
                case Keys.S:
                    player.dirY = 3;
                    player.isMoving = true;
                    //if (player.flip == 1)
                        player.SetAnimationConfiguration(1);
                    //else player.SetAnimationConfiguration(6);
                    break;
                case Keys.A:
                    player.dirX = -3;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(1);
                    //player.SetAnimationConfiguration(6);
                    player.flip = -1;
                    break;
                case Keys.D:
                    player.dirX = 3;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(1);
                    player.flip = 1;
                    break;
                case Keys.Space:
                    player.dirX = 0;
                    player.dirY = 0;
                    player.isMoving = false;
                    //if (player.flip == 1)
                    //    player.SetAnimationConfiguration(2);
                    //else player.SetAnimationConfiguration(7);
                    break;
            }
           
        }
        public void Init()
        {
            

             MapController.Init();

            //this.Width = MapController.cellSize * MapController.mapWidth; (2) instead moved to mapcontroller class
            this.Width = MapController.GetWidth();
            this.Height = MapController.GetHeight();

            archeolsheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Archeol.png"));
            player = new Entity(40, 40, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, archeolsheet);
            timer1.Start();
        }
       
        public bool KeyTaken = false;
        public bool DoorMsg = false;
        
        
        public void Update(object sender, EventArgs e)
        {
            // Entities.iscollide key iscollide;


            if (Physcs.IsCollide(player, new Point(player.dirX, player.dirY)) == 'k' && !KeyTaken)
            {
                MapController.KeyVisible = false;
                KeyTaken = true;
                MessageBox.Show("You hear a door nearby unlock");
                //MapController.mapObjects.Remove(MapController.KeyObj);

            }



            if (Physcs.IsCollide(player, new Point(player.dirX, player.dirY)) == 'd') //&& !KeyTaken)
                
            {
                if (KeyTaken == true)
                {
                    KeyTaken = false;
                    DoorMsg = true;
                    timer1.Stop();
                    MessageBox.Show("Great job...");
                   
                    RestartGame();

                }
                if (DoorMsg == false)
                {
                    DoorMsg = true;
                    MessageBox.Show("Door is locked. You hear a rumbling beyond the door");
                    MessageBox.Show("You realize the rumbling was your stomache...it's been a long day");

                }



                

            }

           

            if (Physcs.IsCollide(player, new Point(player.dirX, player.dirY))=='a')
            {

                if (player.isMoving) 
                {
                    player.Move();
                    
                }
               
            }
            Invalidate();

           

            


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
             g = e.Graphics;

        

            MapController.DrawMap(g);
            
            player.PlayAnimation(g);
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
