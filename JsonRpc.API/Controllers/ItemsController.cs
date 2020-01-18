using EdjCase.JsonRpc.Router;

namespace JsonRpc.API.Controllers
{
    public class ItemsController : RpcController
    {
        public Item Get()
        {
            var item = new Item(3, "Ermir");
            return item;
        }

        public void Add(Item item)
        {
            //Adds item
        }
    }

    public class Item {
        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; private set; }
        public int Id { get; private set; }
    }
}