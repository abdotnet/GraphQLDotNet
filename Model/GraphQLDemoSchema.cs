using GraphQL;
using GraphQL.Types;
using GraphqlDotNetApp.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlDotNetApp.Model
{
    public class GraphQLDemoSchema : Schema, ISchema
    {
        public GraphQLDemoSchema(IDependencyResolver
        resolver) : base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
        }
    }
}
