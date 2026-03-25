/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Grabbable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.Interaction
{
    public class Grabbable : Interactable, IGrabbable
    {
        public override bool Interactive => InteractionHub.Grabbable == null && base.Interactive;

        public bool IsGrabbing { protected set; get; }
        protected const int LAYER_IGNORE_RAYCAST = 2;
        protected int layerOnHold;
        protected new Rigidbody rigidbody;
        protected bool isKinematicOnHold;
        protected Graphic graphic;
        protected bool raycastTargetOnHold;

        protected override void Awake()
        {
            base.Awake();
            rigidbody = GetComponent<Rigidbody>();
            graphic = GetComponent<Graphic>();
        }

        #region
        protected override void OnHold()
        {
            layerOnHold = gameObject.layer;
            gameObject.layer = LAYER_IGNORE_RAYCAST;
            if (rigidbody)
            {
                isKinematicOnHold = rigidbody.isKinematic;
                rigidbody.isKinematic = true;
            }
            if (graphic)
            {
                raycastTargetOnHold = graphic.raycastTarget;
                graphic.raycastTarget = false;
            }
            InteractionHub.OnGrab(this);
            IsGrabbing = true;
            base.OnHold();
        }

        protected override void OnDrag(Vector3 vector)
        {
            transform.position = vector;
            Restrain();
            base.OnDrag(vector);
        }

        protected override void OnRelease()
        {
            gameObject.layer = layerOnHold;
            if (rigidbody)
            {
                rigidbody.isKinematic = isKinematicOnHold;
            }
            if (graphic)
            {
                graphic.raycastTarget = raycastTargetOnHold;
            }
            InteractionHub.OnPlace(this);
            InteractionHub.OnGrab(null);
            IsGrabbing = false;
            base.OnRelease();
        }
        #endregion
    }
}