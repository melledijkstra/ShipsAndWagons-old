using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Carri_e_Navi_wpf.Shapes
{
    public class Hexagon : Shape
    {

        private int _x;
        private int _y;
        private int _size;

        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(double), typeof(Hexagon), new PropertyMetadata(20));
        public static readonly DependencyProperty XProperty = DependencyProperty.Register("X", typeof(int), typeof(Hexagon));
        public static readonly DependencyProperty YProperty = DependencyProperty.Register("Y", typeof(int), typeof(Hexagon));

        protected override Geometry DefiningGeometry
        {
            get
            {
                Point p1 = new Point(_x, _y);
                //Point p2 = new Point(_size / 2);
                // TODO: You left off here!! Find out how to generate grid map with shipes and shit (good luck ;p)

                List<PathSegment> segments = new List<PathSegment>(7);

                List<PathFigure> figures = new List<PathFigure>(1);
                PathFigure pf = new PathFigure(p1, segments, true);
                figures.Add(pf);

                Geometry g = new PathGeometry(figures, FillRule.EvenOdd, null);
                return g;
            }
        }

        public Hexagon()
        {

        }
    }
}