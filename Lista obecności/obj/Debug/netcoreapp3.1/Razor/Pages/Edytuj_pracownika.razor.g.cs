#pragma checksum "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563e6d91716878f8f018d0728700341becc3d2af"
// <auto-generated/>
#pragma warning disable 1591
namespace Lista_obecności.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Lista_obecności;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\_Imports.razor"
using Lista_obecności.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
using Lista_obecności.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
using Lista_obecności.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edytuj/{Ids}")]
    public partial class Edytuj_pracownika : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"col-12\"><br></div>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"col-12\"><br></div>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"col-12\"><br></div>\r\n");
            __builder.AddMarkupContent(3, "<div class=\"col-12\"><br></div>\r\n");
            __builder.AddMarkupContent(4, "<div class=\"col-12\"><br></div>\r\n\r\n");
            __builder.AddMarkupContent(5, "<header id=\"pracownik\" class=\"h1\"> Modyfikacja danych pracownika </header>\r\n\r\n");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "container p-0 m-0 col-12 pracownik");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"col-12\"><br></div>\r\n    ");
            __builder.AddMarkupContent(10, "<div class=\"col-12\"><br></div>\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"col-12\"><br></div>\r\n    ");
            __builder.AddMarkupContent(12, "<div class=\"col-12\"><br></div>\r\n    ");
            __builder.AddMarkupContent(13, "<div class=\"col-12\"><br></div>\r\n\r\n");
#nullable restore
#line 28 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
     if (worker != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                          worker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "background-color:transparent");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n            ");
                __builder2.AddMarkupContent(22, @"<div class=""col-lg-12 col-5 pracownik"">
                <label class=""col-lg-4 col-12 offset-lg-2"">
                    NAZWISKO:
                </label>

                <label class=""col-lg-4 col-12"">
                    IMIĘ:
                </label>

            </div>

            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-lg-12 col-6 pracownik");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-lg-4 offset-lg-3 col-12 pracownik");
                __builder2.AddMarkupContent(28, "\r\n                    &nbsp;");
                __Blazor.Lista_obecności.Pages.Edytuj_pracownika.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 46 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                    () => worker.Surname

