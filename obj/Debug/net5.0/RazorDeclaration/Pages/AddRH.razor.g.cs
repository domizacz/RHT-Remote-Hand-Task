// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RemoteHand.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using RemoteHand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\_Imports.razor"
using RemoteHand.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\Pages\AddRH.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class AddRH : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\monster\source\repos\domizacz\test\RemoteHand\Pages\AddRH.razor"
                
    public List<ClassRH> ListofRemote;
    public Demo listdemo = new Demo();



    public void add()
    {
        ListofRemote = listdemo.DemoRH();
        ClassRH addrequest = new ClassRH() {id=22, Clinet="GT",Location="fr2",Area="CHICAGO/AURORA" , Case="GTC-11111-1SA35D", Task="RE1PLACE HDD", Details="BROKEN 11HDD", Instruction="REMOVE OLD ADD111NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/31/2022" , "MM/dd/yyyy")};


        

        ListofRemote.Add(addrequest);
        ListofRemote.Add(addrequest);
        //StateHasChanged();


    }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
