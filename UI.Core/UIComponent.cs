using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Core
{
    public abstract class UIComponent
    {
        public void Show()
        {
            Draw("");
        }

        public virtual void Draw(Object context)
        {
            string indent = context as string;
            Console.WriteLine("{0} {1} drawn",indent,this.GetType().Name);
        }
    }

    public abstract class UIContainer : UIComponent
    {
        List<UIComponent> components = new List<UIComponent>();
        public void Add(UIComponent component)
        {
            components.Add(component);
        }

        public override void Draw(object context)
        {
            string indent = context as string;
            base.Draw(indent);
            indent=indent+"\t";
            foreach (UIComponent component in components)
                component.Draw(indent);

         }

    }

    public abstract class UIForm : UIContainer { }
    public abstract class UIPanel : UIContainer { }

    public abstract class UIButton : UIComponent { }
    public abstract class UITextBox : UIComponent { }


}
