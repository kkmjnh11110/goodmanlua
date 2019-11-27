/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/08/07 00:47:11
** desc:  状态机状态转换基类;
*********************************************************************************/

namespace Framework
{
    public enum StateMachineTransitionState
    {
        Ready = 0,
        Transing = 1,
        Finish = 2
    }

    public abstract class AbsTransition
    {
        public string Name { get; private set; }
        public AbsState FromState { get; private set; }
        public AbsState ToState { get; private set; }
        public AbsEntity Entity { get; private set; }
        public StateMachine Machine { get; private set; }
        public StateMachineTransitionState TransState { get; set; } = StateMachineTransitionState.Ready;

        public AbsTransition(StateMachine machine, string name, AbsState formState, AbsState toState)
        {
            Name = name;
            Entity = machine.Entity;
            Machine = machine;
            TransState = StateMachineTransitionState.Ready;
            FromState = formState;
            ToState = toState;
        }

        public virtual bool IsCanTrans() { return true; }

        public StateMachineTransitionState ExcuteTrans(AbsState formState, AbsState toState)
        {
            FromState = formState;
            ToState = toState;
            TransState = ExcuteTransEx();
            return TransState;
        }

        public virtual StateMachineTransitionState ExcuteTransEx() { return StateMachineTransitionState.Finish; }
    }
}