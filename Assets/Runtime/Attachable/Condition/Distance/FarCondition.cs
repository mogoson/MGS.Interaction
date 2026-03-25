/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  FarCondition.cs
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
    public class FarCondition : DistanceCondition
    {
        public float far = 1.0f;

        protected override bool OnSatisfy(float distance)
        {
            return distance >= far;
        }

        protected virtual void OnDrawGizmosSelected()
        {
            if (from == null || to == null) { return; }

            var vector = to.position - from.position;
            var dir = vector.normalized;

            var center = from.position + vector * 0.5f;
            var forward = center + dir * far * 0.5f;
            var back = center - dir * far * 0.5f;
            Gizmos.DrawLine(forward, back);

            var forwardEx = forward + dir * far;
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(forward, forwardEx);

            var backEx = back - dir * far;
            Gizmos.DrawLine(back, backEx);
        }
    }
}