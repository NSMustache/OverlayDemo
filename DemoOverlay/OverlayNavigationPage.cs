using Xamarin.Forms;

namespace DemoOverlay
{
    public class OverlayNavigationPage : NavigationPage
    {
        public OverlayNavigationPage()
        {
        }

        public OverlayNavigationPage(Page root) : base(root)
        {
        }

        /// <summary>
        /// This is the control that I want to display over the navigation page
        /// </summary>
        public OverlayControl Overlay { get; } = new OverlayControl();
    }
}