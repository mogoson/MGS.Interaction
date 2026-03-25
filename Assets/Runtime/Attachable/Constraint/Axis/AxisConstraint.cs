/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AxisConstraint.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.Interaction
{
    [Serializable]
    public struct AxisSettings
    {
        public bool restrain;
        public RangeFloat range;
    }

    public class AxisConstraint : Constraint
    {
        public Transform axis;
        public AxisSettings x;
        public AxisSettings y;
        public AxisSettings z;

        protected override void OnRestrain()
        {
            var localPos = axis.InverseTransformPoint(transform.position);
            if (x.restrain)
            {
                localPos.x = Mathf.Clamp(localPos.x, x.range.start, x.range.end);
            }

            if (y.restrain)
            {
                localPos.y = Mathf.Clamp(localPos.y, y.range.start, y.range.end);
            }

            if (z.restrain)
            {
                localPos.z = Mathf.Clamp(localPos.z, z.range.start, z.range.end);
            }

            transform.position = axis.TransformPoint(localPos);
        }

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            DrawAxisGizmos(x, Vector3.right);
            DrawAxisGizmos(y, Vector3.up);
            DrawAxisGizmos(z, Vector3.forward);
        }

        protected void DrawAxisGizmos(AxisSettings settings, Vector3 positive)
        {
            var start = settings.restrain ? settings.range.start : -100;
            var end = settings.restrain ? settings.range.end : 100;
            var negativePos = axis.position + positive * start;
            var positivePos = axis.position + positive * end;
            Gizmos.DrawLine(negativePos, positivePos);
        }
    }
}