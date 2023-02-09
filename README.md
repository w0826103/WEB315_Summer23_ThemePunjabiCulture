# WEB315_Summer23_ThemePunjabiCulture

1. Created a PRIVATE github repository that incorporates the course number WEB315_Summer23_ThemePunjabiCulture and Readme file created.

2. Invited  as a collaborator to the repository (username is Majid1292)
3. created new web app
4. welcome page updated with theme,Date and Time 
5. created modals folder with theme punjabi culture in it 
6. 6 properties are created with ID, date ,time annotation
7. EF Tools are installed 
8. Used the Scaffolding terminal commands to build out your CRUD pages for model.
Document the commands in the Readme.md.


    dotnet tool install --global dotnet-ef --version 5
    dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

PunjabiCulture

dotnet-aspnet-codegenerator razorpage -m PunjabiCulture -dc PunjabiCultureContext -udl -outDir Pages/PunjabiCulture --referenceScriptLibraries -sqlite