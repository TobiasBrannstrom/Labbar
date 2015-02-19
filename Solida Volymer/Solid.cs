using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solida_Volymer
{
    public enum SolidType
    {
        CircularCone,
        Cylinder
    }
    public abstract class Solid
    {
        private double _height = 0;
        private double _radius = 0;

        public abstract double BaseArea
        {
            get;
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException();
                }
                _height = value;
            }
        }
        
        public double HeightSqaured
        {
            get
            {               
                return (_height * _height);              
            }
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
                
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _radius = value;
            }
        }
        public double RadiusSquared
        {
            get
            {
                return _radius * _radius;
            }
        }
        public abstract double SurfaceArea
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
       
        protected Solid(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
      
        public override string ToString()
        {
            return String.Format("Radie  (r) : \t {0:f2}\nHeight (h) : \t {1:f2}\nVolym      : \t {2:f2}\nBasarea    : \t {3:f2}\nYtarea     : \t {4:f2}",
                
                Radius,
                Height,
                Volume,
                BaseArea,
                SurfaceArea
                );                               
        }
    }
}
