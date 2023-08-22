using UnityEditor;
using UnityEngine;
using uPalette.Runtime.Core.Synchronizer.Material;

namespace uPalette.Editor.Core.Synchronizer
{
    [CustomEditor(inspectedType: typeof(MaterialSynchronizer), editorForChildClasses: true)]
    public sealed class MaterialSynchronizerEditor : ValueSynchronizerEditor<Material>
    {
    }
}
