using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ProjectDungRun.Entities;


namespace ProjectDungRun.Controllers
{

    public static class MapController
    {

        //public const int mapHeight = 20;
        //public const int mapWidth = 20;
        //public Entity player;

        public const int mapHeight = 15;
        public const int mapWidth = 15;
        public static int cellSize = 31;
        public static int[,] map = new int[mapHeight, mapWidth];
        public static Image spriteSheet;
        public static Image doors;
        public static Image collect;
        public static List<iscollide> mapObjects;

        public static bool KeyVisible=true;

        //public static List<iscollide> mapDoor;
        //public static List<iscollide> mapKey;

        public static void Unregistershape(iscollide mapobj)
        {
            mapObjects.Remove(mapobj);
        }

        public static void Init()
        {
            map = GetMap();
            spriteSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Dungeon.png"));
            doors = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\doors.png"));
            collect = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Collectables.png"));

            mapObjects = new List<iscollide>();

            //mapDoor = new List<iscollide>();
            //mapKey = new List<iscollide>();

        }
        public static int[,] GetMap()
        {

            return new int[,]{

               {1,6,6,6,6,6,6,6,6,6,6,6,6,6,2,},
               {10,0,0,0,0,0,0,0,5,0,0,0,6,6,7,},
               {10,0,5,0,0,5,0,0,5,0,5,0,5,0,7,},
               {10,0,5,0,0,5,0,0,6,6,6,0,5,15,7,},
               {10,0,6,5,0,5,0,0,0,0,0,0,5,0,7,},
               {10,0,0,6,6,5,0,0,0,5,0,0,5,0,7,},
               {10,0,6,5,0,0,0,0,0,5,0,0,5,0,7,},
               {10,0,0,5,0,6,6,6,6,6,6,0,0,0,7,},
               {10,0,0,5,0,5,0,0,0,0,0,0,0,0,7,},
               {10,6,0,5,0,5,0,6,6,5,0,0,0,6,7,},
               {10,0,0,5,0,0,0,5,0,5,0,0,0,0,7,},
               {10,0,0,5,0,6,6,6,0,5,0,0,0,0,7,},
               {10,0,0,5,0,0,0,0,0,5,0,0,0,0,7,},
               {10,0,0,5,0,0,0,0,0,6,6,0,0,0,7,},
               {3,8,8,8,8,8,8,8,8,8,8,8,14,0,4,},
                
                //{1,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,},
               //{10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5,0,7,},
               //{10,0,0,9,9,6,6,6,0,0,0,0,0,0,0,5,0,5,0,7,},
               //{10,0,0,9,9,0,0,0,0,0,0,0,0,0,0,5,0,0,0,7,},
               //{10,0,0,5,0,0,0,0,0,0,0,0,6,6,6,6,6,6,6,7,},
               //{10,0,0,5,0,0,5,0,5,0,0,0,0,0,0,5,0,0,0,7,},
               //{10,0,0,5,0,0,5,0,5,0,0,0,0,0,0,5,0,0,0,7,},
               //{10,6,6,6,0,0,5,0,5,0,0,0,0,0,0,5,0,0,0,7,},
               //{10,0,0,0,0,0,5,6,5,0,0,0,5,0,0,5,0,0,0,7,},
               //{10,0,0,6,6,6,5,0,0,0,0,0,5,0,0,5,6,6,0,7,},
               //{10,0,0,0,0,0,5,0,5,6,6,6,6,6,0,0,0,0,0,7,},
               //{10,0,0,0,0,0,5,0,5,0,0,0,0,0,0,0,0,0,0,7,},
               //{10,6,6,0,0,0,5,0,5,0,5,6,5,0,0,6,6,6,6,7,},
               //{10,0,5,0,0,0,5,0,0,0,5,0,5,0,0,0,0,0,0,7,},
               //{10,0,5,0,0,0,5,0,6,6,6,0,5,0,6,6,6,6,6,7,},
               //{10,0,0,0,0,0,5,0,0,0,0,0,5,0,0,0,0,0,0,7,},
               //{10,6,6,0,0,0,5,0,0,0,0,0,5,6,6,6,6,6,6,7,},
               //{10,0,0,0,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,7,},
               //{10,6,6,0,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,7,},
               //{3,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,0,0,8,4,},

                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                //{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},

            };
        }
        //public static void KeyMap(Graphics g)
        //{
        //    for (int i = 0; i < mapWidth; i++)
        //    {
        //        for (int j = 0; j < mapHeight; j++)
        //        {
        //            if (map[i, j] == 15)

