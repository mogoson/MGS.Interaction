/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Condition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public abstract class Condition : Activatable, ICondition
    {
        public bool Satisfy()
        {
            if (!active)
            {
                return true;
            }
            return OnSatisfy();
        }

        protected abstract bool OnSatisfy();
    }
}