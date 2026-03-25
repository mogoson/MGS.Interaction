/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseClicker.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public class MouseClicker : MouseHoverer
    {
        protected virtual void OnMouseDown()
        {
            if (!active)
            {
                return;
            }
            InvokeOnHoldEvent();
        }

        protected virtual void OnMouseUp()
        {
            if (!active)
            {
                return;
            }
            InvokeOnReleaseEvent();
        }
    }
}