namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon myPikachu = new Pikachu();
            Pokemon myBlazekin = new Blazekin();
            
            Console.WriteLine("Pikachu's turn:");
            myPikachu.Attack();
            myPikachu.Defense();

            Console.WriteLine();

            Console.WriteLine("Blazekin's turn:");
            myBlazekin.Attack();
            myBlazekin.Defense();

            Console.ReadLine();
        }
    }
}
