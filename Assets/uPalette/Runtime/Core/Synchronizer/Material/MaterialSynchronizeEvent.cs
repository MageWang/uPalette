using UnityEngine;
using uPalette.Runtime.Core.Model;

namespace uPalette.Runtime.Core.Synchronizer.Material
{
    public sealed class MaterialSynchronizeEvent : ValueSynchronizeEvent<UnityEngine.Material>
    {
        [SerializeField] private MaterialEntryId _entryId = new MaterialEntryId();

        public override EntryId EntryId => _entryId;

        internal override Palette<UnityEngine.Material> GetPalette(PaletteStore store)
        {
            return store.MaterialPalette;
        }
    }
}
