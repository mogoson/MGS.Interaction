/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ImageTransition.cs
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
    public class ImageTransition : Transition<Image, Sprite>
    {
        protected override void OnTransit(Image target, Sprite state)
        {
            target.sprite = state;
        }
    }
}