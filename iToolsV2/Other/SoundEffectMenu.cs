extern alias FX;
using System;
using System.Collections.Generic;
using FX::CitizenFX.Core;

namespace iToolsV2.Other
{
    public class SoundEffectMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;
        private SoundEffect soundEffect;
        private List<String> soundnames = new List<string>();
        private List<Tuple<string,string>> sounds   = new List<Tuple<string,string>>();
        private int selected = 0;

        public SoundEffectMenu(Menu menuiTools, FunctionTools Tools)
        {
            this.menuiTools = menuiTools;
            this.Tools = Tools;
            
            
        }

        public void CreateMenu(object s,EventArgs e)
        {
            if(soundEffect == null)
            {
                soundEffect = new SoundEffect();
                sounds = soundEffect.getSounds();
                sounds.ForEach(tuple =>
                {
                    soundnames.Add(tuple.Item1);
                } );
                Menu menu = menuiTools.getSubMenu("itools-2-soundeffect");
                menu.AddSeparator();
                menu.AddListItem("Liste des sons: ", soundnames, (sender, args) =>
                {
                    soundEffect.playSound(sounds[args.Index].Item1, sounds[args.Index].Item2);
                    selected = args.Index;
                });
                menu.AddButton("Stop Sound", (sender, args) =>
                {
                    soundEffect.stopSound();
                });
                menu.AddSeparator();
                menu.AddButton("Copier dans le presse papier en Lua", (sender, args) =>
                {
                    Tools.copyToClipboard($"PlaySoundFrontend(-1,\"{sounds[selected].Item1}\", \"{sounds[selected].Item2}\", true)");
                });
                menu.AddButton("Copier dans le presse papier en C#", (sender, args) =>
                {
                    Tools.copyToClipboard($"API.PlaySoundFromEntity(-1,\"{sounds[selected].Item1}\", {sounds[selected].Item2}, true)");
                });
            }
            
        }
        
    }
}