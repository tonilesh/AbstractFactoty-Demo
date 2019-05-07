using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core;

namespace UI.Glass
{
    public class GlassForm : UIForm { }
    public class GlassPanel : UIPanel { }
    public class GlassButton : UIButton { }
    public class GlassTextBox : UITextBox { }

    public class GlassFactory : UIFactory
    {
        public override UIForm CreateForm()
        {
            return new GlassForm();
        }

        public override UIPanel CreatePanel()
        {
            return new GlassPanel();
        }

        public override UITextBox CreateTextBox()
        {
            return new GlassTextBox();
        }

        public override UIButton CreateButton()
        {
            return new GlassButton();
        }
    }
    
}
