/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Interact.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.Interaction
{
    public abstract class Interact : Activatable, IInteract
    {
        public event Action OnEnterEvent;
        public event Action OnHoldEvent;
        public event Action<Vector3> OnDragEvent;
        public event Action OnReleaseEvent;
        public event Action OnExitEvent;

        protected void InvokeOnEnterEvent()
        {
            OnEnterEvent?.Invoke();
        }

        protected void InvokeOnHoldEvent()
        {
            OnHoldEvent?.Invoke();
        }

        protected void InvokeOnDragEvent(Vector3 vector)
        {
            OnDragEvent?.Invoke(vector);
        }

        protected void InvokeOnReleaseEvent()
        {
            OnReleaseEvent?.Invoke();
        }

        protected void InvokeOnExitEvent()
        {
            OnExitEvent?.Invoke();
        }
    }
}