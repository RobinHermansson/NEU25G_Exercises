namespace Properties
{
    public class Person
    {
        private string _firstName;

        public string FirstName 
        {
            get 
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
    }
}
