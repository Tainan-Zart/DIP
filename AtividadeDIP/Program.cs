namespace AtividadeDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Lamp(State.Off);
            lamp.Operate(); 
        }
    }
}
