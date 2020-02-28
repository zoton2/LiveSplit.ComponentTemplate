using System;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public class Factory : IComponentFactory
    {
        public string ComponentName => "Component Template";

        public string Description => "Component template description.";

        public ComponentCategory Category => ComponentCategory.Other;

        public string UpdateName => ComponentName;

        public string XMLURL => "URL_HERE";

        public string UpdateURL => "URL_HERE";

        public Version Version => Version.Parse("1.0.0");

        public IComponent Create(LiveSplitState state) => new MyComponent(state);
    }
}
