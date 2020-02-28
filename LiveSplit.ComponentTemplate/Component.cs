using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    class MyComponent : IComponent
    {
        public bool Initialized { get; private set; } = false;
        public Settings Settings { get; set; }

        public MyComponent(LiveSplitState state)
        {
            Settings = new Settings();
            if (state.LayoutSettings != null)
            {
                Init();
            }
        }

        public void Init()
        {
            // Set up the component here, not in the constructor
            Initialized = true;
        }

        public string ComponentName => "Component Template";

        public float HorizontalWidth => 0;

        public float MinimumHeight => 0;

        public float VerticalHeight => 0;

        public float MinimumWidth => 0;

        public float PaddingTop => 0;

        public float PaddingBottom => 0;

        public float PaddingLeft => 0;

        public float PaddingRight => 0;

        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        public void Dispose()
        {
            // do something
        }

        public int GetSettingsHashCode()
        {
            return Settings.GetSettingsHashCode();
        }

        public void DrawHorizontal(System.Drawing.Graphics g, LiveSplitState state, float height, System.Drawing.Region clipRegion)
        {
            // do something
        }

        public void DrawVertical(System.Drawing.Graphics g, LiveSplitState state, float width, System.Drawing.Region clipRegion)
        {
            // do something
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
            if (!Initialized)
            {
                Init();
            }
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            // do something
        }
    }
}
