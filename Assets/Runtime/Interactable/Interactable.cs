/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Interactable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/22/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections.Generic;
using UnityEngine;

namespace MGS.Interaction
{
    public class Interactable : Interact, IInteractable
    {
        public virtual bool Interactive => active && Satisfy();
        protected bool interactiveOnEnter;
        protected bool interactiveOnHold;

        protected List<ICondition> conditions = new();
        protected List<IConstraint> constraints = new();
        protected List<ITransition> transitions = new();

        protected virtual void Awake()
        {
            Register(GetComponents<IInteractor>());
            Register(GetComponents<ICondition>());
            Register(GetComponents<IConstraint>());
            Register(GetComponents<ITransition>());
        }

        #region
        protected bool Satisfy()
        {
            foreach (var condition in conditions)
            {
                if (!condition.Satisfy())
                {
                    return false;
                }
            }
            return true;
        }

        protected void Restrain()
        {
            foreach (var constraint in constraints)
            {
                constraint.Restrain();
            }
        }

        protected void Transit(TransitState state)
        {
            foreach (var transition in transitions)
            {
                transition.Transit(state);
            }
        }
        #endregion

        #region
        public void Register(IEnumerable<ICondition> conditions)
        {
            foreach (var condition in conditions)
            {
                Register(condition);
            }
        }

        public void Register(ICondition condition)
        {
            conditions.Add(condition);
        }

        public void Unregister(ICondition condition)
        {
            conditions.Remove(condition);
        }

        public void Register(IEnumerable<IConstraint> constraints)
        {
            foreach (var constraint in constraints)
            {
                Register(constraint);
            }
        }

        public void Register(IConstraint constraint)
        {
            constraints.Add(constraint);
        }

        public void Unregister(IConstraint constraint)
        {
            constraints.Remove(constraint);
        }

        public void Register(IEnumerable<ITransition> transitions)
        {
            foreach (var transition in transitions)
            {
                Register(transition);
            }
        }

        public void Register(ITransition transition)
        {
            transitions.Add(transition);
        }

        public void Unregister(ITransition transition)
        {
            transitions.Remove(transition);
        }
        #endregion

        #region
        public void Register(IEnumerable<IInteractor> interactors)
        {
            foreach (IInteractor interactor in interactors)
            {
                Register(interactor);
            }
        }

        public void Register(IInteractor interactor)
        {
            interactor.OnEnterEvent += Interactor_OnEnterEvent;
            interactor.OnHoldEvent += Interactor_OnHoldEvent;
            interactor.OnDragEvent += Interactor_OnDragEvent;
            interactor.OnReleaseEvent += Interactor_OnReleaseEvent;
            interactor.OnExitEvent += Interactor_OnExitEvent;
        }

        public void Unregister(IInteractor interactor)
        {
            interactor.OnEnterEvent -= Interactor_OnEnterEvent;
            interactor.OnHoldEvent -= Interactor_OnHoldEvent;
            interactor.OnDragEvent -= Interactor_OnDragEvent;
            interactor.OnReleaseEvent -= Interactor_OnReleaseEvent;
            interactor.OnExitEvent -= Interactor_OnExitEvent;
        }

        private void Interactor_OnEnterEvent()
        {
            interactiveOnEnter = Interactive;
            if (!interactiveOnEnter)
            {
                return;
            }
            OnEnter();
            InvokeOnEnterEvent();
        }

        private void Interactor_OnHoldEvent()
        {
            interactiveOnHold = Interactive;
            if (!interactiveOnHold)
            {
                return;
            }
            OnHold();
            InvokeOnHoldEvent();
        }

        private void Interactor_OnDragEvent(Vector3 vector)
        {
            if (!interactiveOnHold)
            {
                return;
            }
            OnDrag(vector);
            InvokeOnDragEvent(vector);
        }

        private void Interactor_OnReleaseEvent()
        {
            if (!interactiveOnHold)
            {
                return;
            }
            OnRelease();
            InvokeOnReleaseEvent();
        }

        private void Interactor_OnExitEvent()
        {
            if (!interactiveOnEnter)
            {
                return;
            }
            OnExit();
            InvokeOnExitEvent();
        }
        #endregion

        #region
        protected virtual void OnEnter()
        {
            Transit(TransitState.Hover);
        }

        protected virtual void OnHold()
        {
            Transit(TransitState.Hold);
        }

        protected virtual void OnDrag(Vector3 vector) { }

        protected virtual void OnRelease()
        {
            Transit(TransitState.Select);
        }

        protected virtual void OnExit()
        {
            Transit(TransitState.Normal);
        }
        #endregion
    }
}