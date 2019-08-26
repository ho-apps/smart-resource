using Autofac;

namespace ResourceMaterials.Api.Infrastructure.Modules
{
    public class ApplicationModule : Autofac.Module
    {
        private readonly string _connStr;

        public ApplicationModule(string connStr)
        {
            _connStr = connStr;
        }
        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<EventExecutor>()
            //    .InstancePerLifetimeScope();

            //builder.Register(c => new TransactionQueries(_connStr))
            //    .As<ITransactionQueries>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes(typeof(CreateCommandHandler).GetTypeInfo().Assembly)
            //    .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));
        }
    }
}