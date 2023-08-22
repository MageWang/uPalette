using UnityEngine;
using uPalette.Runtime.Core.Model;

namespace uPalette.Runtime.Core.Synchronizer.Material
{
    public abstract class MaterialSynchronizer : ValueSynchronizer<UnityEngine.Material>
    {
        [SerializeField] private MaterialEntryId _entryId = new MaterialEntryId();

        public override EntryId EntryId => _entryId;

        internal override Palette<UnityEngine.Material> GetPalette(PaletteStore store)
        {
            return store.MaterialPalette;
        }
    }
    
    public abstract class MaterialSynchronizer<T> : MaterialSynchronizer where T : Component
    {
        [SerializeField] [HideInInspector] private T _component;

        protected T Component
        {
            get
            {
                if (_component == null)
                {
                    _component = GetComponent<T>();
                }

                return _component;
            }
        }
    }
}
