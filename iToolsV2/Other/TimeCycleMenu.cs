using System;
using LemonUI.Menus;

namespace iToolsV2.Other
{
    public class TimeCycleMenu
    {
        
        private Menu menuiTools;
        private FunctionTools Tools;
        private TimeCycle timeCycle;
        private String currentTC;
        
        private NativeItem timeCycleStrength;
        
        public TimeCycleMenu(Menu menuiTools, FunctionTools Tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = Tools;
        }
        
        public void CreateMenu(object s,EventArgs e)
        {
            if (timeCycle == null)
            {
                timeCycle = new TimeCycle();
                Menu menu = menuiTools.getSubMenu("itools-2-timecycle");
                menu.AddSeparator();
                menu.AddListItem("TimeCycle", timeCycle.getTimeCycles(), (sender, args) =>
                {
                    timeCycle.loadTimeCycle(args.Object);
                    currentTC = args.Object.ToString();
                });

                timeCycleStrength = menu.AddButtonValue("Changer la force", $"{timeCycle.getStrength()}", (sender, args) =>
                {
                    Tools.GetInput((String force) =>
                    {
                        float number = 0;
                        float.TryParse(force, out number);
                        timeCycle.setStrength(number);
                        timeCycleStrength.AltTitle = $"{timeCycle.getStrength()}";
                    });
                });
                
                menu.AddSeparator();
            
                menu.AddButton("Enlever le TimeCycle", (sender, args) =>
                {
                    timeCycle.ClearTimeCycle();
                });
                
                menu.AddSeparator();
                
                menu.AddButton("Copier dans le presse papier en Lua", (sender, args) =>
                {
                    String lua = $"SetTimecycleModifier('{currentTC}'); \n" +
                                 $"SetTimecycleModifierStrength({timeCycle.getStrength()});";
                    Tools.copyToClipboard(lua);
                });
                
                menu.AddButton("Copier dans le presse papier en C#", (sender, args) =>
                {
                    String csharp = $"API.SetTimecycleModifier('{currentTC}'); \n" +
                                    $"API.SetTimecycleModifierStrength({timeCycle.getStrength()}f);";
                    Tools.copyToClipboard(csharp);
                });
                
            } else
            {
                timeCycle.ClearTimeCycle();
            }
            
        }
        
    }
}