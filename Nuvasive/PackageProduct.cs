using System;

namespace Nuvasive
{
    public class Dimensions
    {
        public Double Length { get; set; }

        public Double Width { get; set; }

        public Double Height { get; set; }
    }

    public class PackageProducts
    {
        private Dimensions _dimensions;
        Double _length;
        Double _width;
        Double _height;
        public PackageProducts(Dimensions dimensions, Double length, Double width, Double height)
        {
            this._length = length;
            this._width = width;
            this._height = height;
            this._dimensions = dimensions;
        }

        public Dimensions AddProduct()
        {
            if (_dimensions.Length >= _length
                && _dimensions.Width >= _width
                && _dimensions.Height >= _height)
            {
                return new Dimensions()
                    {
                        Length = _dimensions.Length - _length,
                        Width = _dimensions.Width - _width,
                        Height = _dimensions.Height - _height
                    };
            }
            return _dimensions;

        }
    }
}
