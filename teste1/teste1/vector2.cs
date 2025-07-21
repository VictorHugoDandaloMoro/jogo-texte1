using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class vector2
    {
        public int x;
        public int y;

        public vector2(int x, int y)
        {



            this.x = x;
            this.y = y;
        }


        public int up => this.y -= 1;
        public int down => this.y += 1;
        public int left => this.x -= 1;
        public int right => this.x += 1;

        public static int Distance(vector2 a, vector2 b)
        {
            if (a == null) return -1;
            if (b == null) return -1;

            return (
                (int)Math.Sqrt(
                    (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y)
                     )
                );
        }
    }
    
}
