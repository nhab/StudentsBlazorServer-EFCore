#pragma checksum "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db317f298cba747f6c0b0d76da3f2fda9392cd4c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateStudent/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateStudent")]
    public partial class CreateStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/validation.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1 class=\"bg-info text-white\">Create Student</h1>\r\n");
            __builder.OpenElement(2, "h2");
            __builder.AddAttribute(3, "class", "text-success p-2");
#nullable restore
#line 7 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder.AddContent(4, FormSubmitMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                 StudentData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                                                 HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label>Id</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputNumber_0(__builder2, 18, 19, "form-control", 20, true, 21, 
#nullable restore
#line 14 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                       StudentData.Id

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Id = __value, StudentData.Id)), 23, () => StudentData.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label>Name</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_1(__builder2, 28, 29, 
#nullable restore
#line 18 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                     StudentData.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Name = __value, StudentData.Name))));
                __builder2.AddAttribute(35, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => StudentData.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label>Age</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 23 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputNumber_3(__builder2, 43, 44, "form-control", 45, 
#nullable restore
#line 24 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                       StudentData.Age

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Age = __value, StudentData.Age)), 47, () => StudentData.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label>Date Of Birth</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 28 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.DOB

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputDate_5(__builder2, 55, 56, "form-control", 57, 
#nullable restore
#line 29 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                     StudentData.DOB

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.DOB = __value, StudentData.DOB)), 59, () => StudentData.DOB);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "<label>Standard</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_6(__builder2, 64, 65, 
#nullable restore
#line 33 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Standard

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputSelect_7(__builder2, 67, 68, "form-control", 69, 
#nullable restore
#line 34 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                       StudentData.Standard

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Standard = __value, StudentData.Standard)), 71, () => StudentData.Standard, 72, (__builder3) => {
                    __builder3.AddMarkupContent(73, "<option selected disabled value=\"0\">Choose a Standard</option>");
#nullable restore
#line 36 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
             foreach (var s in Standard)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 38 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                s.Value

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 38 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder3.AddContent(76, s.Key);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 39 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "<label>Sex</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_8(__builder2, 81, 82, 
#nullable restore
#line 44 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputRadioGroup_9(__builder2, 84, 85, "form-control", 86, 
#nullable restore
#line 45 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                           StudentData.Sex

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Sex = __value, StudentData.Sex)), 88, () => StudentData.Sex, 89, (__builder3) => {
#nullable restore
#line 46 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
             foreach (var sex in Sex)
            {

#line default
#line hidden
#nullable disable
                    __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateInputRadio_10(__builder3, 90, 91, 
#nullable restore
#line 48 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                   sex.Value

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 48 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder3.AddContent(92, sex.Key);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                        
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddMarkupContent(96, "<label>Email</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_11(__builder2, 97, 98, 
#nullable restore
#line 54 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                     StudentData.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Email = __value, StudentData.Email))));
                __builder2.AddAttribute(104, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => StudentData.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "<label>Terms</label>\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_12(__builder2, 109, 110, 
#nullable restore
#line 59 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.Terms

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(112);
                __builder2.AddAttribute(113, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                    StudentData.Terms

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.Terms = __value, StudentData.Terms))));
                __builder2.AddAttribute(115, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => StudentData.Terms));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group");
                __builder2.AddMarkupContent(119, "<label>School</label>  (");
                __builder2.AddMarkupContent(120, "<a href=\"/ManageSchool\" target=\"_blank\">Manage School</a>)\r\n\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_13(__builder2, 121, 122, 
#nullable restore
#line 65 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.SchoolId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.OpenComponent<Students_BlazorServer.Pages.SelectCommon<School>>(124);
                __builder2.AddAttribute(125, "RowData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<School>>(
#nullable restore
#line 66 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                Schools

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "MyPhrase", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                                          StudentData.SchoolId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "MyPhraseChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.SchoolId = __value, StudentData.SchoolId))));
                __builder2.AddAttribute(128, "SelectOption", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(129, "<option selected disabled value=\"0\">Choose a School</option>");
                }
                ));
                __builder2.AddAttribute(130, "OptionValue", (Microsoft.AspNetCore.Components.RenderFragment<School>)((p) => (__builder3) => {
                    __builder3.OpenElement(131, "option");
                    __builder3.AddAttribute(132, "value", 
#nullable restore
#line 71 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                p.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 71 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder3.AddContent(133, p.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n    ");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "form-group");
                __builder2.AddMarkupContent(137, "<label>Location</label>(");
                __builder2.AddMarkupContent(138, "<a href=\"/ManageLocation\" target=\"_blank\">Manage Location</a>)\r\n        ");
                __Blazor.Students_BlazorServer.Pages.CreateStudent.TypeInference.CreateValidationMessage_14(__builder2, 139, 140, 
#nullable restore
#line 77 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                  () => StudentData.LocationId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(141, "\r\n        ");
                __builder2.OpenComponent<Students_BlazorServer.Pages.SelectCommon<Location>>(142);
                __builder2.AddAttribute(143, "RowData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Location>>(
#nullable restore
#line 78 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                  Locations

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "MyPhrase", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 78 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                                                              StudentData.LocationId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(145, "MyPhraseChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StudentData.LocationId = __value, StudentData.LocationId))));
                __builder2.AddAttribute(146, "SelectOption", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(147, "<option selected disabled value=\"0\">Choose a Location</option>");
                }
                ));
                __builder2.AddAttribute(148, "OptionValue", (Microsoft.AspNetCore.Components.RenderFragment<Location>)((p) => (__builder3) => {
                    __builder3.OpenElement(149, "option");
                    __builder3.AddAttribute(150, "value", 
#nullable restore
#line 84 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
                                p.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 84 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder3.AddContent(151, p.City);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(152, ", ");
#nullable restore
#line 84 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
__builder3.AddContent(153, p.State);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n    ");
                __builder2.AddMarkupContent(155, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-primary\">Click</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\tmp\StudentsBlazorServer-EFCore\Pages\CreateStudent.razor"
       
    [Inject]
    public DataContext Context { get; set; }

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public int Id { get; set; }

    public Student StudentData = new Student();
    public List<School> Schools = new List<School>();
    public List<Location> Locations = new List<Location>();

    public string FormSubmitMessage { get; set; } = "Form Data Not Submitted";

    public Dictionary<string, int> Standard = new Dictionary<string, int>() {
        {"Class 5", 5 },
        {"Class 6", 6 },
        {"Class 7", 7 },
        {"Class 8", 8 },
        {"Class 9", 9 },
        {"Class 10", 10 }
    };

    public Dictionary<string, string> Sex = new Dictionary<string, String>() {
        {"M", "Male" },
        {"F", "Female" }
    };

    public void HandleValidSubmit()
    {
        if (Id == 0)
            Context.Add(StudentData);
        Context.SaveChanges();
        NavManager.NavigateTo("/ReadStudent");
    }

    public void HandleInvalidSubmit() => FormSubmitMessage = "Invalid Data Submitted";

    protected async override Task OnParametersSetAsync()
    {
        if (Id != 0)
            StudentData = await Context.Student.FindAsync(Id);
        Schools = await Context.School.ToListAsync();
        Locations = await Context.Location.ToListAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Students_BlazorServer.Pages.CreateStudent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_12<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_13<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_14<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591