/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IInteract.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.Interaction
{
    public interface IInteract : IActivatable
    {
        event Action OnEnterEvent;
        event Action OnHoldEvent;
        event Action<Vector3> OnDragEvent;
        event Action OnReleaseEvent;
        event Action OnExitEvent;
    }
}