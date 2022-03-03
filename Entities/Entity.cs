using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectDungRun.Entities
{
    public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

        public int flip;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idlFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idlFrames;
            this.attackFrames = attackFrames;
            this.runFrames = runFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;

            size = 36;

            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
            flip = 1;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }

        public void PlayAnimation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else
                currentFrame = 0;

            g.DrawImage(spriteSheet, new Rectangle(new Point(posX - flip * size / 2, posY), new Size(flip * size, size)), (25f * currentFrame), 33*currentAnimation, 25, 32, GraphicsUnit.Pixel);
           // g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), new Size(size, size)), (25f * currentFrame), (32 * currentAnimation), 25, 32, GraphicsUnit.Pixel);
            

        }

        public void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = runFrames;
                    break;
                case 2:
                    currentLimit = attackFrames;
                    break;
                case 3:
                    currentLimit = deathFrames;
                    break;
                    case 4:
                        currentLimit = deathFrames;
                        break;
                    case 5:
                       currentLimit = idleFrames;
                        break;
                    case 6:
                       currentLimit = runFrames;
                       break;
                    case 7:
                        currentLimit = deathFrames;
                        break;

            }
        }
    }
}
