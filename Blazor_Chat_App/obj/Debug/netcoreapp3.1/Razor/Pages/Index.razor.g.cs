#pragma checksum "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02454297fac3bd4cdfb9ba95210b168a910110fd"
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
            __builder.AddAttribute(22, "class", "form-control w-100");
            __builder.AddAttribute(23, "maxlength", "12");
            __builder.AddAttribute(24, "onkeyup", "this.value = this.value.replace(/[,]/, \'\')");
            __builder.AddAttribute(25, "onkeydown", "this.value = this.value.replace(/[,]/, \'\')");
            __builder.AddAttribute(26, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                    NewUserKeyboardHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "data-toggle", "tooltip");
            __builder.AddAttribute(28, "data-placement", "top");
            __builder.AddAttribute(29, "title", "Max length 12 & no commas");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                         _userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _userName = __value, _userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-footer");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                        NewUserJoined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                                   NewUserKeyboardHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "disabled", 
#nullable restore
#line 24 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(43, "Join Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "header");
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.AddMarkupContent(52, "<h1>Blazor Chat App</h1>\r\n    ");
            __builder.OpenElement(53, "h4");
            __builder.AddContent(54, "You are: ");
            __builder.AddContent(55, 
#nullable restore
#line 32 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                  _userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "chat");
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "chatBox");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "ul");
            __builder.AddAttribute(65, "class", "chatList");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 38 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
             foreach (string[] chatMsg in _chatMessages)
            {
                if (chatMsg[2] == "joined")
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                    ");
            __builder.OpenElement(68, "li");
            __builder.AddAttribute(69, "class", "joinedMsg");
            __builder.AddContent(70, 
#nullable restore
#line 42 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                           chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " Has Joined The Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 43 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                }
                else if (chatMsg[2] == "left")
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                    ");
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "class", "leftMsg");
            __builder.AddContent(76, 
#nullable restore
#line 46 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                         chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " Has Left The Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 47 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                }
                else
                {
                    if (chatMsg[0] == _userName)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                        ");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "class", "sentMsg");
            __builder.AddContent(82, 
#nullable restore
#line 52 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                             chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, " : ");
            __builder.AddContent(84, 
#nullable restore
#line 52 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                           chatMsg[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 53 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                        ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "recMsg");
            __builder.AddContent(89, 
#nullable restore
#line 56 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                            chatMsg[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " : ");
            __builder.AddContent(91, 
#nullable restore
#line 56 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                          chatMsg[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 57 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "userList");
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.AddMarkupContent(99, "<h4>In Chat:</h4>\r\n        ");
            __builder.OpenElement(100, "ul");
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 66 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
             foreach (string user in _usersInChat)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                ");
            __builder.OpenElement(103, "li");
            __builder.AddContent(104, 
#nullable restore
#line 68 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                     user

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 69 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "msgbox");
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "class", "form-control");
            __builder.AddAttribute(116, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                        SendMsgKeyboardHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                             _msg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _msg = __value, _msg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.OpenElement(120, "button");
            __builder.AddAttribute(121, "class", "btn btn-primary");
            __builder.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                              SendMsg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                   SendMsgKeyboardHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "disabled", 
#nullable restore
#line 76 "C:\Users\j0029729\Source\Repos\Blazor_Chat_App\Blazor_Chat_App\Pages\Index.razor"
                                                                                                       !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(125, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.CloseElement();
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
            _usersInChat = new List<string>(userList);

            StateHasChanged();
        });

        await _hubConnection.StartAsync();
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
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


    private async Task NewUserJoined()
    {
        await JSRuntime.InvokeVoidAsync("HidePopup");
        await GetUserList();
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


    private async void NewUserKeyboardHandler(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            await NewUserJoined();
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
