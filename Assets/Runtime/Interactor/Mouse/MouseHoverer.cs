/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseHoverer.cs
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
    [RequireComponent(typeof(Collider))]
    public class MouseHoverer : Interactor
    {
        protected virtual void OnMouseEnter()
        {
            if (!active)
            {
                return;
            }
            InvokeOnEnterEvent();
        }

        protected virtual void OnMouseExit()
        {
            if (!active)
            {
                return;
            }
            InvokeOnExitEvent();
        }
    }
}