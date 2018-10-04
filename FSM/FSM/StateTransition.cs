namespace FSM
{
    class StateTransition
    {
        public State CurrentState { get; }
        public Transition Transition { get; }

        public StateTransition(State currentState, Transition transition)
        {
            CurrentState = currentState;
            Transition = transition;
        }

        public override int GetHashCode()
        {
            return  CurrentState.GetHashCode() +  Transition.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is StateTransition other && 
                   CurrentState == other.CurrentState && 
                   Transition == other.Transition;
        }
    }
}
