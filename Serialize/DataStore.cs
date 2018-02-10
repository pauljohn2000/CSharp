using System;
using System.Generic;
using Newtonsoft.json;

Store s =  new Store
{
    Transaction = "Sell";
    Amount = "3.00";
    Balance =  "150.00";
}

List<Store> store =  new List<Store>();
store.Add(s);
store.Add(s);

string json = JsonConvert.SerializeObject(store, Formatting.indented);
int i =0;