using System.Text.Json.Nodes;

namespace DiGi.UI.WPF.Core.Classes
{
    public class ItemPath : DiGi.Core.Classes.ObjectPath<ItemPath>
    {
        public ItemPath(string name)
            :base(name)
        {

        }

        public ItemPath(IEnumerable<string> names)
            :base(names)
        {

        }

        public ItemPath(JsonObject jsonObject)
            :base(jsonObject)
        {

        }


        public ItemPath(string name, ItemPath? path)
            : base(name, path)
        {

        }

        protected override ItemPath Create(string name)
        {
            return new ItemPath(name);
        }
    }
}
