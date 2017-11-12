using Cosmos.HAL;
using Sys = Cosmos.System;

namespace OSLibrary.UI
{
    public class DisplayDriver
    {
        protected VGAScreen screen;
        private int width, height;

        public DisplayDriver()
        {
            screen = new VGAScreen();
        }

        public void DrawFilledRectangle(uint x0, uint y0, int Width, int Height, int color)
        {
            for (uint i = 0; i < Width; i++)
            {
                for (uint h = 0; h < Height; h++)
                {
                    setPixel((int)(x0 + i), (int)(y0 + h), color);
                }
            }
        }

        public void DrawRectangle(uint x, uint y, int w, int h, int c)
        {
            DrawLine(x, y, w, c, true);
            DrawLine(x, y, h, c, false);
            DrawLine((uint)((int)x + (int)w), y, h, c, false);
            DrawLine(x, (uint)((int)y + h),w, c, true);
        }

        public void DrawLine(uint x, uint y, int w, int c, bool horizontal)
        {
            if (horizontal)
            {
                for (uint a = x; a < x+w; a ++)
                {
                    setPixel((int)a, (int)y, c);
                }
            } else
            {
                for (uint a = y; a < y+w; a ++)
                {
                    setPixel((int)x, (int)a, c);
                }
            }
        }

        public void DrawDiagonal(uint x, uint y, int w, int c)
        {
            for (int i = (int)x; i < x+w; i ++)
            {
                setPixel(i, (int)y+i, c);
            }
        }

        public void init()
        {
            screen.SetGraphicsMode(VGAScreen.ScreenSize.Size320x200, VGAScreen.ColorDepth.BitDepth8);
            screen.Clear(0);
            width = screen.PixelWidth;
            height = screen.PixelHeight;
        }

        public virtual void setPixel(int x, int y, int c)
        {
            if (screen.GetPixel320x200x8((uint)x, (uint)y) != (uint)c)
                setPixelRaw(x, y, c);
        }

        public virtual byte getPixel(int x, int y)
        {
            return (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
        }

        public virtual void clear()
        {
            clear(0);
        }

        public virtual void clear(int c)
        {
            screen.Clear(c);
        }

        public virtual void step() { }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public void setPixelRaw(int x, int y, int c)
        {

            screen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);

        }
    }
}
