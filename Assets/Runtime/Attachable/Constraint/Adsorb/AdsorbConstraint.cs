/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AdsorbConstraint.cs
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
    public class AdsorbConstraint : Constraint
    {
        public Vector3 offset;

        protected override void OnRestrain()
        {
            if (InteractionHub.Grabbable is MonoBehaviour grabMono)
            {
                grabMono.transform.localPosition = offset;
            }
        }
    }
}