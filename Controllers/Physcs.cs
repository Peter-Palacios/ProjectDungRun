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

        public static char IsCollide(Entity entity, Point dir)
        {
            if (entity.posX + dir.X <= 0 || entity.posX + dir.X >= MapController.cellSize * (MapController.mapWidth - 1) || entity.posY + dir.Y <= 0 || entity.posY + dir.Y >= MapController.cellSize * (MapController.mapHeight - 1))
                return 'w';

            int SizeWidth = 25;//char width
            int SizeHeight = 32;

            for (int i = 0; i < MapController.mapObjects.Count; i++)
            {
                var currObject = MapController.mapObjects[i];
                PointF delta = new PointF();

                delta.X = (entity.posX + SizeWidth / 2) - (currObject.position.X + currObject.size.Width / 2);
                delta.Y = (entity.posY + SizeHeight / 2) - (currObject.position.Y + currObject.size.Height / 2);
                if (Math.Abs(delta.X) <= SizeWidth / 2 + currObject.size.Width / 2)
                {
                    if (Math.Abs(delta.Y) <= SizeHeight / 2 + currObject.size.Height / 2)
                    {
                        if (delta.X < 0 && dir.X == 3 && entity.posY + SizeHeight / 2 > currObject.position.Y && entity.posY + SizeHeight / 2 < currObject.position.Y + currObject.size.Height) //32= entity.size
                        {
                            return currObject.tags;
                        }
                        if (delta.X > 0 && dir.X == -3 && entity.posY + SizeHeight / 2 > currObject.position.Y && entity.posY + SizeHeight / 2 < currObject.position.Y + currObject.size.Height)
                        {
                            return currObject.tags;
                        }
                        if (delta.Y < 0 && dir.Y == 3 && entity.posX + SizeWidth / 2 > currObject.position.X && entity.posX + SizeWidth / 2 < currObject.position.X + currObject.size.Width) //25-entity.size
                        {
                            return currObject.tags;
                        }
                        if (delta.Y > 0 && dir.Y == -3 && entity.posX + SizeWidth / 2 > currObject.position.X && entity.posX + SizeWidth / 2 < currObject.position.X + currObject.size.Width)
                        {
                            return currObject.tags;
                        }
                    }
                }
            }

            return 'a';//walkable
        }
     

        
    }
}
