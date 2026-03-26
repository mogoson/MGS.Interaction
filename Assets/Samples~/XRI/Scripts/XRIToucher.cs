/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  XRIToucher.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/27/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace MGS.Interaction.XRI
{
    public class XRIToucher : XRIHoverer, IXRSelectInteractable
    {
        public SelectEnterEvent firstSelectEntered => throw new System.NotImplementedException();

        public SelectExitEvent lastSelectExited => throw new System.NotImplementedException();

        public SelectEnterEvent selectEntered => throw new System.NotImplementedException();

        public SelectExitEvent selectExited => throw new System.NotImplementedException();

        public List<IXRSelectInteractor> interactorsSelecting => throw new System.NotImplementedException();

        public IXRSelectInteractor firstInteractorSelecting => throw new System.NotImplementedException();

        public bool isSelected => throw new System.NotImplementedException();

        public InteractableSelectMode selectMode => throw new System.NotImplementedException();

        public Pose GetAttachPoseOnSelect(IXRSelectInteractor interactor)
        {
            throw new System.NotImplementedException();
        }

        public Pose GetLocalAttachPoseOnSelect(IXRSelectInteractor interactor)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSelectableBy(IXRSelectInteractor interactor)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelectEntered(SelectEnterEventArgs args)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelectEntering(SelectEnterEventArgs args)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelectExited(SelectExitEventArgs args)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelectExiting(SelectExitEventArgs args)
        {
            throw new System.NotImplementedException();
        }
    }
}