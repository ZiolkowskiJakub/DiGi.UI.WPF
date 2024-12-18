using DiGi.UI.WPF.Core.Classes;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Modify
    {
        public static void CollapseAll(this ItemCollection itemCollection, bool inverse = false)
        {
            ExpandAll(itemCollection, !inverse);
        }
    }
}