using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectDungRun.Entities
{
    public class iscollide
    {
        public PointF position;
        public Size size;

        public iscollide(PointF pos, Size size)
        {
            this.position = pos;
            this.size = size;
        }
    }
}
