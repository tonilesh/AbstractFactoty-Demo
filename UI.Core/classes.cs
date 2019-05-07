using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core;

namespace UI.Default
{
    public class DefaultForm : UIForm { }
    public class DefaultPanel : UIPanel { }
    public class DefaultButton : UIButton { }
    public class DefaultTextBox : UITextBox { }

    public class DefaultFactory : UIFactory
    {
        public override UIForm CreateForm()
        {
            return new DefaultForm();
        }

        public override UIPanel CreatePanel()
        {
            return new DefaultPanel();
        }

        public override UITextBox CreateTextBox()
        {
            return new DefaultTextBox();
        }

        public override UIButton CreateButton()
        {
            return new DefaultButton();
        }
    }
    
}
