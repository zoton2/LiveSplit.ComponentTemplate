using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            // do something
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            return parent;
        }

        public void SetSettings(XmlNode settings)
        {
            // do something
        }
    }
}
