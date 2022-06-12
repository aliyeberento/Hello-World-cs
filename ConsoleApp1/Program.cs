//

namespace helloWorld
{

   public class personalInfo
    {
        public string firstName = "";
        public string lastName = "";
        public int age ;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            personalInfo personalInfo = new personalInfo();
            personalInfo.firstName = "Aliye";
            personalInfo.lastName = "Berento";
            personalInfo.age = 21;
            Console.WriteLine("My name is " + personalInfo.firstName +" " + personalInfo.lastName + " and I'm " + personalInfo.age);
        }
    }
}  