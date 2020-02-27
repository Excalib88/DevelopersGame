// execute in WebProject

dotnet ef migrations add name -c DataContext --project ../DevelopersGame.DataAccess.Migrations
dotnet ef database update -c DataContext --project ../DevelopersGame.DataAccess.Migrations