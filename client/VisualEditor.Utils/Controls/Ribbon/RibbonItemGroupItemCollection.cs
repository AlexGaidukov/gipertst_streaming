using System.Collections.Generic;

namespace VisualEditor.Utils.Controls.Ribbon
{
    /// <summary>
    /// Represents a collection of items that is hosted by the RibbonItemGroup
    /// </summary>
    public class RibbonItemGroupItemCollection : RibbonItemCollection
    {
        private RibbonItemGroup _ownerGroup;

        /// <param name="ownerGroup">Group that this collection belongs to</param>
        internal RibbonItemGroupItemCollection(RibbonItemGroup ownerGroup)
        {
            _ownerGroup = ownerGroup;
        }
        /// <summary>
        /// Gets the group that owns this item collection
        /// </summary>
        public RibbonItemGroup OwnerGroup
        {
            get
            {
                return _ownerGroup;
            }
        }

        /// <summary>
        /// Adds the specified item to the collection
        /// </summary>
        public new void Add(RibbonItem item)
        {
            item.MaxSizeMode = RibbonElementSizeMode.Compact;
            item.SetOwnerGroup(OwnerGroup);
            base.Add(item);
        }

        /// <summary>
        /// Adds the specified range of items
        /// </summary>
        /// <param name="items">Items to add</param>
        public new void AddRange(IEnumerable<RibbonItem> items)
        {
            foreach (RibbonItem item in items)
            {
                item.MaxSizeMode = RibbonElementSizeMode.Compact;
                item.SetOwnerGroup(OwnerGroup);
            }
            base.AddRange(items);
        }

        /// <summary>
        /// Inserts the specified item at the desired index
        /// </summary>
        /// <param name="index">Desired index of the item</param>
        /// <param name="item">Item to insert</param>
        public new void Insert(int index, RibbonItem item)
        {
            item.MaxSizeMode = RibbonElementSizeMode.Compact;
            item.SetOwnerGroup(OwnerGroup);
            base.Insert(index, item);
        }
    }
}