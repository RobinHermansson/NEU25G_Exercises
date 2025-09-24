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

        public string LastName { get; set; }  // Exercise 2; adding a public autoproperty
    }
}
