using UnityEditor;
using UnityEngine;
using uPalette.Runtime.Core;

namespace uPalette.Editor.Core.Shared
{
    [CustomEditor(typeof(PaletteStore))]
    public class PaletteStoreEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.LabelField("Except Materials don't modify other attributes here.");
            EditorGUILayout.LabelField("Modify attributes in palette editor windows.");
        }
    }
}
