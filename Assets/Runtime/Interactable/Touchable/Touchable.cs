/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Touchable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public class Touchable : Interactable, ITouchable
    {
        protected override void OnHold()
        {
            InteractionHub.OnTouch(this);
            base.OnHold();
        }
    }
}