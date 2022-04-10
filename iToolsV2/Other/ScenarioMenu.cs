using System;
using System.Collections.Generic;

namespace iToolsV2.Other
{
    public class ScenarioMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;
        private Scenario scenario;
        private List<string> Pliste;
        private String currentScenario = "Standing";

        public ScenarioMenu(Menu menuiTools, FunctionTools tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = tools;
        }

        public void CreateMenu(object o, EventArgs e)
        {
            if (scenario == null)
            {
                scenario = new Scenario();
                Menu menu = menuiTools.getSubMenu("itools-2-scenario");
                Pliste = scenario.GetScenarios();
                menu.AddListItem("Liste des particles", Pliste, (sender, args) =>
                {
                    scenario.Stop();
                    scenario.Start(args.Object);
                    currentScenario = args.Object;
                });
                
                menu.AddButton("Stop", (sender, args) =>
                {
                    scenario.Stop();
                });
                
                menu.AddSeparator();
                
                menu.AddButton("Copier dans le presse papier en C#", (sender, args) =>
                {
                    Tools.copyToClipboard($"API.TaskStartScenarioInPlace(API.PlayerPedId(),'{currentScenario}',-1,false);");;
                });
                menu.AddButton("Copier dans le presse papier en Lua", (sender, args) =>
                {
                    Tools.copyToClipboard($"TaskStartScenarioInPlace(PlayerPedId(),'{currentScenario}',-1,false);");;
                });
            }
            
        }
    }
}