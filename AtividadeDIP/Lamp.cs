namespace AtividadeDIP
{
    public class Lamp : IOperate
    {
        public State State { get; set; } = State.Off;

        public void Operate()
        {
            State = State == State.Off ? State.On : State.Off;
            Console.WriteLine($"Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}
