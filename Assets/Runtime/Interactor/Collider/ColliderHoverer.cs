/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ColliderHoverer.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class ColliderHoverer : Interactor
    {
        protected Collider other;

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (!active)
            {
                return;
            }
            this.other = other;
            InvokeOnEnterEvent();
        }

        protected virtual void OnTriggerExit(Collider other)
        {
            if (!active)
            {
                return;
            }
            this.other = null;
            InvokeOnExitEvent();
        }
    }
}