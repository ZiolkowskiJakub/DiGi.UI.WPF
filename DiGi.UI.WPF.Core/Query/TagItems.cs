using System.Windows.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static List<TItem>? TagItems<TItem, UControl>(this ItemCollection itemCollection, bool includeNested = true, bool selected = false, Func<UControl, bool>? selectedFunc = null) where UControl : Control
        {
            if(itemCollection == null)
            {
                return null;
            }

            if (selected && selectedFunc == null)
            {
                throw new ArgumentNullException(nameof(selectedFunc));
            }

            List<TItem> result = new List<TItem>();
            foreach(object @object in itemCollection)
            {
                UControl? control = @object as UControl;
                if (control == null)
                {
                    continue;
                }

                object tag = control.Tag;
                if (tag is TItem)
                {
                    if (!(selected && selectedFunc != null && !selectedFunc.Invoke(control)))
                    {
                        result.Add((TItem)tag);
                    }
                }

                if(!includeNested)
                {
                    continue;
                }

                ItemCollection? itemCollection_Nested = (control as ItemsControl)?.Items;
                if (itemCollection_Nested == null)
                {
                    continue;
                }

                List<TItem>? tagItems = TagItems<TItem, UControl>(itemCollection_Nested, includeNested, selected, selectedFunc); 
                if(tagItems == null)
                {
                    continue;
                }

                result.AddRange(tagItems);
            }

            return result;
        }
    }
}