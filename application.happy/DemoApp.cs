using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace application.happy
{
    [ProgId("App.Demo.Activex.Happy")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("F10CA919-2F40-4F6D-BA0E-FF5778539868")]
    [ComVisible(true)]
    public class DemoApp
    {
        [ComVisible(true)]
        public String SayHappy() {
            return "Happy";
        }
    }
}
