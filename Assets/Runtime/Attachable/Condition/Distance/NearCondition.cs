/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  NearCondition.cs
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
    public class NearCondition : DistanceCondition
    {
        public float near = 1.0f;

        protected override bool OnSatisfy(float distance)
        {
            return distance <= near;
        }

        protected virtual void OnDrawGizmosSelected()
        {
            if (from == null || to == null) { return; }

            var vector = to.position - from.position;
            var dir = vector.normalized;

            var center = from.position + vector * 0.5f;
            var forward = center + dir * near * 0.5f;
            Gizmos.DrawLine(forward, to.position);

            var back = center - dir * near * 0.5f;
            Gizmos.DrawLine(back, from.position);

            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(forward, back);
        }
    }
}