namespace Properties
{
    public class Glasscup
    {
        private bool _isFull = false;
        private bool _isBroken = false;

        public bool IsFull
        {
            get
            {
                return this._isFull;
            }
            set 
            {
                this._isFull = value;
            }
        }

        public bool IsBroken
        {
            get
            {
                return _isBroken;
            }
            set
            {
                this._isBroken = value;
            }

        }

        public void FillGlass()
        {
            if (_isFull)
            {
               Console.WriteLine("The glas is already full.");
            }
            else
            {
                Console.WriteLine("Filling the glas");
                IsFull = true;
            }
        }

        public void EmptyGlass()
        {
            if (_isFull)
            {
               Console.WriteLine("Emptying the glass!");
                IsFull = false;
            }
            else
            {
                Console.WriteLine("The glass is already empty.");
            }
        }

        public void BreakTheGlass() 
        {

            if (_isFull && !IsBroken)
            {
                Console.WriteLine("The glass broke and the water is splling out!");
                IsBroken = true;
            }
            else if (IsBroken) 
            {
                Console.WriteLine("The glass is already broken.");
            }

        }
    }
}
