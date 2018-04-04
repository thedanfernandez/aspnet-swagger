# aspnet-swagger

Basic demo showing complex types and triple-slash comments for swagger based on the [ASP.NET Swagger tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?tabs=visual-studio-code%2Cvisual-studio-code-xml)

This uses the [XML Documentation Comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments), configured in csproj, to populate Swagger. 

## ProductController

Returns a basic Product class and includes triple-slash /// comments that appear in Swagger.

## Setup

- You'll need to install [.NET](http://dot.net)
- From a command line run "dotnet run" or run from Visual Studio

## URLs

- Products Controller List: http://localhost:5000/api/Products
- Products Controller by ID: http://localhost:5000/api/Products/1
- Products Swagger: http://localhost:5000/swagger/v1/swagger.json
- Swagger test page: http://localhost:5000/swagger/
- Values Controller (built-in): http://localhost:5000/api/values