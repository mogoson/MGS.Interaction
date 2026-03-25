/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  RangeCondition.cs
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
    public class RangeCondition : DistanceCondition
    {
        public float min = 1.0f;
        public float max = 3.0f;

        protected override bool OnSatisfy(float distance)
        {
            return distance >= min && distance <= max;
        }

        protected virtual void OnDrawGizmosSelected()
        {
            if (from == null || to == null) { return; }

            var vector = to.position - from.position;
            var dir = vector.normalized;

            var center = from.position + vector * 0.5f;
            var forward = center + dir * min * 0.5f;
            var back = center - dir * min * 0.5f;
            Gizmos.DrawLine(forward, back);

            var forwardEx = center + dir * max * 0.5f;
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(forward, forwardEx);

            var backEx = center - dir * max * 0.5f;
            Gizmos.DrawLine(back, backEx);
        }
    }
}