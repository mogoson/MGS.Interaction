/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Constraint.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public abstract class Constraint : Activatable, IConstraint
    {
        public void Restrain()
        {
            if (!active)
            {
                return;
            }
            OnRestrain();
        }

        protected abstract void OnRestrain();
    }
}