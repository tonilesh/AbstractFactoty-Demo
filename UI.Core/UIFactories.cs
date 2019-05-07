using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using UI.Default;

namespace UI.Core
{
    public class UIFactories
    {
        public static UIFactory CreateFactory()
        {
            try 
	        {	        
		        string skin=ConfigurationManager.AppSettings["skin"];
                    string skinDllPath=string.Format("{0}\\Skins\\{1}.dll",
                                                    AppDomain.CurrentDomain.BaseDirectory,
                                                    skin);

                    Assembly asm=Assembly.LoadFile(skinDllPath);

                    return CreateFactory(asm);
	        }
	        catch (Exception)
	        {

                return new DefaultFactory();
	        }
            
        }

        public static UIFactory CreateFactory(Assembly asm)
        {
            Type uiFactory=typeof(UIFactory);
 	        foreach(Type t in asm.GetTypes())
            {
                if( uiFactory.IsAssignableFrom(t))
                    return (UIFactory) Activator.CreateInstance(t);
            }

            throw new NotSupportedException("This assembly is not a valid skin");
        }
    }
}
