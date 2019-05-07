using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core;

namespace UI.Metal
{
    public class MetalForm : UIForm { }
    public class MetalPanel : UIPanel { }
    public class MetalButton : UIButton { }
    public class MetalTextBox : UITextBox { }

    public class MetalFactory : UIFactory
    {
        public override UIForm CreateForm()
        {
            return new MetalForm();
        }

        public override UIPanel CreatePanel()
        {
            return new MetalPanel();
        }

        public override UITextBox CreateTextBox()
        {
            return new MetalTextBox();
        }

        public override UIButton CreateButton()
        {
            return new MetalButton();
        }
    }
    
}
