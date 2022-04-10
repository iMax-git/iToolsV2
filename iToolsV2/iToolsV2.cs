extern alias FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;
using iToolsV2.Other;
using LemonUI;
using LemonUI.Menus;

namespace iToolsV2
{
    public class iToolsV2 : BaseScript
    {
        private Menu menuiTools = new Menu("iToolsV2", "Outils pour développer.", 25, 25);
        private FunctionTools functionTools;
        private MarkerMenu Mtools;
        private BlipMenu Btools;
        private BlipRadiusMenu BRtools;
        private BlipAreaMenu BAtools;
        private CameraMenu Ctools;
        private TimeCycleMenu TCtools;
        private SoundEffectMenu SEtools;
        private CutSceneMenu CStools;
        private AnimationMenu Atools;
        private ParticuleMenu Ptools;
        private ScenarioMenu Stools;
        private Marker marker;
        private ObjectPool menuPool;
        private Boolean isAdmin = true;

        public iToolsV2()
        {
            //IList<Config> config = createConfig();
            
            functionTools = new FunctionTools();
            Mtools = new MarkerMenu(menuiTools, functionTools);
            Btools = new BlipMenu(menuiTools, functionTools);
            BRtools = new BlipRadiusMenu(menuiTools, functionTools);
            BAtools = new BlipAreaMenu(menuiTools, functionTools);
            Ctools = new CameraMenu(menuiTools, functionTools);
            TCtools = new TimeCycleMenu(menuiTools, functionTools);
            SEtools = new SoundEffectMenu(menuiTools, functionTools);
            CStools = new CutSceneMenu(menuiTools, functionTools);
            Atools = new AnimationMenu(menuiTools, functionTools);
            Ptools = new ParticuleMenu(menuiTools, functionTools);
            Stools = new ScenarioMenu(menuiTools, functionTools);


            menuiTools.AddButton("📌 Récuperer les coordonées en LUA.", functionTools.GetCoordsLUA);
            menuiTools.AddButton("📌 Récuperer les coordonées en C#.", functionTools.GetCoordsCS);
            
            
            
            menuiTools.AddSeparator();
            
            
            
            MarkerMenu(Mtools);
            
            
            menuiTools.AddSeparator();
            
            
            
            BlipMenu(Btools);
            BlipRadiusMenu(BRtools);
            BlipAreaMenu(BAtools);
            
            
            menuiTools.AddSeparator();
            
            CameraMenu(Ctools);
            
            menuiTools.AddSeparator();
            
            TimeCycleMenu(TCtools);
            SoundEffectMenu(SEtools);
            CutSceneMenu(CStools);
            AnimationMenu(Atools);
            ScenarioMenu(Stools);
            ParticuleMenu(Ptools);
            
            menuiTools.AddSeparator();
            
            CreditButton();
            
            
            
            menuPool = menuiTools.getPool();
            API.RegisterCommand("iTools", new Action<int, List<object>, string>((source, args, rawCommand) =>
             {
                 if (isAdmin)
                 {
                     menuiTools.OpenMenu();
                 }
                 else
                 {
                     Debug.WriteLine("Do 'refreshAdmin' in chat if is maybe an error !");
                 };
             }), false);

            API.RegisterCommand("SetPlace", new Action<int, List<object>, string>((source, args, rawCommand) =>
             {
                 if (isAdmin) { menuiTools.setPosition(int.Parse((string)args[0]), int.Parse((string)args[1])); }
                 else { Debug.WriteLine("Do 'refreshAdmin' in chat if is maybe an error !"); };
             }), false);

            API.RegisterCommand("refreshAdmin", new Action<int, List<object>, string>((source, args, rawCommand) =>
              {
                  if (this.isAdmin) { Debug.WriteLine("You are already login administrator !"); }
                  else
                  {
                      Debug.WriteLine("Refreshing rank !");
                      TriggerServerEvent("iToolsV2:isAdmin");
                  }

              }), false);

            

            TriggerServerEvent("iToolsV2:isAdmin");
            InvokeClientEvent();
            Tick += OnTick;
        }


        

        private void MarkerMenu(MarkerMenu Mtools)
        {
            
            menuiTools.AddSub("itools-2-marker", "📍 Crée un marker.", "Crée un marker.");
            Menu menu = menuiTools.getSubMenu("itools-2-marker");
            menu.AddButton("+ Crée un nouveau marker.", Mtools.CreateMarker);

        }
        
        private void BlipMenu(BlipMenu Btools)
        {
            menuiTools.AddSub("itools-2-blip", "📍 Crée un blip." , "Crée un blip.");
            Menu menu = menuiTools.getSubMenu("itools-2-blip");
            menu.AddButton("+ Crée un nouveau blip.", Btools.CreateBlip);
        }

