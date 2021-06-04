using System;
using Microsoft.Extensions.DependencyInjection;


namespace HomeAccounting.CompositionRoot
{
    /// <summary> Регистриация приложения </summary>
    public abstract class AbstractApplicationBuilder
    {
        protected readonly IServiceCollection _services;

        /// <summary> Регистрация бизнес-логики </summary>
        protected abstract void RegisterBusinessLogic();

        /// <summary> Регистрация слоя данных </summary>
        protected abstract void RegisterDataSource();

        /// <summary> Регистрация инфраструктуры</summary>
        protected abstract void RegisterInfrastructure();

        /// <summary> Регистриация приложения </summary>
        public AbstractApplicationBuilder(IServiceCollection services)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
        }

        /// <summary>
        /// Зарегистрировать приложение
        /// </summary>
        public void Build()
        {
            RegisterInfrastructure();
            RegisterDataSource();
            RegisterBusinessLogic();
        }
    }
}