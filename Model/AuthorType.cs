using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlDotNetApp.Model
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Name = "Author";
            Field(_ => _.Id).Description("Author's Id.");

            Field(_ => _.FirstName).Description
            ("First name of the author");

            Field(_ => _.LastName).Description
            ("Last name of the author");
        }
    }

    public class BlogPostType : ObjectGraphType<BlogPost>
    {
        public BlogPostType()
        {
            //Array.Empty<>
            Name = "BlogPost";
            Field(_ => _.Id, type:
            typeof(IdGraphType)).Description
           ("The Id of the Blog post.");
            Field(_ => _.Title).Description
            ("The title of the blog post.");
            Field(_ => _.Content).Description
            ("The content of the blog post.");
        }
    }
}
