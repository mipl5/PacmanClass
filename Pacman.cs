using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Pacman
    {
        //members
        private int xPlace;
        private int yPlace;
        private int lives;
        private int points;
        
        //constructors
        public Pacman(int xPlace, int yPlace)
        {
            this.xPlace = xPlace;
            this.yPlace = yPlace;
            lives = 3;
            // points is by default 0.
        }
        public Pacman() : this(0, 0) { }

        //methods

        // public
        public void MoveUp() => Move(0, 1);
        public void MoveDown() => Move(0, -1);
        public void MoveRight() => Move(1, 0);
        public void MoveLeft() => Move(-1, 0);

        public void Eat() => points++;
        public void KillSkeleton() => points += 10;
        public void Attacked() => lives--;

        //pivate
        private void Move(int dx, int dy)
        {
            if (lives > 0)
            {
                xPlace += dx;
                yPlace += dy;
            }
        }
    }
}
