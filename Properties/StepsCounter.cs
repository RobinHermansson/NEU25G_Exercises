
namespace Properties
{
    public class StepsCounter
    {

        private int _steps = 0;
        public int Steps
        {
            get 
            {
                return this._steps;
            }
        }

        public void IncreaseSteps() 
        {
           _steps++;
        }

        public void ResetSteps()
        {
            _steps = 0;
        }


    }
}
