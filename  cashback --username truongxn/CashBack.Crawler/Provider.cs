using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler
{
    public interface IProvider
    {
        void Execute();
    }

    public abstract class Provider : IProvider
    {
        protected readonly ICatalogService Service;
        protected ProgramEnum Program { get; set; }

        public Provider(ICatalogService service)
        {
            this.Service = service;
        }

        public abstract void Execute();
        public abstract void UpdateProvider();
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
                Work w = new Work();
                w.Job = p;
                Thread t = new Thread(new ThreadStart(w.DoWork));
                t.Start();
            }
        }

        
    }

    public class Work
    {
        public IProvider Job;
        public void DoWork()
        {
            this.Job.Execute();
        }
    }
}
