namespace FSM
{
    class ProcessState
    {
        public State State { get; }
        public Action Action { get; }

        public ProcessState(State state, Action? action)
        {
            State = state;
            Action = action ?? Action.None;
        }
    }
}
