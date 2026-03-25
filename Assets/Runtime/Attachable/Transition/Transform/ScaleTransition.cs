/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ScaleTransition.cs
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
    public class ScaleTransition : Transition<Transform, Vector3>
    {
        protected override void Reset()
        {
            base.Reset();
            state.normal = Vector3.one;
            state.hover = Vector3.one * 1.125f;
            state.hold = Vector3.one * 1.105f;
            state.select = Vector3.one * 1.125f;
        }

        protected override void OnTransit(Transform target, Vector3 state)
        {
            target.localScale = state;
        }
    }
}