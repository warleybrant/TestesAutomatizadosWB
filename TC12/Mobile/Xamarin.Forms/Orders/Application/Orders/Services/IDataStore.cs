using System;
using System.Collections.Generic;

namespace OrdersSample.Services
{
    public interface IDataStore<T>
    {
        void AddItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
        T GetItem(int id);
        IEnumerable<T> GetItems(bool forceRefresh = false);
        void RefreshItems(bool worksWithBugs);
    }
}
