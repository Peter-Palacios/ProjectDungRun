using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ProjectDungRun.Entities;

namespace ProjectDungRun.Controllers
{
   public static class Physcs
    {
        
        public static bool IsCollide(Entity entity, Point dir)
        {
            if (entity.posX + dir.X <= 0 || entity.posX + dir.X >= MapController.cellSize * (MapController.mapWidth - 1) || entity.posY + dir.Y <= 0 || entity.posY + dir.Y >= MapController.cellSize * (MapController.mapHeight - 1))
                return true;

                for (int i = 0; i < MapController.mapObjects.Count; i++)
                {
                    var currObject = MapController.mapObjects[i];
                    PointF delta = new PointF();

                    delta.X = (entity.posX + 25 / 2) - (currObject.position.X + currObject.size.Width / 2);//delta.X = (entity.posX + entity.size / 2) - (currObject.position.X + currObject.size.Width / 2);
                    delta.Y = (entity.posY + 32 / 2) - (currObject.position.Y + currObject.size.Height / 2);//delta.Y = (entity.posY + entity.size / 2) - (currObject.position.Y + currObject.size.Height / 2);
                    if (Math.Abs(delta.X) <= 25 / 2 + currObject.size.Width / 2)
                    {
                        if (Math.Abs(delta.Y) <= 32 / 2 + currObject.size.Height / 2)
                        {
                            if (delta.X < 0 && dir.X == 3 && entity.posY + 32 / 2 > currObject.position.Y && entity.posY + 32 / 2 < currObject.position.Y + currObject.size.Height) //32= entity.size
                            {
                                return true;
                            }
                            if (delta.X > 0 && dir.X == -3 && entity.posY + 32 / 2 > currObject.position.Y && entity.posY + 32 / 2 < currObject.position.Y + currObject.size.Height)
                            {
                                return true;
                            }
                            if (delta.Y < 0 && dir.Y == 3 && entity.posX + 25 / 2 > currObject.position.X && entity.posX + 25 / 2 < currObject.position.X + currObject.size.Width) //25-entity.size
                            {
                                return true;
                            }
                            if (delta.Y > 0 && dir.Y == -3 && entity.posX + 25 / 2 > currObject.position.X && entity.posX + 25 / 2 < currObject.position.X + currObject.size.Width)
                            {
                                return true;
                            }
                        }
                    }
                }
            
            return false;
        }
        public static bool IsCollideNoob(Entity entity, Point dir)
        {
            if (entity.posX + dir.X <= 0 || entity.posX + dir.X >= MapController.cellSize * (MapController.mapWidth - 1) || entity.posY + dir.Y <= 0 || entity.posY + dir.Y >= MapController.cellSize * (MapController.mapHeight - 1))
            {

                for (int i = 0; i < MapController.mapDoor.Count; i++)
                {
                    var currObject = MapController.mapDoor[i];
                    PointF delta = new PointF();

                    delta.X = (entity.posX + 25 / 2) - (currObject.position.X + currObject.size.Width / 2);//delta.X = (entity.posX + entity.size / 2) - (currObject.position.X + currObject.size.Width / 2);
                    delta.Y = (entity.posY + 32 / 2) - (currObject.position.Y + currObject.size.Height / 2);//delta.Y = (entity.posY + entity.size / 2) - (currObject.position.Y + currObject.size.Height / 2);
                    if (Math.Abs(delta.X) <= 25 / 2 + currObject.size.Width / 2)
                    {
                        if (Math.Abs(delta.Y) <= 32 / 2 + currObject.size.Height / 2)
                        {
                            if (delta.X < 0 && dir.X == 3 && entity.posY + 32 / 2 > currObject.position.Y && entity.posY + 32 / 2 < currObject.position.Y + currObject.size.Height) //32= entity.size
                            {
                                return true;
                            }
                            if (delta.X > 0 && dir.X == -3 && entity.posY + 32 / 2 > currObject.position.Y && entity.posY + 32 / 2 < currObject.position.Y + currObject.size.Height)
                            {
                                return true;
                            }
                            if (delta.Y < 0 && dir.Y == 3 && entity.posX + 25 / 2 > currObject.position.X && entity.posX + 25 / 2 < currObject.position.X + currObject.size.Width) //25-entity.size
                            {
                                return true;
                            }
                            if (delta.Y > 0 && dir.Y == -3 && entity.posX + 25 / 2 > currObject.position.X && entity.posX + 25 / 2 < currObject.position.X + currObject.size.Width)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
}
