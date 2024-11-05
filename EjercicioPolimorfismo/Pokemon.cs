namespace EjercicioPolimorfismo
{
    class Pokemon
    {
        public virtual void Attack()
        {
            Console.WriteLine("The Pokemon uses an attack");
        }

        public virtual void Defense()
        {
            Console.WriteLine("The Pokemon defends itself");
        }
    }
}
