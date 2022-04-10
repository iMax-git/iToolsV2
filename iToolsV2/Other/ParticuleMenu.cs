using System;
using System.Collections.Generic;

namespace iToolsV2.Other
{
    public class ParticuleMenu
    {
        
        private Menu menuiTools;
        private FunctionTools Tools;
        private Particule particule;
        private List<Tuple<string,string>> Pliste;
        private List<string> Pliste2 = new List<string>();
        private int index = 0;

        public ParticuleMenu(Menu menuiTools, FunctionTools tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = tools;
        }

        public void CreateMenu(object o, EventArgs e)
        {
            if (particule == null)
            {
                particule = new Particule();
                Menu menu = menuiTools.getSubMenu("itools-2-particule");
                Pliste = particule.GetParticules();
                Pliste.ForEach((tuple =>
                {
                    Pliste2.Add(tuple.Item2);
                }));
                menu.AddListItem("Liste des particles", Pliste2, (sender, args) =>
                {
                    particule.Stop();
                    particule.Play(Pliste[args.Index].Item1, Pliste[args.Index].Item2);   
                    index = args.Index;
                });
                
                menu.AddButton("Stop", (sender, args) =>
                {
                    particule.Stop();
                });
                
                menu.AddSeparator();
                
                menu.AddButton("Copier dans le presse papier la particule", (sender, args) =>
                {
                    Tools.copyToClipboard($"Package: {Pliste[index].Item1} Particule: {Pliste[index].Item2}");;
                });
            }
            
        }
    }
}