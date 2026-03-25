/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerGrabber.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.EventSystems;

namespace MGS.Interaction
{
    public class PointerGrabber : Interactor,
        IPointerEnterHandler, IPointerExitHandler,
        IPointerDownHandler, IPointerUpHandler,
        IDragHandler
    {
        protected new Camera camera;
        protected Vector2 offset;
        protected bool isGrabbing;
        protected bool isExitDuringGrab;

        protected virtual void Awake()
        {
            camera = GetComponentInParent<Canvas>()?.worldCamera;
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }

            isExitDuringGrab = false;
            if (isGrabbing)
            {
                return;
            }
            InvokeOnEnterEvent();
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }

            isGrabbing = true;
            offset = CalOffset();
            InvokeOnHoldEvent();
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }

            InvokeOnDragEvent(Grabbing());
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }

            isGrabbing = false;
            InvokeOnReleaseEvent();
            if (isExitDuringGrab)
            {
                OnPointerExit(eventData);
            }
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            if (!active)
            {
                return;
            }

            if (isGrabbing)
            {
                isExitDuringGrab = true;
                return;
            }
            InvokeOnExitEvent();
        }

        protected Vector2 CalOffset()
        {
            var screenPos = RectTransformUtility.WorldToScreenPoint(camera, transform.position);
            return screenPos - (Vector2)Input.mousePosition;
        }

        protected virtual Vector3 Grabbing()
        {
            var screenPos = (Vector2)Input.mousePosition + offset;
            var rect = transform as RectTransform;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPos, camera, out Vector3 worldPoint);
            return worldPoint;
        }
    }
}