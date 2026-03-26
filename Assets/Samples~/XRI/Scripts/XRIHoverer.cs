/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  XRIHoverer.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/27/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace MGS.Interaction.XRI
{
    public class XRIHoverer : Interactor, IXRHoverInteractable
    {
        public HoverEnterEvent firstHoverEntered => throw new NotImplementedException();

        public HoverExitEvent lastHoverExited => throw new NotImplementedException();

        public HoverEnterEvent hoverEntered => throw new NotImplementedException();

        public HoverExitEvent hoverExited => throw new NotImplementedException();

        public List<IXRHoverInteractor> interactorsHovering => throw new NotImplementedException();

        public bool isHovered => throw new NotImplementedException();

        public InteractionLayerMask interactionLayers => throw new NotImplementedException();

        public List<Collider> colliders => throw new NotImplementedException();

        public event Action<InteractableRegisteredEventArgs> registered;
        public event Action<InteractableUnregisteredEventArgs> unregistered;

        public Transform GetAttachTransform(IXRInteractor interactor)
        {
            throw new NotImplementedException();
        }

        public float GetDistanceSqrToInteractor(IXRInteractor interactor)
        {
            throw new NotImplementedException();
        }

        public bool IsHoverableBy(IXRHoverInteractor interactor)
        {
            throw new NotImplementedException();
        }

        public void OnHoverEntered(HoverEnterEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnHoverEntering(HoverEnterEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnHoverExited(HoverExitEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnHoverExiting(HoverExitEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnRegistered(InteractableRegisteredEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnUnregistered(InteractableUnregisteredEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
        {
            throw new NotImplementedException();
        }
    }
}