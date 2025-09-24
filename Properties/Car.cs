
namespace Properties
{
    public class Car
    {

        private int _price;
        private string _model;
        private string _color;
        public int Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }

        public string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }

        }

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        public Car()
        {

        }

        public Car(string color, string model, int price)
        {
            Color = color;
            Model = model;
            Price = price;
        }

        public void HalfPrice()
        {
            Price = Price / 2;
        }
    }
}
