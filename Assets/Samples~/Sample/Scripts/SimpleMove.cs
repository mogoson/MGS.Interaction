/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SimpleMove.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction.Sample
{
    public class SimpleMove : MonoBehaviour
    {
        public float speed = 2.5f;

        private void Update()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetKey(KeyCode.Q) ? 1.0f : (Input.GetKey(KeyCode.E) ? -1.0f : 0f);
            var z = Input.GetAxis("Vertical");
            transform.position += speed * Time.deltaTime * new Vector3(x, y, z);
        }
    }
}