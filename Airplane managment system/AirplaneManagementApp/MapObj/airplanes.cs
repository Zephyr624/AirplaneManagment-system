using System;
using PointLine;
using System.Drawing;
namespace Objects
{
    public abstract class Airplanes //klasa airplanes abstrakcyjna zawireajaca informacje o parametrach danego samolotu
    {
        float height, velocity;
        bool direction;
        Line Path;
        char sign;
        public float GetHeight(float height)
        {
            return height;
        }
        public float GetVelocity(float velocity)
        {
            return velocity;

        }
        public bool GetDirection(bool direction)
        {
            return direction;
        }
        public Line GetLine(Line line)
        {
            return line;
        }
        public char GetSign(char sign)
        {
            return sign;
        }
        public void SetHeight(float height)
        {
            this.height = height;
        }
        public void SetVelocity(float velocity)
        {
            this.velocity = velocity;
        }
        public void SetDirection(bool direction)
        {
            this.direction = direction;
        }
        public abstract void SetSign(char sign);
    }
    // cztery klasy dziedziczace z airplanes
    //  poszczegolne rodzaje samolotow
    class Plane : Airplanes
    {
        Image Planeimage;
        char Planesign;
        public override void SetSign(char sign)
        {
            Planesign = sign;
        } 
        /*public void Setbaloonimage ()
        {
            Planeimage==Image.FromFile();// add files for images
        }*/


    }
    class Glider : Airplanes
    {
        //Image Gliderimage;
        char Glidersign;
        public override void SetSign(char sign)
        {
            Glidersign = sign;
        }
        /*public void Setgliderimage ()
        {
            Gliderimage=Image.FromFile();// add files for images
        }*/

    }
    class Helicopter : Airplanes
    {
        //Image Helicopterimage;
        char Helicoptersign;
        public override void SetSign(char sign)
        {
            Helicoptersign = sign;
        }
       /* public void Sethelicopter()
        {
            Helicopterimage=Image.FromFile();// add files for images
        }*/

    }
    class Baloon : Airplanes
    {
        //Image Baloonimage;
        char Baloonsign;
        public override void SetSign(char sign)        
        {
            Baloonsign = sign;
        }
       /*public void Setbaloonimage ()
        {
           Baloonimage==Image.FromFile();// add files for images
        }*/

    }
}