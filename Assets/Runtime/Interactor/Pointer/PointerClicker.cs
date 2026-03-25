/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerClicker.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine.EventSystems;

namespace MGS.Interaction
{
    public class PointerClicker : PointerHoverer, IPointerDownHandler, IPointerUpHandler
    {
        public virtual void OnPointerDown(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }
            InvokeOnHoldEvent();
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }
            InvokeOnReleaseEvent();
        }
    }
}