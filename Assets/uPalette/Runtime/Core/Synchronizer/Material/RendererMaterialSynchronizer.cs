using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uPalette.Runtime.Core.Synchronizer.Material
{
    [RequireComponent(typeof(Renderer))]
    [MaterialSynchronizer(typeof(Renderer), "Material")]
    public sealed class RendererMaterialSynchronizer : MaterialSynchronizer<Renderer>
    {
        protected override internal UnityEngine.Material GetValue()
        {
            return Component.sharedMaterial;
        }

        protected override internal void SetValue(UnityEngine.Material value)
        {
            Component.sharedMaterial = value;
        }

        protected override bool EqualsToCurrentValue(UnityEngine.Material value)
        {
            return Component.sharedMaterial == value;
        }
    }
}
