/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerHoverer.cs
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
    public class PointerHoverer : Interactor, IPointerEnterHandler, IPointerExitHandler
    {
        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }
            InvokeOnEnterEvent();
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }
            InvokeOnExitEvent();
        }
    }
}