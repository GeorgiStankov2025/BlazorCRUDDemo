using Microsoft.AspNetCore.Components.Web;

namespace BlazorCRUDDemo.RenderModes
{
    public class CustomRenderModes
    {

        public static readonly InteractiveAutoRenderMode InteractiveAutoRenderModeNoPreRender
       = new InteractiveAutoRenderMode(prerender: false);
        public static readonly InteractiveServerRenderMode InteractiveServerRenderModeNoPreRender
            = new InteractiveServerRenderMode(prerender: false);
        public static readonly InteractiveWebAssemblyRenderMode InteractiveWebAssemblyRenderModeNoPreRender
            = new InteractiveWebAssemblyRenderMode(prerender: false);

    }
}
