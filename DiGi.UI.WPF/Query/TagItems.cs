using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts items stored in the Tag property of controls within an ItemCollection, optionally including nested collections and filtering by selection criteria.
        /// </summary>
        /// <typeparam name="TItem">The type of the item to be retrieved from the Tag property.</typeparam>
        /// <typeparam name="UControl">The specific control type to look for within the collection.</typeparam>
        /// <param name="itemCollection">The ItemCollection to process.</param>
        /// <param name="includeNested">If set to <c>true</c>, recursively processes nested ItemsControls. Defaults to <c>true</c>.</param>
        /// <param name="selected">If set to <c>true</c>, only items from controls that satisfy the <paramref name="selectedFunc"/> are included. Defaults to <c>false</c>.</param>
        /// <param name="selectedFunc">The function used to evaluate if a control is selected. This must be provided if <paramref name="selected"/> is set to <c>true</c>.</param>
        /// <returns>A list of items found in the tags, or <c>null</c> if the provided <paramref name="itemCollection"/> is null.</returns>
        public static List<TItem>? TagItems<TItem, UControl>(this ItemCollection itemCollection, bool includeNested = true, bool selected = false, Func<UControl, bool>? selectedFunc = null) where UControl : Control
        {
            if (itemCollection == null)
            {
                return null;
            }

            if (selected && selectedFunc == null)
            {
                throw new ArgumentNullException(nameof(selectedFunc));
            }

            List<TItem> result = [];
            foreach (object @object in itemCollection)
            {
                if (@object is not UControl control)
                {
                    continue;
                }

                object tag = control.Tag;
                if (tag is TItem item)
                {
                    if (!(selected && selectedFunc != null && !selectedFunc.Invoke(control)))
                    {
                        result.Add(item);
                    }
                }

                if (!includeNested)
                {
                    continue;
                }

                ItemCollection? itemCollection_Nested = (control as ItemsControl)?.Items;
                if (itemCollection_Nested == null)
                {
                    continue;
                }

                List<TItem>? tagItems = TagItems<TItem, UControl>(itemCollection_Nested, includeNested, selected, selectedFunc);
                if (tagItems == null)
                {
                    continue;
                }

                result.AddRange(tagItems);
            }

            return result;
        }
    }
}