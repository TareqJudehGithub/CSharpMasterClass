namespace FirstClass
{
    internal class Rectangle
    {
        #region Fields
        public int Width;
        public int Height;
        #endregion

        #region Constructor
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Methods
        internal int CaluclateCircumfrence()
        {
            return (Width + Height) * 2;
        }
        internal int CalculateArea()
        {
            return Width * Height;
        }
        #endregion
    }
}