        //            {
        //                g.DrawImage(collect, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
        //                iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize));
        //                mapKey.Add(mapEntity);
        //            }
        //        }
        //    }
        //}

        public static int keyGridX;
        public static int keyGridY;
        public static void SeedMap(Graphics g)
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {

                    if (map[i, j] == 5)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 111, 68, 20, 20, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }
                    if (map[i, j] == 7)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 8, 26, 20, 20, GraphicsUnit.Pixel);
                        //MapEntity mapEntity = new MapEntity(new Point(j * cellSize, i * cellSize), new Size(cellSize * 3, cellSize * 3)); 68, 6
                        //mapObjects.Add(mapEntity);
                    }

                    if (map[i, j] == 6)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }

                    if (map[i, j] == 8)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }
                    if (map[i, j] == 9)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 5, 429, 20, 20, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }
                    if (map[i, j] == 12)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 10, 595, 25, 29, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }
                    if (map[i, j] == 13)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 34, 595, 25, 29, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize), 'w');
                        mapObjects.Add(mapEntity);
                    }
                    if (map[i, j] == 14)
                    {
                        g.DrawImage(doors, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(65, 32)), 0, 0, 50, 29, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(65, 32), 'd');
                        mapObjects.Add(mapEntity);

                    }
                    if (map[i, j] == 15 &&KeyVisible)

                    {
                        g.DrawImage(collect, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(24, 14)), 3, 101, 10, 6, GraphicsUnit.Pixel);
                        iscollide mapEntity = new iscollide(new Point(j * cellSize, i * cellSize), new Size(24, 14), 'k');
                        mapObjects.Add(mapEntity);
                       
                       

                        // mapKey.Add(mapEntity);
                    }
                  
                    
                    //if (map[i, j] == 11) LEFT CORNER WALL
                    //{
                    //    g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 7, 75, 20, 20, GraphicsUnit.Pixel);
                    //    MapEntity mapEntity = new MapEntity(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize));
                    //    mapObjects.Add(mapEntity);
                    //}
                    //{
                    //    if (map[i, j] == 10)
                    //    {
                    //        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(15, 40)), 111, 68, 6, 20, GraphicsUnit.Pixel);
                    //        MapEntity mapEntity = new MapEntity(new Point(j * cellSize, i * cellSize), new Size(15, 40));
                    //        mapObjects.Add(mapEntity);
                    //    }
                    //    else
                    //    {
                    //        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                    //        MapEntity mapEntity = new MapEntity(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize));
                    //        mapObjects.Add(mapEntity);
                    //    }
                    //}

                }
            }
        }
        public static iscollide KeyObj;

        public static void DrawMap(Graphics g)
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {


                    if (map[i, j] == 0)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 256, 193, 20, 20, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 1)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                    } else
                    if (map[i, j] == 2)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 3)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 4)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 320, 84, 20, 20, GraphicsUnit.Pixel);
                    }
                    //if (map[i, j] == 7)
                    //{
                    //    g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 8, 26, 20, 20, GraphicsUnit.Pixel);
                    //}
                    if (map[i, j] == 10)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 68, 27, 20, 20, GraphicsUnit.Pixel);
                    }

                    else
                    {
                        ClearKey(g, i, j);
                    }

                }
                MapController.SeedMap(g);
                //if (Physcs.IsCollideKey(entity, new Point(Entity.dirX, Entity.dirY)))
                //{

                //}
            }
        }

        public static void ClearKey(Graphics g, int i, int j)
        {
            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 256, 193, 20, 20, GraphicsUnit.Pixel);
        }

        public static int GetWidth()
        {
            return cellSize * (mapWidth) + 15; //both were adjusted for proper map size
        }
        public static int GetHeight()
        {
            return cellSize * (mapHeight + 1) + 10;
        }
    }
}
