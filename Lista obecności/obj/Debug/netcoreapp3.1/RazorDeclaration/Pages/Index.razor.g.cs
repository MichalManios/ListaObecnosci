#pragma checksum "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec65b6475c8ad8c0eca6b14143c29d2278fd658"
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
#line 2 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor"
using Lista_obecności.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor"
using Lista_obecności.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Indexlayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 184 "C:\To Publish\Gotowe\Lista obecności\Lista obecności\Pages\Index.razor"
       
        int iStartDating = 0;
        int iDayInMonth = 0;
        List<int> iRedDays = new List<int>();
        List<int> HolidayDay = new List<int>();
        string Date = "";
        List<FreeDaysDTO> freeDays = new List<FreeDaysDTO>();

        async Task CreateAdminAccount()
        {
            Roles roles = new Roles();
            var user = await _userManager.FindByNameAsync("Admin");
            if (user == null)
            {
                var userAdmin = new IdentityUser { UserName = "Admin", Email = "dil_as@sw.gov.pl" };
                var result = await _userManager.CreateAsync(userAdmin, "Admin123!");

                var RoleResult = await _roleManager.FindByNameAsync(roles.Admin);
                if (RoleResult == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(roles.Admin));
                }
                await _userManager.AddToRoleAsync(userAdmin, roles.Admin);
            }
        }




    protected override async Task OnInitializedAsync()
    {
        Date = DateTime.Today.Day.ToString() + " " + SetCalendarMonth();
        GetFreeDays();
        SetHolidayDay();
        await CreateAdminAccount();
    }

    int DrawCalendar()
    {
        int Month;
        int Year;
        Month = DateTime.Today.Month;
        Year = DateTime.Today.Year;

        var firstDayOfMonth = new DateTime(Year, Month, 1);
        string sDayOfWeek = firstDayOfMonth.DayOfWeek.ToString();
        int iStartDating = 0;

        if (sDayOfWeek == "Monday") iStartDating = 1;
        if (sDayOfWeek == "Tuesday") iStartDating = 2;
        if (sDayOfWeek == "Wednesday") iStartDating = 3;
        if (sDayOfWeek == "Thursday") iStartDating = 4;
        if (sDayOfWeek == "Friday") iStartDating = 5;
        if (sDayOfWeek == "Saturday") iStartDating = 6;
        if (sDayOfWeek == "Sunday") iStartDating = 7;

        iDayInMonth = DateTime.DaysInMonth(Year, Month);

        return iStartDating;
    }

    string SetCalendarMonth()
    {
        string sMonth = "";

        var month = DateTime.Now.Month.ToString();
        switch (Convert.ToInt32(month))
        {

            case 1: sMonth = "STYCZEŃ"; break;
            case 2: sMonth = "LUTY"; break;
            case 3: sMonth = "MARZEC"; break;
            case 4: sMonth = "KWIECIEŃ"; break;
            case 5: sMonth = "MAJ"; break;
            case 6: sMonth = "CZERWIEC"; break;
            case 7: sMonth = "LIPIEC"; break;
            case 8: sMonth = "SIERPIEŃ"; break;
            case 9: sMonth = "WRZESIEŃ"; break;
            case 10: sMonth = "PAŹDZiERNIK"; break;
            case 11: sMonth = "LISTOPAD"; break;
            case 12: sMonth = "GRUDZIEŃ"; break;
        }
        return sMonth;
    }

    void GetFreeDays()
    {
        var free = iApplicationManager.GetAllFreeDays();
        freeDays = free.OrderBy(x => x.Month).ThenBy(x => x.Day).ToList();
    }

    void SetHolidayDay()
    {
        HolidayDay.Clear();
        var month = DateTime.Today.Month.ToString();
        if (freeDays != null)
            foreach (var freeDay in freeDays)
            {
                if (freeDay.Month.ToString() == month) HolidayDay.Add(freeDay.Day);
            }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApplicationManager iApplicationManager { get; set; }
    }
}
#pragma warning restore 1591
