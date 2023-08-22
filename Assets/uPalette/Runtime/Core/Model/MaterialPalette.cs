using System;
using UnityEngine;

namespace uPalette.Runtime.Core.Model
{
    [Serializable]
    public sealed class MaterialPalette : Palette<Material>
    {
        protected override Material GetDefaultValue()
        {
            return null;
        }
    }
}
