# StudentsBlazorServer-EFCore

A Students management system using Blazor Server and EF core.

## How Blazor Works
There are two kinds of Blazor projects:
* Blazor Server projects which needs to be hosted in the server
* Blazor WebAssembly which Once the app is downloaded to the browser it becomes fully functionable and so there is no server-side dependency.

Blazor server maintains a “Persistent” HTTP connection between the Client (i.e. Browser) and the Server using SignalR. When an event, such as a button click, is performed by the client then this information about the event is sent to the server over the SignalR connection.

The server in turn handles the event and sends back the updated HTML (which is based on what the event performed) to the client. The updated HTML is not the entire page HTML but only a small part and hence the response is much faster. The browser, on receiving the response, updates the user interface (UI).

## Instruction to create the base project,Initialy committed to git:
Create a new blazor server project in visual studio 2022 and :

1- Create the models: School.cs, Location.cs, Student.cs

2- Create the DbContext : DataContext.cs

3-Add  Configuration and services to Startup.cs 

    services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddRazorPages();
    
    
4- Add connection string to appsettings.json

5- Performing Migrations:
    `
    dotnet ef migrations add Migration1
    dotnet ef database update
    `
6-Insert Data:
    In order to use Entity Framework Core in Blazor you will need to Inject the Data Context to the Razor Component by using the [Inject] attribute as shown below:
   `[Inject]
    public DataContext Context { get; set; }
    `
    
so create a new Razor Component called <b>ManageSchool.razor</b> inside the “Pages” folder of your app and inside the @code inject and insert the data:
<pre><code>
@page "/ManageSchool"
 
&lt;h1 class="bg-info text-white">Manage School</h1>
&lt;h2 class="text-success bg-light p-2">Add a School</h2>
&lt;h3 class="text-warning bg-light p-2">@FormSubmitMessage</h3>
&lt;div class="form-group">
    &lt;label>Name:</label>
    &lt;input class="form-control" type="text" @bind="SchoolData.Name" />
    &lt;button class="m-1 btn btn-primary" @onclick="Create">Click</button>
&lt;/div>
@code {
    [Inject]
    public DataContext Context { get; set; }
    public School SchoolData = new School();
    public string FormSubmitMessage { get; set; } = "Form Data Not Submitted";
    public void Create()
    {
        Context.Add(SchoolData);
        Context.SaveChanges();  
        FormSubmitMessage = "Form Data Submitted";
        SchoolData = new School();
    }
}
 </code>  </pre>
### Form components in Blazor:
Blazor Provides Built-in Form Component that are used to receive and validate the user input. These inputs are validated when they are changed and also when the form is submitted. These components resides in the Microsoft.AspNetCore.Components.Forms namespace. In the below table I have listed all of them.

Component	|Description
--- | --- 
EditForm	|It renders a form element that also performs data validations.
InputText	|It renders an input element of type text. It can be bind to a C# value.
InputNumber	|It renders an input element of type number. It can be bind to a C# int, long, float, double, or decimal values. Here “T” is the type.
InputFile	|It renders an input element of type file.
InputDate	|It renders an input element of type date. It can be bind to a C# DateTime or DateTimeOffset values.
InputCheckbox	|It renders an input element of type checkbox and that is bound to a C# bool property.
InputSelect	|It renders a html select element. T is the type
InputRadio	|It renders a input type radio element.
InputRadioGroup	|Use InputRadio components with the InputRadioGroup component to create a radio button group.
InputTextArea	|It renders a html select element.


### Blazor Validation Components
Blazor provides 3 Validation components to perform data validations, and show Validation messages. These are:

Component	|Description
--- | --- 
DataAnnotationsValidator |This component integrates the validation attributes applied to Model Class (Data Annotations) into the Blazor Validation system.
ValidationMessage	|It displays validation error messages for a single property.
ValidationSummary	|It displays validation error messages for the entire form.
validation-errors	|The ValidationSummary component generates a top level ‘ul’ container for the summary of validation messages and assigns validation-errors CSS class 
validation-message	|The top level ‘ul’ container is populated with ‘li’ elements for each validation message. These li elements are assigned with validation-message

7-Add @page "/ManageLocation" compoent with validation

    
