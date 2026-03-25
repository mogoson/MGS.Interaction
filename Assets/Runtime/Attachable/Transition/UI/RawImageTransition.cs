/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  RawImageTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.Interaction
{
    public class RawImageTransition : Transition<RawImage, Texture>
    {
        protected override void OnTransit(RawImage target, Texture state)
        {
            target.texture = state;
        }
    }
}