namespace Lab3
{
    public class Triangle : Shape
    {
        private int base_t = 0;
        private int height = 0;

        public Triangle(int base_t, int height, string color) : base(color)
        {
            this.base_t = base_t;
            this.height = height;
        }
        public override double Getarea()
        {
            double getarea = 0.5 * base_t * height;
            return getarea;
            
        }

        public override string ToString()
        {
            return "Triangle with base " + base_t + " and height " + height;
        }
    }
}