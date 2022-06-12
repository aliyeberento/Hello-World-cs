namespace basicInfo.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            personalInfo personalInfo = new personalInfo();
            personalInfo.firstName = "Aliye";
            personalInfo.lastName = "Berento";
            personalInfo.age = 21;
            personalInfo.city = "Minneapolis";

            personalInfo.Introduction();
        }
    }
}  