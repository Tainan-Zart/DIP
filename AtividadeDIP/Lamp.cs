namespace AtividadeDIP
{
    public class Lamp(State State)
    {
        public void Operate()
        {
            State = State == State.Off ? State.Off : State.On;
            Console.WriteLine($"Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}