        private void BlipRadiusMenu(BlipRadiusMenu BRTools)
        {
            menuiTools.AddSub("itools-2-blipradius","📍 Crée un blip avec un rayon." , "Crée un blip avec un rayon.");
            Menu menu = menuiTools.getSubMenu("itools-2-blipradius");
            menu.AddButton("+ Crée un nouveau blip avec un rayon.", BRTools.CreateBlip);
        }

        private void BlipAreaMenu(BlipAreaMenu BATools)
        {
            menuiTools.AddSub("itools-2-bliparea","📍 Crée un blip de zone." , "Crée un blip de zone.");
            Menu menu = menuiTools.getSubMenu("itools-2-bliparea");
            menu.AddButton("+ Crée un nouveau blip de zone.", BATools.CreateBlip);
        }
        
        private void CameraMenu(CameraMenu Ctools)
        {
            menuiTools.AddSub("itools-2-camera", "🎥 Crée une caméra." , "Crée une caméra.");
            Menu menu = menuiTools.getSubMenu("itools-2-camera");
            menu.AddButton("+ Crée une nouvelle caméra.", Ctools.CreateCamera);
        }
        
        private void TimeCycleMenu(TimeCycleMenu TCTools)
        {
            menuiTools.AddSub("itools-2-timecycle", "🕒 Liste des effets de camera." , "Liste des effets de camera.");
            Menu menu = menuiTools.getSubMenu("itools-2-timecycle");
            menu.AddButton("+ Change l'effet de camera.", TCTools.CreateMenu);
        }
        
        private void SoundEffectMenu(SoundEffectMenu SEtools)
        {
            menuiTools.AddSub("itools-2-soundeffect", "🔊 Liste des effets sonores." , "Liste des effets sonores.");
            Menu menu = menuiTools.getSubMenu("itools-2-soundeffect");
            menu.AddButton("+ Joue un effet sonore.", SEtools.CreateMenu);
        }
        
        private void CutSceneMenu(CutSceneMenu CTools)
        {
            menuiTools.AddSub("itools-2-cutscene", "🎥 Liste des cutscenes." , "Liste des cutscenes.");
            Menu menu = menuiTools.getSubMenu("itools-2-cutscene");
            menu.AddButton("+ Lance une cutscene.", CTools.CreateMenu);
        }
        
        private void AnimationMenu(AnimationMenu ATools)
        {
            menuiTools.AddSub("itools-2-animation", "🍾 Liste des animations." , "Liste des animations.");
            Menu menu = menuiTools.getSubMenu("itools-2-animation");
            menu.AddButton("+ Joue une animation.", ATools.CreateMenu);
        }
        
        private void ParticuleMenu(ParticuleMenu PTools)
        {
            menuiTools.AddSub("itools-2-particule", "🎆 Liste des particules." , "Liste des particules.");
            Menu menu = menuiTools.getSubMenu("itools-2-particule");
            menu.AddButton("+ Joue une particule.", PTools.CreateMenu);
        }
        
        private void ScenarioMenu(ScenarioMenu STools)
        {
            menuiTools.AddSub("itools-2-scenario", "▶ Liste des scénarios." , "Liste des scénarios.");
            Menu menu = menuiTools.getSubMenu("itools-2-scenario");
            menu.AddButton("+ Lance un scénario.", STools.CreateMenu);
        }

        private void CreditButton()
        {
            menuiTools.AddButton("💰 Crédit", "Script réalisé par iMax.\nVendu par adns-tech.fr.");
        }

        //private void IsAdministrator(Boolean isAdmin){this.isAdmin = isAdmin;}

        public void InvokeClientEvent()
        {
            //EventHandlers["iToolsV2-Client:IsAdmin"] += new Action<bool>(IsAdministrator);
            Debug.WriteLine("😎 Client Event Invoked 🥳");
        }
        
        /*
        public IList<Config> createConfig()
        {

            IList<Config> configs = new List<Config>();
            JsonTextReader reader = new JsonTextReader(new StringReader(API.LoadResourceFile("iToolsV2", "Config.json")));
            reader.SupportMultipleContent = true;

            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }

                JsonSerializer serializer = new JsonSerializer();
                Config config = serializer.Deserialize<Config>(reader);

                configs.Add(config);
            }

            return configs;
        }

    */

        private async Task OnTick()
        {
            menuPool.Process();
            //await Delay(500);
            marker = Mtools.getMarker();
            if (!(marker is null) && marker.loopIsActive())
            {
                marker.loop();
            }
        }

    }

    
}
