extern alias FX;

using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace iToolsV2
{
    public class FunctionTools : BaseScript
    {
        public FunctionTools()
        {
        }
        
        private String keyboardResult = "";

        
        private async Task WaitLoaded(Action cb)
        {
            /*
            while (!API.HasCutsceneLoaded())
            {
                await Task.Delay(100);
                API.Wait(100);
            }
            */
            await Delay(10);
            API.Wait(100);
            cb();
        }

        public void WaitAndPlayCutScene(Action cb)
        {
            Task task = WaitLoaded(new Action(cb));
        }

        private async Task WaitAnimation(String package,Action cb)
        {
            while (!API.HasAnimDictLoaded(package))
            {
                await Delay(100);
            }
            cb();
        }
        
        public void WaitAnimationAndPlay(String package,Action cb)
        {
            Task task = WaitAnimation(package,new Action(cb));
        }

        private async Task WaitParticule(String package, Action cb)
        {
            while (!API.HasNamedPtfxAssetLoaded(package))
            {
                await Delay(100);
            }
            cb();
        }
        
        public void WaitParticuleAndPlay(String package, Action cb)
        {
            Task task = WaitParticule(package,new Action(cb));
        }

        /**
         * <summary>
         * Fnc KeyboardInput
         * @arg cb -> Fonction myFnc(String args1)
         * At the end exec cb.
         * </summary> 
         */
        public async Task KeyboardStringInput(Action<string> cb)
        {
            API.AddTextEntry("FMMC_KEY_TIP1", "Entrez un flotant: (Exemple: 0.0 , 1.5596, 2.0)");
            API.DisplayOnscreenKeyboard(1, "FMMC_KEY_TIP1", "", "", "", "", "", 60);
            while (!(API.UpdateOnscreenKeyboard() == 1) && !(API.UpdateOnscreenKeyboard() == 2))
            {
                await Delay(100);
            }
            if (!(API.UpdateOnscreenKeyboard() == 2))
            {
                keyboardResult = API.GetOnscreenKeyboardResult();
                await Delay(100);
                cb(keyboardResult);
            }
            else
            {
                await Delay(100);
                keyboardResult = null;
            }
        }


        public void GetInput(Action<string> fnc) { Task input = KeyboardStringInput(new Action<string>(fnc)); }
        public void GetCoordsLUA(object sender, EventArgs e)
        {
            Vector3 coords = API.GetEntityCoords(API.PlayerPedId(), true);
            copyToClipboard($"vector3({coords.X}, {coords.Y}, {coords.Z})");
        }
        public void GetCoordsCS(object sender, EventArgs e)
        {
            Vector3 coords = API.GetEntityCoords(API.PlayerPedId(), true);
            copyToClipboard($"Vector3 coords = new Vector3({coords.X}, {coords.Y}, {coords.Z});");
        }

        public void copyToClipboard(String text)
        {
            SettingCopyToClipboard sting = new SettingCopyToClipboard();
            sting.text = text;
            sting.type = "copy";
            string json = JsonConvert.SerializeObject(sting);
            API.SendNuiMessage(json);
        }
        
    }
    
    class SettingCopyToClipboard
    {
        public string type { get; set; }
        public string text { get; set; }
    }
}
