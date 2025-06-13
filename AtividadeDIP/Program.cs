namespace AtividadeDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOperate lamp = new Lamp();
            ISwitch sw = new Switch(lamp);

            sw.Press();
            sw.Press(); 
        }
    }
}
