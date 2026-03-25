/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AnimationTransition.cs
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
    public class AnimationTransition : Transition<Animation, AnimationClip>
    {
        protected override void OnTransit(Animation target, AnimationClip state)
        {
            target.clip = state;
            target.Play();
        }
    }
}