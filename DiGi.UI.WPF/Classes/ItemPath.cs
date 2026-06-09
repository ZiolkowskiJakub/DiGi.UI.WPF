using System.Text.Json.Nodes;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Represents a hierarchical path to an item.
    /// </summary>
    public class ItemPath : DiGi.Core.Classes.ObjectPath<ItemPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPath"/> class using the specified name.
        /// </summary>
        /// <param name="name">The name of the item path segment.</param>
        public ItemPath(string? name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPath"/> class using a collection of names.
        /// </summary>
        /// <param name="names">An enumerable collection of names that define the hierarchical path segments.</param>
        public ItemPath(IEnumerable<string>? names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the path data.</param>
        public ItemPath(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPath"/> class by appending a name to an existing path.
        /// </summary>
        /// <param name="name">The name of the item path segment to append.</param>
        /// <param name="path">The base hierarchical path.</param>
        public ItemPath(string? name, ItemPath? path)
            : base(name, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPath"/> class by copying an existing path.
        /// </summary>
        /// <param name="path">The hierarchical path to copy.</param>
        public ItemPath(ItemPath? path)
            : base(path)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ItemPath"/> class.
        /// </summary>
        /// <param name="name">The name of the item path segment.</param>
        /// <returns>A new <see cref="ItemPath"/> instance.</returns>
        protected override ItemPath Create(string? name)
        {
            return new ItemPath(name);
        }
    }
}