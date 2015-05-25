using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Barycentre
    {
        static public Point DoBarycentre(IList<Point> l)
        {
            Point centroid = new Point(0, 0);
            int n = l.Count();
            int tmpX = 0;
            int tmpY = 0;

            foreach (Point value in l)
            {
                tmpX += value.X;
                tmpY += value.Y;
            }

            centroid.X = tmpX / n;
            centroid.Y = tmpY / n;

            return centroid;
        }
    }
}
