namespace Task3
{
    public class Program
    {
        /*
        Write a class that will contain a field available only within this class. 
        Also, write a method available to everyone that will allow you to get the value from the field. 
        The field must be initialized in the constructor.
         */

        private string _someField;

        public Program(string someField)
        {
            _someField = someField; //this._someField = someField;
        }

        public string GetValue()
        {
            return _someField;
        }
        
    }
}