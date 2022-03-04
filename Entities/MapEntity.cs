using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ProjectDungRun.Controllers;

namespace ProjectDungRun.Entities
{
    public class iscollide
    {
        public PointF position;
        public Size size;
        
        public char tags;
        private Entity player;
        private Point point;
        private char v;

        public iscollide(PointF pos, Size size, Char Tags)
        {
            this.position = pos;
            this.size = size;
            this.tags = Tags;
        }

        public iscollide(Entity player, Point point, char v)
        {
            this.player = player;
            this.point = point;
            this.v = v;
        }

        public void Destroyself()
        {
            MapController.Unregistershape(this);
            
        }

    }
}
