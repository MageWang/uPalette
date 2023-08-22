using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace uPalette.Editor.Core.PaletteEditor
{
    internal sealed class MaterialPaletteEditorTreeView : PaletteEditorTreeView<Material>
    {
        public MaterialPaletteEditorTreeView(TreeViewState state) : base(state)
        {
        }

        protected override Material DrawValueField(Rect rect, Material value)
        {
            var m = EditorGUI.ObjectField(rect, "Material", value, typeof(Material), false);
            return (Material)m;
        }
    }
}
