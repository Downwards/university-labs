using System.Collections.Generic;

namespace FSM
{
    class Process
    {
        private Dictionary<StateTransition, ProcessState> Transitions { get; }
        private ProcessState CurrentState { get; set; }

        public Process()
        {
            CurrentState = new ProcessState(State.S0, null);
            Transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(State.S0, Transition.Bad), new ProcessState(State.S1, Action.Y2) },
                { new StateTransition(State.S0, Transition.Good), new ProcessState(State.S3, Action.Y4) },
                { new StateTransition(State.S1, Transition.Bad), new ProcessState(State.S2, Action.Y1) },
                { new StateTransition(State.S1, Transition.Good), new ProcessState(State.S0, Action.Y3) },
                { new StateTransition(State.S2, Transition.Bad), new ProcessState(State.S2, Action.Y0) },
                { new StateTransition(State.S2, Transition.Good), new ProcessState(State.S0, Action.Y3) },
                { new StateTransition(State.S3, Transition.Bad), new ProcessState(State.S1, Action.Y2) },
                { new StateTransition(State.S3, Transition.Good), new ProcessState(State.S3, Action.Y5) }
                };
        }

        private ProcessState GetNext(Transition transition)
        {
            var stateTransition = new StateTransition(CurrentState.State, transition);
            Transitions.TryGetValue(stateTransition, out var nextState);
            return nextState;
        }

        public Action MoveNext(Transition command)
        {
            CurrentState = GetNext(command);
            return CurrentState.Action;
        }
    }
}
