namespace EjercicioPolimorfismo
{
    class Pikachu : Pokemon
    {
        public override void Attack()
        {
            Console.WriteLine("Pikachu uses Thunder");
        }

        public override void Defense()
        {
            Console.WriteLine("Pikachu uses Protect to defend itself");
        }

    }
}
