namespace AtividadeDIP
{
    public class Switch
    {
        private Lamp lamp;

        public Switch(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void Press ()
        {
            lamp.Operate();
        }
    }
}
