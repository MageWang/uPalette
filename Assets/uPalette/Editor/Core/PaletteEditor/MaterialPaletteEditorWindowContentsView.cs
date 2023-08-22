using System;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace uPalette.Editor.Core.PaletteEditor
{
    [Serializable]
    internal sealed class MaterialPaletteEditorWindowContentsView : PaletteEditorWindowContentsView<Material>
    {
        protected override PaletteEditorTreeView<Material> CreateTreeView(TreeViewState state)
        {
            return new MaterialPaletteEditorTreeView(state);
        }
    }
}
