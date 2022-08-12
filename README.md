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

8- finished

## Handling Events in blazor Example :

    <button @onclick="SendMail">
        Send Email
    </button> 
    @code {
        private void SendMail(MouseEventArgs e)
        {
            ...
        }
    }

## Working with JavaScript in Blazor
Calling JavaScript function from Blazor Components requires IJSRuntime Interface of the Microsoft.JSInterop which you can inject into the Razor component as shown below:

    @inject IJSRuntime JS
    
Alternately, you can also do the injection with the [Inject] attribute as shown below:

    [Inject] 
    public IJSRuntime JSRuntime { get; set; }
    
Then you can Call JavaScript functions from Blazor.The full full code example:

    @using Microsoft.JSInterop
    @inject IJSRuntime JS;

    @page "/CallJS"

    <h1 class="bg-info text-white">Call JavaScript from Blazor</h1>

    <div class="form-group">
        <button class="btn btn-secondary" @onclick="ShowAlert">Show JavaScript Alert</button>
    </div>

    @code {
        public async void ShowAlert()
        {
            await JS.InvokeVoidAsync("JSAlert");
        }
    }

Next create a JavaScript file called example.js inside the wwwrooot/JS folder of you app. Add the function called JSAlert that shows the alert box with a text “Hello”. The code is given below:

    function JSAlert() {
        alert("Hello");
    }
Now create a script tag with “src” targeted to this JavaScript file in the _Host.cshtml file after the call to blazor.server.js as highlighted in the below code:

    <body>
        <div class="m-1 p-1">
            <component type="typeof(BlazorJS.App)" render-mode="ServerPrerendered" />
        </div>

        <script src="_framework/blazor.server.js"></script>
        <script src="~/JS/example.js"></script>
    </body>

## Blazor number based Paging

There are just 2 things we need to create which are:

1. A C# class called PagingInfo.cs which keeps track of paging.

    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems /
                    ItemsPerPage);
            }
        }
    }
    
2. A Razor Component called Paging.Razor where this paging will be shown.

## Aditonal resources
<a href="https://www.yogihosting.com/blazor-first-application/">Creating First Application in Blazor from scratch</a>
