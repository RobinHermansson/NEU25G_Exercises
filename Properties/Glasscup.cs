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
            if (IsFull && !IsBroken)
            {
                Console.WriteLine("The glas is already full.");
            }
            else if (IsBroken)
            {
                Console.WriteLine("The glass is broken, can't fill it!");
            }
            else
            {
                Console.WriteLine("Filling the glas");
                IsFull = true;
            }
        }

        public void EmptyGlass()
        {
            if (IsFull && !IsBroken)
            {
                Console.WriteLine("Emptying the glass!");
                IsFull = false;
            }
            else if (IsBroken) {
                Console.WriteLine("The glass is broken and can not empty it any further");
            }
            else
            {
                Console.WriteLine("The glass is already empty.");
            }
        }

        public void BreakTheGlass() 
        {

            if (IsFull && !IsBroken)
            {
                Console.WriteLine("The glass broke and the water is spilling out!");
                IsBroken = true;
            }
            else if (IsBroken) 
            {
                Console.WriteLine("The glass is already broken.");
            }
            else if (!IsBroken && !IsFull) 
            {
                Console.WriteLine("The glass broke.");
                IsBroken = true;
            }

        }
    }
}
