/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ColliderGrabber.cs
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
    public class ColliderGrabber : ColliderHoverer
    {
        public int button;
        protected Vector3 offset;
        protected bool isGrabbing;

        protected override void OnTriggerExit(Collider other)
        {
            if (!isGrabbing)
            {
                base.OnTriggerExit(other);
            }
        }

        protected virtual void Update()
        {
            if (!active || other == null)
            {
                return;
            }
            if (Input.GetMouseButtonDown(button))
            {
                isGrabbing = true;
                offset = CalOffset();
                InvokeOnHoldEvent();
            }
            else if (Input.GetMouseButtonUp(button))
            {
                isGrabbing = false;
                InvokeOnReleaseEvent();
            }
            if (isGrabbing)
            {
                InvokeOnDragEvent(Grabbing());
            }
        }

        protected Vector3 CalOffset()
        {
            return transform.position - other.transform.position;
        }

        protected virtual Vector3 Grabbing()
        {
            return other.transform.position + offset;
        }
    }
}