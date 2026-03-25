/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ColliderToucher.cs
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
    public class ColliderToucher : ColliderHoverer
    {
        protected override void OnTriggerEnter(Collider other)
        {
            base.OnTriggerEnter(other);
            if (active)
            {
                InvokeOnHoldEvent();
            }
        }

        protected override void OnTriggerExit(Collider other)
        {
            if (active)
            {
                InvokeOnReleaseEvent();
            }
            base.OnTriggerExit(other);
        }
    }
}