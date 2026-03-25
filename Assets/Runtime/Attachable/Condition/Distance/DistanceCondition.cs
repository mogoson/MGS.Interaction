/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  DistanceCondition.cs
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
    public abstract class DistanceCondition : Condition
    {
        public Transform from;
        public Transform to;

        protected virtual void Reset()
        {
            from = transform;
            to = Camera.main?.transform;
        }

        protected override bool OnSatisfy()
        {
            return OnSatisfy(Vector3.Distance(from.position, to.position));
        }

        protected abstract bool OnSatisfy(float distance);
    }
}