namespace MyclassArea
{
    public delegate string GreetAdarsh(string name);
    public delegate void AddionOperation(int num1, int num2);
    public delegate void Mathoperation(int num1, int num2);
    public delegate void Notify();
    public class Myclass
    {
        public static void Email() => Console.WriteLine("Email Sent");
        public static void Message() => Console.WriteLine("Message Sent");

        public static void Sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }


        public static void Main(string[] args)
        {

            Notify notify = new Notify(Email);
            notify();
            Notify notify1 = new Notify(Message);
            notify1();
            Mathoperation sum = new Mathoperation(Sum);
            sum(40, 50);
            Mathoperation sub = new Mathoperation(Sub);
            sub(40, 50);
            GreetAdarsh gt = new GreetAdarsh(SayHello);
            gt("Akash");
            AddionOperation ao = new AddionOperation(Add);

            ao += new AddionOperation(Sub1);
            ao(12, 56);
        }



        public static string SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }

        public static void Add(int num1, int num2) => Console.WriteLine(num1 + num2);

        public static void Sub1(int num1, int num2) => Console.WriteLine(num1 - num2);




    }
}
