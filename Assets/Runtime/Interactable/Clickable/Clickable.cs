/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Clickable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public class Clickable : Interactable, IClickable
    {
        protected override void OnRelease()
        {
            InteractionHub.OnClick(this);
            base.OnRelease();
        }
    }
}