/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseGrabber.cs
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
    public class MouseGrabber : Interactor
    {
        public new Camera camera;
        protected Vector3 offset;
        protected bool isGrabbing;
        protected bool isExitDuringGrab;

        protected virtual void Reset()
        {
            camera = Camera.main;
        }

        protected virtual void OnMouseEnter()
        {
            if (!active)
            {
                return;
            }

            isExitDuringGrab = false;
            if (isGrabbing)
            {
                return;
            }
            InvokeOnEnterEvent();
        }

        protected virtual void OnMouseDown()
        {
            if (!active)
            {
                return;
            }

            isGrabbing = true;
            offset = CalOffset();
            InvokeOnHoldEvent();
        }

        protected virtual void OnMouseDrag()
        {
            if (!active)
            {
                return;
            }

            InvokeOnDragEvent(Grabbing());
        }

        protected virtual void OnMouseUp()
        {
            if (!active)
            {
                return;
            }

            isGrabbing = false;
            InvokeOnReleaseEvent();
            if (isExitDuringGrab)
            {
                OnMouseExit();
            }
        }

        protected virtual void OnMouseExit()
        {
            if (!active)
            {
                return;
            }

            if (isGrabbing)
            {
                isExitDuringGrab = true;
                return;
            }
            InvokeOnExitEvent();
        }

        protected Vector3 CalOffset()
        {
            var screenPos = camera.WorldToScreenPoint(transform.position);
            return screenPos - Input.mousePosition;
        }

        protected virtual Vector3 Grabbing()
        {
            var screenPos = Input.mousePosition + offset;
            return camera.ScreenToWorldPoint(screenPos);
        }
    }
}