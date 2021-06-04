using System;
using Microsoft.Extensions.DependencyInjection;


namespace HomeAccounting.CompositionRoot
{
    public abstract class AbstractApplicationBuilder
    {
        protected readonly IServiceCollection _services;

        /// <summary> Регистрация бизнес-логики </summary>
        protected abstract void RegisterBusinessLogic();

        /// <summary> Регистрация слоя данных </summary>
        protected abstract void RegisterDataSource();

        /// <summary> Регистрация инфраструктуры</summary>
        protected abstract void RegisterInfrastructure();

        public AbstractApplicationBuilder(IServiceCollection services)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public void Build()
        {
            RegisterInfrastructure();
            RegisterDataSource();
            RegisterBusinessLogic();
        }
    }
}