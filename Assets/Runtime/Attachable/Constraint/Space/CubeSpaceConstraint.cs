/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  CubeSpaceConstraint.cs
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
    public class CubeSpaceConstraint : Constraint
    {
        public Transform center;
        public Vector3 size = Vector3.one * 3.0f;

        protected override void OnRestrain()
        {
            var half = size * 0.5f;
            var min = center.position - half;
            var max = center.position + half;

            var position = transform.position;
            position = Vector3.Max(position, min);
            position = Vector3.Min(position, max);
            transform.position = position;
        }

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(center.position, size);
        }
    }
}