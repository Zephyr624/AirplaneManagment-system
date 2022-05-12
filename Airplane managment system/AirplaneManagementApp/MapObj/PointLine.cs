using System;

/// <summary>
// Class containing two points and a class to create line out of them
/// </summary>

namespace PointLine 
{

    public class Point
    {
        private float x, y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(float x, float y) //Method used to change coordinates of the point
        {
            this.x += x;
            this.y += y;
        }

        public Tuple<float, float> Get(float getx, float gety) //Method for getting the x and y values.
        {
            getx = x;
            gety = y;
            return new Tuple<float, float>(getx, gety);
        }

        public void Set(float x, float y) // Method for setting new x and y values for existing points.
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Line : Point
    {
        private Point first, second;

        public Line()
        {
            this.first = new Point();
            this.second = new Point();
        }

        public Line(Point x, Point y)
        {
            this.first = x;
            this.second = y;
        }

        public Line(Line line) //Copying constructor
        {
            this.first = line.first;
            this.second = line.second;
        }

        public void Move(int x, int y) //Method used to change coordinates of the line
        {
            this.first.Move(x, y);
            this.second.Move(x, y);
        }

        public Tuple<Point, Point> Get(Point getp1, Point getp2) //Method for getting the x and y values.
        {
            getp1 = first;
            getp2 = second;
            return new Tuple<Point, Point>(getp1, getp2);
        }

        public void Set(Point p1, Point p2)
        {
            this.first = p1;
            this.second = p2;
        }
    }

}