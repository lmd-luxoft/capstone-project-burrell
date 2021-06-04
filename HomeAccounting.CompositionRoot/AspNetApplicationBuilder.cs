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
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override void RegisterDataSource()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override void RegisterInfrastructure()
        {
            throw new NotImplementedException();
        }
    }
}
