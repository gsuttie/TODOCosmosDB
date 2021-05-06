﻿namespace TODOCosmosDB.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TODOCosmosDB.Models;

    public interface ICosmosDbService
    {
        Task<IEnumerable<Item>> GetItemsAsync(string query);
        Task<Item> GetItemAsync(string id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(string id, Item item);
        Task DeleteItemAsync(string id);
    }
}