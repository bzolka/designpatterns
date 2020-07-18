using System;

namespace DesPattCode.AbstractFactory
{
    class Program
    {
        // Demonstrálja az abstract factory használatát.
        static void Main(string[] args)
        {
            Client3_UsingAbstractFactory client = new Client3_UsingAbstractFactory();
            GUIFactory factory;

            // Konfiguráljuk fel a klienst egy adott factory objektummal. A kliens
            // ezt fogja használni az GUI objektumainak létrehozásához.
            // Ha Win10 megjelenítést szeretnék:
            factory = new OSXGUIFactory();
            // Ha Presentation Manager megjelenítést szeretnék, akkor csak az előző
            // sort kell megváltoztatni, a ClientUsingFactory osztályhoz nem kell
            // hozzányúlni, az független a témától!
            client.SetFactory(factory);
            client.InitGUIElements();

            // ...
            client.DoSomethingComplex();
            // ...

        }
    }
}
