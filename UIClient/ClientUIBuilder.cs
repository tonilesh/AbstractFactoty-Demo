using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core;

namespace UIClient
{
    class ClientUIBuilder
    {
        public UIComponent BuildUI(UIFactory factory)
        {
            UIForm frm = factory.CreateForm();

            UIPanel p1 = factory.CreatePanel();
            p1.Add(factory.CreateTextBox());
            p1.Add(factory.CreateTextBox());
            p1.Add(factory.CreateButton());

            UIPanel p2 = factory.CreatePanel();
            p2.Add(factory.CreateButton());
            p2.Add(factory.CreateButton());

            UIPanel p3 = factory.CreatePanel();
            p3.Add(p1);
            p3.Add(p2);

            frm.Add(p3);
            frm.Add(factory.CreateButton());

            return frm;
        }
    }
}
