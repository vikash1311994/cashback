using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Crawler
{
    public interface IProvider
    {
        void Execute();
    }

    public abstract class Provider : IProvider
    {
        protected readonly ICatalogRepository Repository;
        protected ProgramEnum Program { get; set; }

        public Provider(ICatalogRepository repository)
        {
            this.Repository = repository;
        }

        protected abstract IList<Product> MakeProducts();

        public abstract void Execute();
    }

    public interface IProviderManager
    {
        void Add(IProvider item);
        void ExecuteAll();
    }

    public class ProviderManager : IProviderManager
    {
        private List<IProvider> items;

        public ProviderManager()
        {
            items = new List<IProvider>();
        }

        public void Add(IProvider item)
        {
            items.Add(item);
        }

        public void ExecuteAll()
        {
            foreach (IProvider p in items)
            {
                p.Execute();
            }
        }
    }
}
