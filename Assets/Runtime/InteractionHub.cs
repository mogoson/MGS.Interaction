/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  InteractionHub.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.Interaction
{
    public sealed class InteractionHub
    {
        #region Click
        public static IClickable Clickable { private set; get; }
        public static event Action<IClickable> OnClickEvent;

        public static void OnClick(IClickable clickable)
        {
            if (Clickable == clickable)
            {
                return;
            }
            Clickable = clickable;
            OnClickEvent?.Invoke(clickable);
        }
        #endregion

        #region Touch
        public static ITouchable Touchable { private set; get; }
        public static event Action<ITouchable> OnTouchEvent;

        public static void OnTouch(ITouchable touchable)
        {
            if (Touchable == touchable)
            {
                return;
            }
            Touchable = touchable;
            OnTouchEvent?.Invoke(touchable);
        }
        #endregion

        #region Grab
        public static IGrabbable Grabbable { private set; get; }
        public static event Action<IGrabbable> OnGrabEvent;

        public static void OnGrab(IGrabbable grabbable)
        {
            if (Grabbable == grabbable)
            {
                return;
            }
            Grabbable = grabbable;
            OnGrabEvent?.Invoke(grabbable);
        }
        #endregion

        #region Place
        public static IPlaceable Placeable { set; get; }
        public static event Action<IPlaceable, bool> OnPlaceEvent;

        public static bool OnPlace(IGrabbable grabbable)
        {
            if (Placeable == null)
            {
                return false;
            }
            var isPlaced = Placeable.Place(grabbable);
            OnPlaceEvent?.Invoke(Placeable, isPlaced);
            return isPlaced;
        }
        #endregion
    }
}