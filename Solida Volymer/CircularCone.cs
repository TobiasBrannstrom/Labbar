using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solida_Volymer
{
    public class CircularCone : Solid
    {
        public override double BaseArea
        {
            get
            {
                return Math.PI * RadiusSquared;
            }
        }
        public override double SurfaceArea
        {
            get
            {
                return Math.PI * Radius * (Radius + Math.Sqrt(RadiusSquared + HeightSqaured));
            }
        }
        public override double Volume
        {
            get
            {
                return (1.0 / 3.0) * Math.PI * RadiusSquared * Height;
            }
        }
        public CircularCone(double radius, double height)
            : base (radius, height)
        {
        }
    }
}
