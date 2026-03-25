/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseFollower.cs
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
    public class MouseFollower : MonoBehaviour
    {
        public new Camera camera;
        public Vector3 offset = Vector3.forward;

        protected virtual void Reset()
        {
            camera = Camera.main;
        }

        protected virtual void Update()
        {
            transform.position = Following();
        }

        protected virtual Vector3 Following()
        {
            var screenPos = Input.mousePosition + offset;
            return camera.ScreenToWorldPoint(screenPos);
        }
    }
}