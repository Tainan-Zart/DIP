namespace AtividadeDIP
{
    public class Switch : ISwitch
    {
        private readonly IOperate _operate;

        public Switch(IOperate operate)
        {
            _operate = operate;
        }

        public void Press()
        {
            _operate.Operate();
        }
    }
}
