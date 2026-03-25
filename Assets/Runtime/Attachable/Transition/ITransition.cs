/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ITransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public enum TransitState
    {
        Normal,
        Hover,
        Hold,
        Select
    }

    public interface ITransition : IActivatable
    {
        void Transit(TransitState state);
    }
}