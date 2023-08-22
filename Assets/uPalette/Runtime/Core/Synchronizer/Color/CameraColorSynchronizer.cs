using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uPalette.Runtime.Core.Synchronizer.Color
{
    [RequireComponent(typeof(Camera))]
    [ColorSynchronizer(typeof(Camera), "Color")]
    public sealed class CameraColorSynchronizer : ColorSynchronizer<Camera>
    {
        protected override internal UnityEngine.Color GetValue()
        {
            return Component.backgroundColor;
        }

        protected override internal void SetValue(UnityEngine.Color value)
        {
            Component.backgroundColor = value;
        }

        protected override bool EqualsToCurrentValue(UnityEngine.Color value)
        {
            return Component.backgroundColor == value;
        }
    }
}
