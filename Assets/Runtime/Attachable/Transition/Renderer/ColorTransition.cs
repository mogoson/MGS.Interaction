/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ColorTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction
{
    public class ColorTransition : Transition<Renderer, Color>
    {
        protected override void Reset()
        {
            base.Reset();
            state.normal = Color.white;
            state.hover = Color.yellow;
            state.hold = new Color(0.8f, 0.8f, 0.016f);
            state.select = Color.yellow;
        }

        protected override void OnTransit(Renderer target, Color state)
        {
            target.material.color = state;
        }
    }
}