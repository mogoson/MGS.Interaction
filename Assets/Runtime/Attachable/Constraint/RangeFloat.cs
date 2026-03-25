/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  RangeFloat.cs
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
    [Serializable]
    public struct RangeFloat
    {
        public float start;
        public float end;

        public float Length => end - start;
    }
}