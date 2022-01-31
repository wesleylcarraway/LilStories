# LilStories
A web API using .NET 6, Entity Framework, Swagger, Sql Server. Here you would be able to get many short stories of different genres.

## How it was built
Object oriented, using Entity Framework, the app has its main entity "Story", 
where I mapped(with AutoMapper, and Fluent API) its properties to the database Sql Server, I also created Dto's, I used dependency injection,
repository pattern, and the main implementations of http methods in the StoryController(GET(Get e GetById), POST, PUT, DELETE).

## Try it on your machine
```
git clone https://github.com/wesleylcarraway/LilStories.git
```
