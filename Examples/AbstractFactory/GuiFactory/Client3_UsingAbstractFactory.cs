using System;
using System.Collections.Generic;
using System.Text;

namespace DesPattCode.AbstractFactory
{
    // Ez már egy olyan kliens implementáció, mely teljesen független 
    // a témáktól (a témák implementációs osztályaitól), nincs benne
    // téma specifikus kód/osztály:
    // 1. A GUI elemekre csak a közös interfészükön/ősosztályukon 
    // keresztül hivatkozik.
    // 2. A GUI elemek létrehozására a téma független factory interfészt 
    // használja és nem a new operátort.
    // Az osztálynak a SetFactory művelet segítségével át kell adni egy
    // factory implementációt (Win10GUIFactory-t vagy OSXGUIFactory-t),
    // amit a factory nevű tagváltozóban eltárol. A GUI elemek létrehozására
    // az InitWidgets műveletben ezt a factory-t használja az osztály a
    // new operátor helyett.
    // A ClientUsingFactory használatára alább a DemoClientUsage osztály 
    // mutat példát.
    // Ellenőrizzük le a szemünkkel, hogy a ClientUsingFactory osztályban
    // semmi téma specifikus kód/osztály nincs.
    class Client3_UsingAbstractFactory
    {
        // UI elemek
        private Window wnd;
        private Button button;
        // ...
        // Factory interfész, ezt használja majd a kliens a GUI elemek 
        // létrehozásához.
        private GUIFactory factory;

        public void SetFactory(GUIFactory fy)
        {
            factory = fy;
        }

        public void InitGUIElements()
        {
            wnd = factory.CreateWindow();
            button = factory.CreateButton();
            //...
        }

        public void DoSomethingComplex()
        {
            // Demonstráljuk a GUI elemek kirajzolását:
            wnd.Show();
            wnd.Paint();
            button.Paint();
            //...
        }
    }

}
