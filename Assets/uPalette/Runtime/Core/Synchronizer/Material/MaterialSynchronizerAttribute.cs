using System;

namespace uPalette.Runtime.Core.Synchronizer.Material
{
    public sealed class MaterialSynchronizerAttribute : ValueSynchronizerAttribute
    {
        public MaterialSynchronizerAttribute(Type attachTargetType, string targetPropertyDisplayName)
            : base(typeof(UnityEngine.Material), attachTargetType, targetPropertyDisplayName)
        {
        }
    }
}
