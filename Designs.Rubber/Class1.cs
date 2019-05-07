using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core; 

namespace Compserv.Designs.Rubber
{
    public class RubberForm : UIForm { }
    public class RubberPanel : UIPanel { }
    public class RubberButton : UIButton { }
    public class RubberTextBox : UITextBox { }

    public class RubberFactory : UIFactory
    {
        public override UIForm CreateForm()
        {
            return new RubberForm();
        }

        public override UIPanel CreatePanel()
        {
            return new RubberPanel();
        }

        public override UITextBox CreateTextBox()
        {
            return new RubberTextBox();
        }

        public override UIButton CreateButton()
        {
            return new RubberButton();
        }
    }
}
