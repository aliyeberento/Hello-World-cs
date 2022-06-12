
namespace basicInfo.Person
{
    public class personalInfo
    {
        public string firstName = "";
        public string lastName = "";
        public int age;
        public string city = "";

        public void  Introduction()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName + " and I'm " + age + " years old from " + city);
        }
    }

}
