#pragma checksum "C:\Users\edcha\source\repos\BlazeDown\DownloadComponents\DownloadButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c10df76ad54a9a9272c050a455322a28a902c6"
// <auto-generated/>
#pragma warning disable 1591
namespace DownloadComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.JSInterop;
    public class DownloadButton : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "a");
            builder.AddAttribute(1, "role", "button");
            builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(OnClicked));
            builder.AddAttribute(3, "class", "ec-btn ec-btn-download");
            builder.AddContent(4, ChildContent);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "C:\Users\edcha\source\repos\BlazeDown\DownloadComponents\DownloadButton.cshtml"
            

    private void OnClicked(UIMouseEventArgs e) => JSRuntime.Current.InvokeAsync<string>("msSaveBlob", Payload, FileName);

    // Content output between <a> child content </a>
    [Parameter] RenderFragment ChildContent { get; set; }

    /// <summary>
    /// Gets or Sets the data to be downloaded by the client.
    /// </summary>
    [Parameter] string Payload { get; set; }

    /// <summary>
    /// Gets or Sets the specified file name.
    /// </summary>
    [Parameter] string FileName { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
