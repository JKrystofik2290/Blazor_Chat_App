#pragma checksum "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f43624158f70ecbc464fe7a361e858baef6142e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade");
            __builder.AddAttribute(2, "id", "getUsername");
            __builder.AddAttribute(3, "data-backdrop", "static");
            __builder.AddAttribute(4, "data-keyboard", "false");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "aria-labelledby", "staticBackdropLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<div class=\"modal-header\">\r\n                <h5 class=\"modal-title\" id=\"staticBackdropLabel\">Welcome To My Blazor Chat App!</h5>\r\n            </div>\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-body");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddMarkupContent(19, "<label>Choose A Username:</label>\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                     _userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _userName = __value, _userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-footer");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                        NewUserJoined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "data-dismiss", "modal");
            __builder.AddAttribute(35, "disabled", 
#nullable restore
#line 19 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                                                        !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, "Join Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.AddMarkupContent(42, "<div class=\"title\"><h1>Blazor Chat App</h1></div>\r\n\r\n<hr>\r\n");
            __builder.OpenElement(43, "h3");
            __builder.AddContent(44, "Your Username is: ");
            __builder.AddContent(45, 
#nullable restore
#line 28 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                       _userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n<hr>\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "userlist");
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<h3>Users In Chat:</h3>\r\n    ");
            __builder.OpenElement(51, "ul");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 34 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
         foreach (string user in _usersInChat)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.OpenElement(54, "li");
            __builder.AddContent(55, 
#nullable restore
#line 36 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                 user

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 37 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "chatbox");
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.AddMarkupContent(63, "<h3>Messages:</h3>\r\n    ");
            __builder.OpenElement(64, "ul");
            __builder.AddAttribute(65, "class", "messageList");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 46 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
         foreach (string[] chatMsg in _chatMessages)
        {
            if (chatMsg[2] == "joined")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.OpenElement(68, "li");
            __builder.AddAttribute(69, "class", "joinedMsg");
            __builder.AddContent(70, 
#nullable restore
#line 50 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                       chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " Has Joined The Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 51 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
            }
            else if (chatMsg[2] == "left")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                ");
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "class", "leftMsg");
            __builder.AddContent(76, 
#nullable restore
#line 54 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                     chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " Has Left The Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 55 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
            }
            else
            {
                if (chatMsg[0] == _userName)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                    ");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "class", "sentMsg");
            __builder.AddContent(82, 
#nullable restore
#line 60 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                         chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, " : ");
            __builder.AddContent(84, 
#nullable restore
#line 60 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                       chatMsg[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 61 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                    ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "recMsg");
            __builder.AddContent(89, 
#nullable restore
#line 64 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                        chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " : ");
            __builder.AddContent(91, 
#nullable restore
#line 64 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                      chatMsg[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 65 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                }
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-md-4");
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group");
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenElement(105, "label");
            __builder.AddMarkupContent(106, "\r\n                Message: ");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "type", "text");
            __builder.AddAttribute(109, "class", "form-control");
            __builder.AddAttribute(110, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                             KeyBoardEventHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                                                _msg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _msg = __value, _msg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                          SendMsg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                               KeyBoardEventHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "disabled", 
#nullable restore
#line 78 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                 !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(120, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
      

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
            await JSRuntime.InvokeVoidAsync("popup");
        }
    }


    public bool IsConnected => _hubConnection.State == HubConnectionState.Connected;


    private void SendMsg()
    {
        _hubConnection.SendAsync("SendMsg", _userName, _msg, _msgFlag);
        _msg = "";
    }

    Task GetUserList() => _hubConnection.SendAsync("SendUserList");

    Task SendNewUser() => _hubConnection.SendAsync("SendNewUser", _userName);

    Task RemoveUser() => _hubConnection.SendAsync("RemoveUser", _userName);


    private void KeyBoardEventHandler(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            SendMsg();
            _msg = "";
        }
    }

    private void NewUserJoined()
    {
        GetUserList();
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

        SendNewUser();
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
