#pragma checksum "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_swieto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c41792514f3f9cd018b2fc692b2a7d7f8c09a8f8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_swieto.razor"
using Lista_obecności.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_swieto.razor"
using Lista_obecności.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_swieto.razor"
using Lista_obecności.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edytujsw/{Ids}")]
    public partial class Edytuj_swieto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Edytuj_swieto.razor"
       

    [Parameter]
    public string Ids { get; set; }



    FreeDaysDTO freeDay = new FreeDaysDTO();

    protected override void OnInitialized()
    {
        freeDay = iApplicationManager.GetAllFreeDays().Where(x => x.Id == Convert.ToInt32(Ids)).FirstOrDefault();
    }


    void EditFreeDay()
    {
        if (!string.IsNullOrEmpty(freeDay.Day.ToString()) &&
            !string.IsNullOrEmpty(freeDay.Day.ToString()) &&
            !string.IsNullOrEmpty(freeDay.NameOfHoliday))
        {
            iApplicationManager.ModifyFreeDay(freeDay);
            navigationManager.NavigateTo("/swieta");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApplicationManager iApplicationManager { get; set; }
    }
}
#pragma warning restore 1591
