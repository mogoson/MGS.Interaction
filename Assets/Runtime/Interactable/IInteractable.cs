/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IInteractable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/22/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Interaction
{
    public interface IInteractable : IInteract
    {
        bool Interactive { get; }

        void Register(IInteractor interactor);

        void Unregister(IInteractor interactor);

        void Register(ICondition condition);

        void Unregister(ICondition condition);

        void Register(IConstraint constraint);

        void Unregister(IConstraint constraint);

        void Register(ITransition transition);

        void Unregister(ITransition transition);
    }
}