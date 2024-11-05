namespace EjercicioPolimorfismo
{
    class Pokemon
    {
        public virtual void Ataque()
        {
            Console.WriteLine("El pokemon usa un ataque");
        }

        public virtual void Defensa()
        {
            Console.WriteLine("El pokemon usa una defensa");
        }
    }
}
