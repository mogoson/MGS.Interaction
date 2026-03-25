/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Activatable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Interaction
{
    public abstract class Activatable : MonoBehaviour, IActivatable
    {
        [SerializeField]
        protected bool active = true;

        public virtual bool Active
        {
            set { active = value; }
            get { return active; }
        }
    }
}