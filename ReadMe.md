Install-Package GraphQL
Install-Package GraphiQL

Install-Package GraphQL -Version 2.4.0
Install-Package GraphQL.Server.Transports.AspNetCore -Version 3.4.0
Install-Package GraphQL.Server.Ui.Playground -Version 3.4.0	

query {
  authors{
    id
    firstName
    lastName
  }
}


query {
  author (id: 1){
    id
    firstName
    lastName
  }
  blogs
    {
      id
      title
      content
    }
}