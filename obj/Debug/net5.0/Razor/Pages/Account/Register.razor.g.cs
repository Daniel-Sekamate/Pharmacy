#pragma checksum "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e5c350bf7dbf518ff798aac57132fe6c1755af"
// <auto-generated/>
#pragma warning disable 1591
namespace Pharmacy.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CoreProjects\Pharmacy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Pharmacy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Pharmacy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CoreProjects\Pharmacy\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Microsoft.AspNetCore.Identity.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Pharmacy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using Pharmacy.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<ol class=\"breadcrumb\" style=\"margin-top:5px;\"><li class=\"breadcrumb-item active\" style=\"width: 100%; background-color: black; color: white; font-family: Cambria; padding: 5px; font: bolder;\"><stong> Register </stong></li></ol>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-12 control-section");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(5);
            __builder.AddAttribute(6, "ID", "toast_type");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(8);
                __builder2.AddAttribute(9, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                               ToastPosition

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line 22 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                       ToastObj = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                  InputModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 28 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                              RegisterUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "row");
                __builder2.AddMarkupContent(22, "<div class=\"col-md-3\"></div>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-6");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, AStaff>>(27);
                __builder2.AddAttribute(28, "ID", "StaffId");
                __builder2.AddAttribute(29, "Enabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<AStaff>>(
#nullable restore
#line 35 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                                          Staff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Placeholder", "Staff");
                __builder2.AddAttribute(32, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 35 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                                                                                     FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 35 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                           InputModel.StaffId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.StaffId = __value, InputModel.StaffId))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => InputModel.StaffId));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, AStaff>>(37);
                    __builder3.AddAttribute(38, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, AStaff>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, AStaff>>(this, 
#nullable restore
#line 36 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                    OnStaffChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(40);
                    __builder3.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                       nameof(AStaff.StaffId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                      nameof(AStaff.StaffName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(46);
                __builder2.AddAttribute(47, "ID", "UserName");
                __builder2.AddAttribute(48, "Placeholder", "User Name");
                __builder2.AddAttribute(49, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 41 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                   FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                      InputModel.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.UserName = __value, InputModel.UserName))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InputModel.UserName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(56);
                __builder2.AddAttribute(57, "ID", "Email");
                __builder2.AddAttribute(58, "Placeholder", "Email");
                __builder2.AddAttribute(59, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 44 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                         FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                   InputModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.Email = __value, InputModel.Email))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InputModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(66);
                __builder2.AddAttribute(67, "ID", "PhoneNumber");
                __builder2.AddAttribute(68, "Placeholder", "Phone Number");
                __builder2.AddAttribute(69, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 47 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                            FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                         InputModel.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.PhoneNumber = __value, InputModel.PhoneNumber))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InputModel.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, AspNetRole>>(76);
                __builder2.AddAttribute(77, "ID", "UserRole");
                __builder2.AddAttribute(78, "Enabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<AspNetRole>>(
#nullable restore
#line 50 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                                                UserRoles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "Placeholder", "User Role");
                __builder2.AddAttribute(81, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 50 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                                                                                                   FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 50 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                            InputModel.UserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.UserRole = __value, InputModel.UserRole))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => InputModel.UserRole));
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(86);
                    __builder3.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                       nameof(AspNetRole.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                       nameof(AspNetRole.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(92);
                __builder2.AddAttribute(93, "ID", "Password");
                __builder2.AddAttribute(94, "Placeholder", "Password");
                __builder2.AddAttribute(95, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 55 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                  FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                      InputModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.Password = __value, InputModel.Password))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InputModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(102);
                __builder2.AddAttribute(103, "ID", "ConfirmPassword");
                __builder2.AddAttribute(104, "Placeholder", "Confirm Password");
                __builder2.AddAttribute(105, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 58 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                                                                                                        FloatLabelType.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
                                                             InputModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InputModel.ConfirmPassword = __value, InputModel.ConfirmPassword))));
                __builder2.AddAttribute(108, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InputModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.AddMarkupContent(110, "<div class=\"form-group\"><button class=\"btn btn-primary btn-lg\" style=\"float:right\" type=\"submit\">Register</button></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n        <div class=\"col-md-3\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\CoreProjects\Pharmacy\Pages\Account\Register.razor"
       
    #region Toasters
    public static string ToastContent { get; set; }
    SfToast ToastObj;
    SfToast DeleteToastObj;
    private string ToastPosition = "Right";
    private int AlarmTimeout { get; set; } = 120000;
    private List<ToastModel> Toast = new List<ToastModel>
{
        new ToastModel{ Title = "Warning!", Content=ToastContent, CssClass="e-toast-warning", Icon="e-warning toast-icons" },
        new ToastModel{ Title = "Success!", Content=ToastContent, CssClass="e-toast-success", Icon="e-success toast-icons" },
        new ToastModel{ Title = "Error!", Content=ToastContent, CssClass="e-toast-danger", Icon="e-error toast-icons" },
        new ToastModel{ Title = "Information!", Content=ToastContent, CssClass="e-toast-info", Icon="e-info toast-icons" }
    };
    #endregion Toasters
    private RegisterViewModel InputModel = new RegisterViewModel();
    private List<AStaff> Staff { get; set; }
    private string StaffName { get; set; }
    private List<AspNetRole> UserRoles { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (!userManagement.IsSignedIn())
            {
                Navigation.NavigateTo("Account/Login", true);
            }
            Staff = _context.AStaffs.ToList();
            UserRoles = _context.AspNetRoles.ToList();
        }
        catch (Exception ex)
        {
            await ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }
    }

    public async Task RegisterUser()
    {
        try
        {
            var user = new IdentityUser { UserName = InputModel.UserName, Email = InputModel.Email, PhoneNumber = InputModel.PhoneNumber, LockoutEnabled = false };
            var result = await _userManager.CreateAsync(user, InputModel.Password);
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");
                using (var dbContext = new SPToCoreContext())
                {
                    var exist = dbContext.AspNetUsers.FirstOrDefault(o => o.Id == user.Id);
                    if (exist != null)
                    {
                        exist.StaffId = InputModel.StaffId;
                        exist.EmailConfirmed = true;
                        exist.LockoutEnabled = false;
                        exist.PhoneNumberConfirmed = true;
                        dbContext.Entry(exist).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }
                }
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                await _userManager.ConfirmEmailAsync(user, code);

                var _result = await _userManager.AddToRoleAsync(user, InputModel.UserRole);

                if (_result.Succeeded)
                {
                    await ToastObj.Show(new ToastModel { Title = "Success!", Content = StaffName + " has been successfully registered!", CssClass = "e-toast-success", Icon = "e-success toast-icons" });
                }
                else
                {
                    string _error = string.Empty;
                    foreach (var error in _result.Errors)
                    {
                        // ModelState.AddModelError(string.Empty, error.Description);
                        _error += error.Description + ",";
                    }
                    await ToastObj.Show(new ToastModel { Title = "Error!", Content = _error, CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
                }

            }
            else
            {
                string _error = string.Empty;
                foreach (var error in result.Errors)
                {
                    // ModelState.AddModelError(string.Empty, error.Description);
                    _error += error.Description + ",";
                }
                await ToastObj.Show(new ToastModel { Title = "Error!", Content = _error, CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
            }
        }
        catch (Exception ex)
        {
            await ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }

    }

    public void OnStaffChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, AStaff> args)
    {
        try
        {
            var data = args.ItemData;
            //int val = Convert.ToInt32(args.Value);
            InputModel.PhoneNumber = data.Phone;
            InputModel.Email = data.Email;
            StaffName = data.StaffName;
        }
        catch (Exception ex)
        {
            ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManagement userManagement { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Register> _logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmailSender _emailSender { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PharmacyContext _context { get; set; }
    }
}
#pragma warning restore 1591
