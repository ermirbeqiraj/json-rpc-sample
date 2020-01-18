using EdjCase.JsonRpc.Client;
using EdjCase.JsonRpc.Core;
using System;

namespace JsonRpcConsole
{
    public class Item
    {
        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; private set; }
        public int Id { get; private set; }
    }

    class Program
    {
        //https://github.com/edjCase/JsonRpc

        static void Main(string[] args)
        {
            var url = "http://localhost:59385/Items/";
            IRpcTransportClient transportClient = new HttpRpcTransportClient();
            RpcClient client = new RpcClient(new Uri(url), transportClient: transportClient);
            RpcRequest request = RpcRequest.WithParameterList("Get", null, "Id1");
            RpcResponse<Item> response = client.SendRequestAsync<Item>(request).GetAwaiter().GetResult();

            Console.WriteLine($"response.Result.Id: {response.Result.Id} | response.Result.Name: {response.Result.Name}");
        }
    }
}
