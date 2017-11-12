using Cosmos.HAL;

namespace OSLibrary.UI
{
    public class MouseDriver
    {
        public static Mouse m = new Mouse();
        public static DisplayDriver dd;
        public void initialize()
        {
            dd.setPixel(m.X, m.Y, 40);
            dd.setPixel(m.X + 1, m.Y, 40);
            dd.setPixel(m.X + 2, m.Y, 40);
            dd.setPixel(m.X, m.Y + 1, 40);
            dd.setPixel(m.X, m.Y + 2, 40);
            dd.setPixel(m.X + 1, m.Y + 1, 40);
            dd.setPixel(m.X + 2, m.Y + 2, 40);
            dd.setPixel(m.X + 3, m.Y + 3, 40);
        }
    }
}
