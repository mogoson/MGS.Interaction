/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SphereSpaceConstraint.cs
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
    public class SphereSpaceConstraint : Constraint
    {
        public Transform center;
        public float radius = 3.0f;

        protected override void OnRestrain()
        {
            var position = transform.position;
            var dis = Vector3.Distance(center.position, position);
            if (dis <= radius)
            {
                return;
            }

            var dir = (position - center.position).normalized;
            transform.position = center.position + dir * radius;
        }

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(center.position, radius);
        }
    }
}