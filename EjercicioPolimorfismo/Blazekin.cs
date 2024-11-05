namespace EjercicioPolimorfismo
{
    internal class Blazekin : Pokemon
    {
        public override void Attack()
        {
            Console.WriteLine("Blazekin uses Flare Blitz");
        }

        public override void Defense()
        {
            Console.WriteLine("Blazekin uses Endure");
        }
    }
}
