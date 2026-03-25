/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  CustomCondition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction.Sample
{
    public class CustomCondition : Condition
    {
        protected override bool OnSatisfy()
        {
            if (InteractionHub.Grabbable is MonoBehaviour grabMono)
            {
                var grabInfo = grabMono.GetComponent<CustomInfo>();
                var placeInfo = GetComponent<CustomInfo>();
                return grabInfo.type == placeInfo.type;
            }
            return false;
        }
    }
}