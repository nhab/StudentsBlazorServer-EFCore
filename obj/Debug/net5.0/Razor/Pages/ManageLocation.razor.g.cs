#pragma checksum "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b86241da127e7c478026fb8bc03229213aac44"
// <auto-generated/>
#pragma warning disable 1591
namespace Students_BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using BlazorForms.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\tmp\StudentsBlazorServer-EFCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageLocation/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageLocation")]
    public partial class ManageLocation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/validation.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-sm-12\"><h1 class=\"bg-info text-white\">Manage Location</h1></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm-5");
            __builder.OpenElement(8, "h2");
            __builder.AddAttribute(9, "class", "text-success p-2");
#nullable restore
#line 12 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
__builder.AddContent(10, FormSubmitMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                             LocationData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                                                              HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>City</label>\r\n                    ");
                __Blazor.Students_BlazorServer.Pages.ManageLocation.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 19 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                              () => LocationData.City

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                                 LocationData.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocationData.City = __value, LocationData.City))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LocationData.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label>State</label>\r\n                    ");
                __Blazor.Students_BlazorServer.Pages.ManageLocation.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 24 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                              () => LocationData.State

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                                 LocationData.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocationData.State = __value, LocationData.State))));
                __builder2.AddAttribute(43, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LocationData.State));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.AddMarkupContent(45, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-primary\">Click</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-sm-7");
            __builder.OpenElement(49, "table");
            __builder.AddAttribute(50, "class", "table table-sm table-bordered table-striped ");
            __builder.AddMarkupContent(51, "<thead><tr><th>ID</th>\r\n                        <th>City</th>\r\n                        <th>State</th>\r\n                        <th>Edit</th>\r\n                        <th>Delete</th></tr></thead>\r\n                ");
            __builder.OpenElement(52, "tbody");
#nullable restore
#line 44 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                     foreach (Location a in Locations)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "tr");
            __builder.OpenElement(54, "td");
#nullable restore
#line 47 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
__builder.AddContent(55, a.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.OpenElement(57, "td");
#nullable restore
#line 48 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
__builder.AddContent(58, a.City);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 49 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
__builder.AddContent(61, a.State);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "td");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-sm btn-warning");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                    () => Edit(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\r\n                                    Edit\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.OpenElement(69, "td");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                                                    () => Delete(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                                    Delete\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\tmp\StudentsBlazorServer-EFCore\Pages\ManageLocation.razor"
       
    [Inject]
    public DataContext Context { get; set; }

    public Location LocationData = new Location();

    public string FormSubmitMessage { get; set; } = "Form Data Not Submitted";

    public void HandleValidSubmit()
    {
        if (Id == 0)
            Context.Add(LocationData);
        Context.SaveChanges();

        UpdateBindings(0, "/ManageLocation", "Form Data Submitted");
        UpdateLocations();
    }

    public void HandleInvalidSubmit() => FormSubmitMessage = "Invalid Data Submitted";

    public List<Location> Locations = new List<Location>();

    protected override void OnInitialized()
    {
        UpdateLocations();
    }

    public void UpdateLocations()
    {
        if (Id != 0)
            LocationData = Context.Location.Where(a => a.Id == Id).FirstOrDefault();
        Locations = Context.Location.ToList();
    }

    [Parameter]
    public int Id { get; set; }

    [Inject]
    public NavigationManager NavManager { get; set; }

    public void Edit(Location a)
    {
        UpdateBindings(a.Id, "/ManageLocation/" + a.Id, "Form Data Not Submitted");
        UpdateLocations();
    }

    public void Delete(Location a)
    {
        if (a.Id == LocationData.Id)
        {
            UpdateBindings(0, "/ManageLocation", "Form Data Not Submitted");
        }

        Context.Remove(a);
        Context.SaveChanges();
        UpdateLocations();
    }

    public void UpdateBindings(int idValue, string NavigationValue, string FormSubmitValue)
    {
        Id = idValue;
        NavManager.NavigateTo(NavigationValue);
        FormSubmitMessage = FormSubmitValue;
        LocationData = new Location();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Students_BlazorServer.Pages.ManageLocation
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
