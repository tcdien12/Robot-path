using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_TEST
{
    public class Robot
    {
        private int up;
        private int bottom;
        private int left;
        private int right;
        private int score;
        private int step;
        private static Robot instant;

        public static Robot Instant
        {
            get { if (instant == null) instant = new Robot(); return Robot.instant; }
            private set { Robot.instant = value; }
        }
        public int Up 
        { 
            get => up; set => up = value; 
        }
        public int Bottom 
        { 
            get => bottom; set => bottom = value; 
        }
        public int Left 
        { 
            get => left; set => left = value; 
        }
        public int Right 
        { 
            get => right; 
            set => right = value; 
        }
        public int Score
        {
            get => score; 
            set => score = value;
        }
        public int Step 
        { 
            get => step; 
            set => step = value;
        }
       
        public Robot(int up = 0, int bottom = 0, int left = 0, int right = 0, int score = 0)
        {
            this.up = up;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
            this.score = score;
        }
       
    }
}
