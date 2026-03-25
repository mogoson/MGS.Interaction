/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  GraphicTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.Interaction
{
    public class GraphicTransition : Transition<Graphic, Color>
    {
        protected override void Reset()
        {
            base.Reset();
            state.normal = Color.white;
            state.hover = Color.yellow;
            state.hold = new Color(0.8f, 0.8f, 0.016f);
            state.select = Color.yellow;
        }

        protected override void OnTransit(Graphic target, Color state)
        {
            target.color = state;
        }
    }
}