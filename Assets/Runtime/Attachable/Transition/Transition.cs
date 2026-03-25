/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Transition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.Interaction
{
    public abstract class Transition : Activatable, ITransition
    {
        public void Transit(TransitState state)
        {
            if (!active)
            {
                return;
            }
            OnTransit(state);
        }

        protected abstract void OnTransit(TransitState state);
    }

    [Serializable]
    public struct TransitionState<T>
    {
        public T normal;
        public T hover;
        public T hold;
        public T select;
    }

    public abstract class Transition<T, S> : Transition
    {
        public T target;
        public TransitionState<S> state;

        protected virtual void Reset()
        {
            target = GetComponent<T>();
        }

        protected override void OnTransit(TransitState state)
        {
            var tState = ResolveState(state);
            OnTransit(target, tState);
        }

        protected virtual S ResolveState(TransitState state)
        {
            return state switch
            {
                TransitState.Hover => this.state.hover,
                TransitState.Hold => this.state.hold,
                TransitState.Select => this.state.select,
                _ => this.state.normal,
            };
        }

        protected abstract void OnTransit(T target, S state);
    }
}