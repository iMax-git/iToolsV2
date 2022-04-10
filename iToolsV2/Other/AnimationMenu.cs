using System;
using System.Collections.Generic;

namespace iToolsV2.Other
{
    public class AnimationMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;
        private Animation animation;
        private List<Tuple<string,string>> animationList;
        private List<string> animationNameList = new List<string>();
        private int animationIndex;
        public AnimationMenu(Menu menuiTools, FunctionTools Tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = Tools;
        }
        
        public void CreateMenu(object o, EventArgs e)
        {
            if (animation == null)
            {
                animation = new Animation();
                Menu menu = menuiTools.getSubMenu("itools-2-animation");
                animationList = animation.GetAnimations();
                animationList.ForEach((s =>
                {
                    animationNameList.Add(s.Item2);   
                }));
                menu.AddListItem("Liste des animations", animationNameList, (sender, args) =>
                {
                    animation.Start(animationList[args.Index].Item1, animationList[args.Index].Item2);
                    animationIndex = args.Index;
                });
                menu.AddButton("Arreter la scène", (sender, args) =>
                {
                    animation.Stop();
                });
                
                menu.AddSeparator();
                
                menu.AddButton("Copier dans le presse papier l'animation", (sender, args) =>
                {
                    Tools.copyToClipboard($"Package:{animationList[animationIndex].Item1} Animation:{animationList[animationIndex].Item2 }");;
                });
            }
            
        }
    }
}