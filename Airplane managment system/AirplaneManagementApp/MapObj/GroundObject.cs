using System;
using PointLine;
using System.Collections.Generic;
using Manage;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Objects
{
    public class GroundObject
    {
        private Point p1;
        private int type, ObjectId = 0;


        public GroundObject()
        {
            this.p1 = null;
            this.type = 0;
        }
        public GroundObject(int x, int y, int type)
        {
            this.p1 = new Point(x, y);
            this.type = type;

        }

        List<GroundObject> GrndObjectsList = new List<GroundObject>();

        public void AddGroundObj(int x, int y,int type)
        {
            if ((x < 0) || (y < 0))
                throw new NegativeValueException("Value of X and Y should be pisitive");

            GrndObjectsList.Add(new GroundObject(x, y, type));
            ObjectId++;
        }

    }
}
