using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contract.Interfaces;
using HomeAccounting.DataSource.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    /// <summary> Регистрация приложения AspNet </summary>
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        /// <summary> Регистрация приложения AspNet </summary>
        public AspNetApplicationBuilder(IServiceCollection services) : base(services)
        {
        }

        /// <inheritdoc/>
        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccounting, AccountingService>();
        }

        /// <inheritdoc/>
        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
        }

        /// <inheritdoc/>
        protected override void RegisterInfrastructure()
        {            
        }
    }
}
