/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MaterialTransition.cs
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
    public class MaterialTransition : Transition<Renderer, Material>
    {
        protected override void OnTransit(Renderer target, Material state)
        {
            target.material = state;
        }
    }
}