using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Core
{
    public abstract class UIFactory
    {
        public abstract UIForm CreateForm();
        public abstract UIPanel CreatePanel();
        public abstract UITextBox CreateTextBox();
        public abstract UIButton CreateButton();        
    }


}
