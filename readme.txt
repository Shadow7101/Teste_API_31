usado como referencia:
https://www.youtube.com/watch?v=but7jqjopKM

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add  initial
dotnet ef database update