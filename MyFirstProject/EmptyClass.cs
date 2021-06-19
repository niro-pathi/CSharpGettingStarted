using System;
namespace MyUtilities
{
    public class NameUtilities
    {
        static public string MyFullName(string fName, string lName)
        {
            var fullName = lName + ',' + fName;
            
            return "My Full Name is :" + fullName;
        }
    }
}
