using UnityEditor;
using UnityEngine;
using uPalette.Runtime.Core.Synchronizer.Material;

namespace uPalette.Editor.Core.Synchronizer
{
    [CustomEditor(inspectedType: typeof(MaterialSynchronizeEvent), editorForChildClasses: true)]
    public sealed class MaterialSynchronizeEventEditor : ValueSynchronizeEventEditor<Material>
    {
    }
}
