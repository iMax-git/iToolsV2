extern alias FX;
using System;
using System.Collections.Generic;
using FX::CitizenFX.Core;
using LemonUI.Menus;

namespace iToolsV2
{
    public class BlipRadiusMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;

        private BlipRadius blip;

        private List<int> colorList = new List<int>();
        
        private NativeItem xButton;
        private NativeItem yButton;
        private NativeItem zButton;
        private NativeItem radiusButton;
        
        private NativeItem alphaButton;

        public BlipRadiusMenu(Menu mainmenu, FunctionTools Tools)
        {
            for (int i = 1; i <= 85; i++)
            {
                colorList.Add(i);
            }

            this.menuiTools = mainmenu;
            this.Tools = Tools;
        }

        public void CreateBlip(object sender, EventArgs e)
        {
            Vector3 pos = Game.PlayerPed.Position;
            if (blip is null)
            {
                blip = new BlipRadius(pos.X,pos.Y,pos.Z,10);    
                Menu menu = menuiTools.getSubMenu("itools-2-blipradius");   
                menu.AddSeparator();
                menu.AddListItem("Changer la couleur du blip: ", colorList, setColor);
                alphaButton = menu.AddButtonValue("Changer la valeur Alpha", $"{blip.GetAlpha()}", setAlpha);
                menu.AddSeparator();
                xButton = menu.AddButtonValue("Changer la position X", $"{blip.GetX()}", setX);
                yButton = menu.AddButtonValue("Changer la position Y", $"{blip.GetY()}", setY);
                zButton = menu.AddButtonValue("Changer la position Z", $"{blip.GetZ()}", setZ);
                menu.AddSeparator();
                radiusButton = menu.AddButtonValue("Changer le rayon", $"{blip.GetRadius()}", setRadius);
                menu.AddSeparator();
                menu.AddButton("Copier dans le presse papier en Lua", copyLua);
                menu.AddButton("Copier dans le presse papier en C#", copyCS);
                menu.AddSeparator();
                menu.AddButton("Supprimer le blip", deleteBlip);
            } else
            {
                Vector3 pos2 = Game.PlayerPed.Position;
                blip.SetX(pos2.X);
                blip.SetY(pos2.Y);
                blip.SetZ(pos2.Z);
            }
        }
        
        public void setColor(object sender, ItemChangedEventArgs<int> e)=>blip.SetColor(e.Object);
        
        private void setX(object sender, EventArgs e) => Tools.GetInput(setXPos);
        
        private void setXPos(string input)
        {
            if (isFloat(input))
            {
                blip.SetX(float.Parse(input));
                xButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Float requis)");
            }
        }
        
        private void setY(object sender, EventArgs e) => Tools.GetInput(setYPos);
        
        private void setYPos(string input)
        {
            if (isFloat(input))
            {
                blip.SetY(float.Parse(input));
                yButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Float requis)");
            }
        }
        
        private void setZ(object sender, EventArgs e) => Tools.GetInput(setZPos);
        
        private void setZPos(string input)
        {
            if (isFloat(input))
            {
                blip.SetZ(float.Parse(input));
                zButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Float requis)");
            }
        }
        
        private void setRadius(object sender, EventArgs e) => Tools.GetInput(setRadiusPos);
        
        private void setRadiusPos(string input)
        {
            if (isFloat(input))
            {
                blip.SetRadius(float.Parse(input));
                radiusButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Float requis)");
            }
        }
        
        private void setAlpha(object s, EventArgs e) => Tools.GetInput(setAlphaPos);
        
        private void setAlphaPos(string input)
        {
            if (isInt(input))
            {
                blip.SetAlpha(int.Parse(input));
                alphaButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Integer requis)");
            }
        }
        
        
        private void copyLua(object sender, EventArgs e) => Tools.copyToClipboard(blip.toStringLua());
        
        private void copyCS(object sender, EventArgs e) => Tools.copyToClipboard(blip.toStringCS());

        private void deleteBlip(object sender, EventArgs e) => blip.DeleteBlip();
        
        
        
        
        
        private bool isFloat(string s)
        {
            float f;
            return float.TryParse(s, out f);
        }

        private bool isInt(string s)
        {
            int i;
            return int.TryParse(s, out i);
        }
    }
}