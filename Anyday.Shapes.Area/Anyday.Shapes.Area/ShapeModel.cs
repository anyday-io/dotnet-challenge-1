namespace Anyday.Shapes.Area
{

    //Should we make it abstract?
    public class BaseShapes
    {
        //
    }

    public class DerivedShapeCircle : BaseShapes
    {
        public int Radius;

        public int CalculateArea(int radius)
        {
            //Calculate and return area;
            throw new NotImplementedException();
        }
    }

    public class DerivedShapeRectangle : BaseShapes
    {
        public int Width;
        public int Height;

        public int CalculateArea(int width, int height)
        {
            //Calculate and return area;
            throw new NotImplementedException();
        }
    }


}
