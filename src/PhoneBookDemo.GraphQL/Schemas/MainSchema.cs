using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using PhoneBookDemo.Queries.Container;

namespace PhoneBookDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}