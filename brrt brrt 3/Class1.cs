namespace brrt_brrt_3
{
        class Circle
        {
            public string color;
            public double radius;
            public const double PI = 3.14159;

        public Circle(double r)
            {
                radius = r;
            }

        public Circle ()
            {
                radius = 0.0;
            }

             public double getArea
            {
                get
                {
                    return PI * radius * radius;
                }

            }
            public double getCircumference
            {
                get
                {
                    return 2 * PI * radius;
                }

            } 
            public double Radius
            {
                get
                {
                    return radius;
                }

                set
                {
                    if (value >= 0)
                        radius = value;
                }
            }
        }
}