#line default
#line hidden
#nullable disable
                , 31, "text-align:left");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(36, "placeholder", 
#nullable restore
#line 47 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                                               worker.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                  worker.Surname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => worker.Surname = __value, worker.Surname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-lg-4 col-12 pracownik");
                __builder2.AddMarkupContent(43, "\r\n                    &nbsp;");
                __Blazor.Lista_obecności.Pages.Edytuj_pracownika.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 51 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                    () => worker.Name

#line default
#line hidden
#nullable disable
                , 46, "text-align:left");
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(51, "placeholder", 
#nullable restore
#line 52 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                                            worker.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                  worker.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => worker.Name = __value, worker.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n            ");
                __builder2.AddMarkupContent(57, "<div class=\"col-12\"><br></div>\r\n\r\n            ");
                __builder2.AddMarkupContent(58, @"<div class=""col-lg-12 col-5 pracownik"">

                <div class=""col-12""><br></div>

                <label class=""col-lg-4 offset-lg-2 col-12"">
                    DZIAŁ:
                </label>

                <label class=""col-lg-4 col-12"">
                    KIEROWNIK:
                </label>
            </div>

            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-lg-12 col-6 pracownik");
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-lg-4 offset-lg-2 col-12 pracownik");
                __builder2.AddMarkupContent(64, "\r\n                    &nbsp;");
                __Blazor.Lista_obecności.Pages.Edytuj_pracownika.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 74 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                    () => worker.Section

#line default
#line hidden
#nullable disable
                , 67, "text-align:center");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "id", "dzial");
                __builder2.AddAttribute(71, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(72, "type", "text");
                __builder2.AddAttribute(73, "placeholder", 
#nullable restore
#line 75 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                                                          worker.Section

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                             worker.Section

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => worker.Section = __value, worker.Section));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n                ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-1 offset-2 pracownik p-0");
                __builder2.AddMarkupContent(80, "\r\n                    &nbsp;");
                __Blazor.Lista_obecności.Pages.Edytuj_pracownika.TypeInference.CreateValidationMessage_3(__builder2, 81, 82, 
#nullable restore
#line 79 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                    () => worker.IsManager

#line default
#line hidden
#nullable disable
                , 83, "text-align:center");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "id", "checkK");
                __builder2.AddAttribute(87, "oninput", "this.value=this.value.toUpperCase()");
                __builder2.AddAttribute(88, "type", "checkbox");
                __builder2.AddAttribute(89, "value", "unchecked");
                __builder2.AddAttribute(90, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                                                                                                              worker.IsManager

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => worker.IsManager = __value, worker.IsManager));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-12 pracownik");
                __builder2.AddMarkupContent(97, "\r\n\r\n                ");
                __builder2.AddMarkupContent(98, "<div class=\"col-12\"><br></div>\r\n                ");
                __builder2.AddMarkupContent(99, "<div class=\"col-12\"><br></div>\r\n                ");
                __builder2.AddMarkupContent(100, "<div class=\"col-12\"><br></div>\r\n                ");
                __builder2.AddMarkupContent(101, "<div class=\"col-12\"><br></div>\r\n                ");
                __builder2.AddMarkupContent(102, "<div class=\"col-12\"><br></div>\r\n\r\n                ");
                __builder2.OpenElement(103, "button");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
                                  EditWorker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "type", "submit");
                __builder2.AddAttribute(106, "class", "col-lg-3 offset-lg-3 col-5");
                __builder2.AddMarkupContent(107, "\r\n                    Zapisz zmiany\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n\r\n                ");
                __builder2.AddMarkupContent(109, "<button onclick=\"location.href=\'/lista\';\" type=\"button\" class=\"col-lg-3 col-5\">\r\n                    Anuluj modyfikację\r\n                </button>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.AddContent(112, "        ");
            __builder.AddMarkupContent(113, @"<div class=""col-12 pracownik"">

            <div class=""col-12""><br></div>
            <div class=""col-12""><br></div>
            <div class=""col-12""><br></div>
            <div class=""col-12""><br></div>
            <div class=""col-12""><br></div>

            <label class=""autor"">Autor: Michał Manios</label>
        </div>
");
            __builder.AddContent(114, "        ");
            __builder.AddMarkupContent(115, "<div class=\"col-12 pracownik\">\r\n            <label class=\"autor\">Wersja: 1.0</label>\r\n        </div>\r\n");
#nullable restore
#line 117 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "        ");
            __builder.AddMarkupContent(117, "<p id=\"pracownik\" class=\"h1\"> Nie znaleziono praconika o podanym numerze ID!!!</p>\r\n        ");
            __builder.AddMarkupContent(118, "<button onclick=\"location.href=\'/lista\';\" type=\"button\" class=\"col-lg-3 col-5\">\r\n            Wróć do poprzedniej strony\r\n        </button>\r\n");
#nullable restore
#line 124 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_pracownika.razor"
       

    [Parameter]
    public string Ids { get; set; }



    WorkersDTO worker = new WorkersDTO();

    protected override void OnInitialized()
    {
        worker = iApplicationManager.GetAllWorkers(null).Where(x => x.Id == Convert.ToInt32(Ids)).FirstOrDefault();
    }


    void EditWorker()
    {
        if (!string.IsNullOrEmpty(worker.Name) &&
            !string.IsNullOrEmpty(worker.Surname) &&
            !string.IsNullOrEmpty(worker.Section))
        {
            iApplicationManager.ModifyWorker(worker);
            navigationManager.NavigateTo("/lista");
        }
    }



    /*
    List<WorkersDTO> workers;
    WorkersDTO worker = new WorkersDTO();


    protected override void OnInitialized()
    {
        workers = iApplicationManager.GetAllWorkers(null).OrderByDescending(x => x.IsManager).ThenBy(x => x.Surname).ThenBy(x => x.Name).ToList();

        worker = iApplicationManager.GetAllWorkers(null).Where(x => x.Id == Convert.ToInt32(Id)).FirstOrDefault();
    }
    void EditWorker()
    {
        if (!string.IsNullOrEmpty(worker.Name) &&
            !string.IsNullOrEmpty(worker.Surname) &&
            !string.IsNullOrEmpty(worker.Section))
        {
            WorkersDTO workersq = iApplicationManager.GetAllWorkers(null).Where(x => x.Id == Convert.ToInt32(Id)).FirstOrDefault();

            //for (int i = 0; i < workers.Count; i++)
            //{
                //if(workers[i].Id==worker.Id)
               // {
                    workersq.Name = worker.Name;
                    workersq.Surname = worker.Surname;
                    workersq.Section = worker.Section;
                    workersq.IsManager = worker.IsManager;
                    iApplicationManager.ModifyWorker(workersq);
                   // break;
                //}
            //}

            navigationManager.NavigateTo("/lista");
        }
    }*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApplicationManager iApplicationManager { get; set; }
    }
}
namespace __Blazor.Lista_obecności.Pages.Edytuj_pracownika
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
