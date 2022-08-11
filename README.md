# StudentsBlazorServer-EFCore

A Students management system using Blazor Server and EF core.

## How Blazor Works
Blazor maintains a “Persistent” HTTP connection between the Client (i.e. Browser) and the Server using SignalR. When an event, such as a button click, is performed by the client then this information about the event is sent to the server over the SignalR connection.

The server in turn handles the event and sends back the updated HTML (which is based on what the event performed) to the client. The updated HTML is not the entire page HTML but only a small part and hence the response is much faster. The browser, on receiving the response, updates the user interface (UI).

## Instruction to create Initial Committed project:
Create a new blazor server project in visual studio 2022 and :
1- Create the models: School.cs, Location.cs, Student.cs
2- Create the DbContext : DataContext.cs
3-Add  Configuration and services to Startup.cs 
    services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddRazorPages();
4- Add connection string to appsettings.json
5-
