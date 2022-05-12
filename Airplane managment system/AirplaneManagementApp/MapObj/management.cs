using System;
using Objects;
using PointLine;
using System.Collections.Generic;

namespace Manage
{
    class Management
    {
        float height, velocity;
        bool direction;
        Line Path;
        char sign;//zmiana
        public Management()
        {
            this.height = 0;
            this.velocity = 0;
            this.direction = false;
            this.Path = null;
        }
        public Management(float height, float velocity, bool direction, Line Path, char sign) //defining object 
        {
            this.height = height;
            this.velocity = velocity;
            this.direction = direction;
            this.Path = Path;
            this.sign = sign;
        }
        List<Management> Airplane = new List<Management>(); //list of planes
        public void AddAirplane(float height, float velocity, bool direction, float StartingX,float StartingY, float DestinationX, float DestinationY, char sign) //adding a new object to list
        {

            if ((height <= 0) || (velocity <= 0))
                throw new TooLowValueException("Value of height and velocity should be higher than 0");
            if ((StartingX < 0) || (StartingY < 0) || (DestinationX < 0) || (DestinationY < 0))
                throw new NegativeValueException("Value of X and Y should be pisitive");
            
            

            Point point1=new Point(StartingX,StartingY);
            Point point2=new Point(DestinationX,DestinationY);
            Line Path=new Line(point1,point2);
            Airplane.Add(new Management(height, velocity, direction, Path, sign));
        }
        public void ModifyAirplane(float height, float velocity, bool direction, float StartingX,float StartingY, float DestinationX, float DestinationY, int index)//modyfiy object at index
        {
            if ((height <= 0) || (velocity <= 0))
                throw new TooLowValueException("Value of height and velocity should be higher than 0");
            if ((StartingX < 0) || (StartingY < 0) || (DestinationX < 0) || (DestinationY < 0))
                throw new NegativeValueException("Value of X and Y should be pisitive");
         

            Point point1=new Point(StartingX,StartingY);
            Point point2=new Point(DestinationX,DestinationY);
            Line Path=new Line(point1,point2);
            Airplane[index].height=height;
            Airplane[index].velocity=velocity;
            Airplane[index].direction=direction;
            Airplane[index].Path=Path;
        }
        public void RemoveAirplane(int index) 
        {
                    Airplane.RemoveAt(index);//removes at index
        }
    }
}
