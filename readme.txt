### If everything is fine, you should be able to run ------------------------###

dotnet ef

### After that you can run commands like: -----------------------------------###

dotnet ef migrations add initial

dotnet ef database update

### With Multiple directories
dotnet ef --startup-project ../ migrations add V1
dotnet ef --startup-project ../ database update


### dotnet code genertor ----------------------------------------------------###
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0

### Database migration using Package manager console ------------------------###
Add-Migration <NAME>
Update-Database