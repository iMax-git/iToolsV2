using System;
using System.Collections.Generic;

namespace iToolsV2.Other
{
    public class CutSceneMenu
    {
        
        private Menu menuiTools;
        private FunctionTools Tools;
        private CutScene cutScene;
        private List<string> CutSceneList;
        private String CutSceneName="";
        public CutSceneMenu(Menu menuiTools, FunctionTools Tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = Tools;
        }

        public void CreateMenu(object o, EventArgs e)
        {
            if (cutScene == null)
            {
                cutScene = new CutScene();
                Menu menu = menuiTools.getSubMenu("itools-2-cutscene");
                CutSceneList = cutScene.GetCutSceneList();
                menu.AddListItem("Liste des scènes", CutSceneList, (sender, args) =>
                {
                    cutScene.Stop();
                    cutScene.Play(args.Object);   
                    CutSceneName = args.Object;
                });
                menu.AddButton("Arreter la scène", (sender, args) =>
                {
                    cutScene.Stop();
                });
                
                menu.AddSeparator();
                
                menu.AddButton("Copier dans le presse papier la cutscene", (sender, args) =>
                {
                    Tools.copyToClipboard($"{CutSceneName}");;
                });
            }
            
        }
    }
}