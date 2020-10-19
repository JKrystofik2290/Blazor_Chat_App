#pragma checksum "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299b28da04bdf6c7e6ec7ef8b2d0705af3bd6dd9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Chat_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Blazor_Chat_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\_Imports.razor"
using Blazor_Chat_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
      

    private HubConnection _hubConnection;
    private string _userName = "";
    private string _msg = "";
    private string _msgFlag = "";
    private List<string[]> _chatMessages = new List<string[]>();
    private List<string> _usersInChat = new List<string>();


    protected override async Task OnInitializedAsync()
    {
        _hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/chat")).Build();

        _hubConnection.On<string, string, string>("ReceiveMessage", (user, msg, flag) =>
        {
            string[] formatMsg = { user, msg, flag };
            _chatMessages.Add(formatMsg);
            StateHasChanged();
        });

        _hubConnection.On<List<string>>("ReceiveUserList", (userList) =>
        {
            _usersInChat = userList;

            StateHasChanged();
        });

        await _hubConnection.StartAsync();
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await GetUserList();
            await JSRuntime.InvokeVoidAsync("ShowPopup");
        }
    }


    public bool IsConnected => _hubConnection.State == HubConnectionState.Connected;


    private void SendMsg()
    {
        _hubConnection.SendAsync("SendMsg", _userName, _msg, _msgFlag);
        _msg = "";
    }


    private Task GetUserList() => _hubConnection.SendAsync("SendUserList");


    private Task SendNewUser() => _hubConnection.SendAsync("SendNewUser", _userName);


    private Task RemoveUser() => _hubConnection.SendAsync("RemoveUser", _userName);


    private async void NewUserJoined()
    {
        await JSRuntime.InvokeVoidAsync("HidePopup");
        await GetUserList();
        bool sameName = _usersInChat.Contains(_userName);

        if (sameName)
        {
            int count = 1;
            while (sameName)
            {
                _userName = $"{_userName}({count})";
                sameName = _usersInChat.Contains(_userName);
                count++;
            }
        }

        await SendNewUser();
        _msgFlag = "joined";
        SendMsg();
        _msgFlag = "";
    }


    public void Dispose()
    {
        RemoveUser();
        _msgFlag = "left";
        SendMsg();
        _msgFlag = "";
    }


    private void SendMsgKeyboardHandler(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            SendMsg();
            _msg = "";
        }
    }


    private void NewUserKeyboardHandler(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            NewUserJoined();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
