/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Placeable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/22/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction
{
    public class Placeable : Interactable, IPlaceable
    {
        public override bool Interactive => InteractionHub.Grabbable != null && base.Interactive;

        public IGrabbable Grabbable { protected set; get; }
        protected const int LAYER_IGNORE_RAYCAST = 2;
        protected int layerOnPlace;
        protected Transform grabParentOrigin;

        #region
        protected override void OnEnter()
        {
            InteractionHub.Placeable = this;
            base.OnEnter();
        }

        protected override void OnExit()
        {
            InteractionHub.Placeable = null;
            base.OnExit();
        }
        #endregion

        #region
        public virtual bool Place(IGrabbable grabbable)
        {
            if (!Interactive)
            {
                return false;
            }

            if (Grabbable != null)
            {
                return false;
            }

            layerOnPlace = gameObject.layer;
            gameObject.layer = LAYER_IGNORE_RAYCAST;
            grabbable.OnHoldEvent += Clear;
            Grabbable = grabbable;
            if (grabbable is MonoBehaviour grabMono)
            {
                grabParentOrigin = grabMono.transform.parent;
                grabMono.transform.SetParent(transform);
            }
            Restrain();
            Transit(TransitState.Normal);
            return true;
        }

        public virtual void Clear()
        {
            gameObject.layer = layerOnPlace;
            if (Grabbable != null)
            {
                Grabbable.OnHoldEvent -= Clear;
                if (Grabbable is MonoBehaviour grabMono)
                {
                    grabMono.transform.SetParent(grabParentOrigin);
                }
                Grabbable = null;
            }
        }
        #endregion
    }
}