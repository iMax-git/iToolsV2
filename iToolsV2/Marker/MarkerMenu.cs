extern alias FX;

using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iToolsV2
{
    class MarkerMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;

        private Marker marker;

        private List<int> types = new List<int>();
        private NativeItem typeButton;
        private NativeItem xButton;
        private NativeItem yButton;
        private NativeItem zButton;
        
        
        private NativeItem dxButton;
        private NativeItem dyButton;
        private NativeItem dzButton;
        
        
        private NativeItem rxButton;
        private NativeItem ryButton;
        private NativeItem rzButton;
        
        
        private NativeItem sxButton;
        private NativeItem syButton;
        private NativeItem szButton;


        private NativeItem redButton;
        private NativeItem greenButton;
        private NativeItem blueButton;
        private NativeItem alphaButton;
        private NativeCheckboxItem bumpButton;
        private NativeCheckboxItem rotateButton;

        public MarkerMenu(Menu mainmenu,FunctionTools Tools)
        {
            menuiTools = mainmenu;
            this.Tools = Tools;

        }

        public void CreateMarker(object sender, EventArgs e)
        {
            Vector3 coords = API.GetEntityCoords(API.PlayerPedId(), true);
            if (marker is null)
            {
                marker = new Marker(0, coords.X, coords.Y, coords.Z, 255, 0, 0, 255, false, false);
                Menu menu = menuiTools.getSubMenu("itools-2-marker");
                menu.AddSeparator();
                for (int i = 0; i < 45; i++) { types.Add(i);  }
                typeButton = menu.AddListItem("Changer le type:", types,setType);
                menu.AddSeparator();
                xButton = menu.AddButtonValue("Changer la valeur de x:", $"{marker.getX()}", setX);
                yButton = menu.AddButtonValue("Changer la valeur de y:", $"{marker.getY()}", setY);
                zButton = menu.AddButtonValue("Changer la valeur de z:", $"{marker.getZ()}", setZ);
                menu.AddSeparator();
                redButton = menu.AddButtonValue("Changer la valeur de Rouge:", $"{marker.getRed()}", setRed);
                greenButton = menu.AddButtonValue("Changer la valeur de Vert:", $"{marker.getGreen()}", setGreen);
                blueButton = menu.AddButtonValue("Changer la valeur de Bleu:", $"{marker.getBlue()}", setBlue);
                alphaButton = menu.AddButtonValue("Changer la valeur Alpha:", $"{marker.getAlpha()}", setAlpha);
                menu.AddSeparator();
                dxButton = menu.AddButtonValue("Changer la valeur de direction x:", $"{marker.getDirX()}", setdX);
                dyButton = menu.AddButtonValue("Changer la valeur de direction y:", $"{marker.getDirY()}", setdY);
                dzButton = menu.AddButtonValue("Changer la valeur de direction z:", $"{marker.getDirZ()}", setdZ);
                menu.AddSeparator();
                rxButton = menu.AddButtonValue("Changer la valeur de rotation x:", $"{marker.getRotX()}", setrX);
                ryButton = menu.AddButtonValue("Changer la valeur de rotation y:", $"{marker.getRotY()}", setrY);
                rzButton = menu.AddButtonValue("Changer la valeur de rotation z:", $"{marker.getRotZ()}", setrZ);
                menu.AddSeparator();
                sxButton = menu.AddButtonValue("Changer la valeur de taille x:", $"{marker.getScaleX()}", setSX);
                syButton = menu.AddButtonValue("Changer la valeur de taille y:", $"{marker.getScaleY()}", setSY);
                szButton = menu.AddButtonValue("Changer la valeur de taille z:", $"{marker.getScaleZ()}", setSZ);
                menu.AddSeparator();
                bumpButton = menu.AddCheckBoxButton("Activer le rebomdissement: ", marker.getBump(), setBump);
                menu.AddSeparator();
                rotateButton = menu.AddCheckBoxButton("Activer la rotation: ", marker.getRotation(), setRotation);
                menu.AddSeparator();
                menu.AddButton("Copier dans le presse papier en Lua.", copyLua);
                menu.AddButton("Copier dans le presse papier en C#.", copyCS);
                menu.AddSeparator();
                menu.AddButton("Supprimer le marker.", StopLoop);
            }
            else
            {
                Reset(coords);
                marker.StartLoop();
            }
            
        }
        private void Reset(Vector3 playerCoords)
        {
            
            
            setXPos($"{playerCoords.X}");
            setYPos($"{playerCoords.Y}");
            setZPos($"{playerCoords.Z}");

            setRedColor("255");
            setGreenColor("0");
            setBlueColor("0");
            setAlphaColor("255");
            
            setrXPos("0.0");
            setrYPos("0.0");
            setrZPos("0.0");
            
            setdXPos("0.0");
            setdYPos("0.0");
            setdZPos("0.0");
            
            setSXPos("0.5");
            setSYPos("0.5");
            setSZPos("0.5");
            

        }
        
        private void setType(object sender,ItemChangedEventArgs<int> type)
        {
            marker.setType(type.Index);
        }
        
        
        
        
        
        

        private void setX(object sender, EventArgs e) { Tools.GetInput(setXPos); }
        private void setXPos(string x)
        {
            if (isFloat(x))
            {
                xButton.AltTitle = $"{x}";
                marker.setX(float.Parse(x));
            }
            else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        private void setY(object sender, EventArgs e) { Tools.GetInput(setYPos); }
        private void setYPos(string y)
        {
            if (isFloat(y))
            {
                yButton.AltTitle = $"{y}";
                marker.setY(float.Parse(y));
            } else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        private void setZ(object sender, EventArgs e) { Tools.GetInput(setZPos); }
        private void setZPos(string z)
        {
            if (isFloat(z))
            {
                zButton.AltTitle = $"{z}";
                marker.setZ(float.Parse(z));
            } else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        
        
        
        
        
        
        
        
        private void setdX(object sender, EventArgs e) { Tools.GetInput(setdXPos); }
        private void setdXPos(string x)
        {
            if (isFloat(x))
            {
                dxButton.AltTitle = $"{x}";
                marker.setDirX(float.Parse(x));
            } else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        private void setdY(object sender, EventArgs e) { Tools.GetInput(setdYPos); }
        private void setdYPos(string y)
        {
            if (isFloat(y))
            {
                dyButton.AltTitle = $"{y}";
                marker.setDirY(float.Parse(y));
            } else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        private void setdZ(object sender, EventArgs e) { Tools.GetInput(setdZPos); }
        private void setdZPos(string z)
        {
            if (isFloat(z))
            {
                dzButton.AltTitle = $"{z}";
                marker.setDirZ(float.Parse(z));
            } else
            {
                Debug.WriteLine("Valeur invalide (Float Input needed");
            }
        }
        
        
        
        
        
        
        
        private void setrX(object sender, EventArgs e) { Tools.GetInput(setrXPos); }
        private void setrXPos(string x)
        {
            if (isFloat(x))
            {
                rxButton.AltTitle = $"{x}";
                marker.setRotX(float.Parse(x));
            }
        }
        private void setrY(object sender, EventArgs e) { Tools.GetInput(setrYPos); }
        private void setrYPos(string y)
        {
            if (isFloat(y))
            {
                ryButton.AltTitle = $"{y}";
                marker.setRotY(float.Parse(y));
            }
        }
        private void setrZ(object sender, EventArgs e) { Tools.GetInput(setrZPos); }
        private void setrZPos(string z)
        {
            if (isFloat(z))
            {
                rzButton.AltTitle = $"{z}";
                marker.setRotZ(float.Parse(z));
            }
        }
        
        
        
        
        
        
        
        private void setSX(object sender, EventArgs e) { Tools.GetInput(setSXPos); }
        private void setSXPos(string x)
        {
            if (isFloat(x))
            {
                sxButton.AltTitle = $"{x}";
                marker.setScaleX(float.Parse(x));
            }
        }
        private void setSY(object sender, EventArgs e) { Tools.GetInput(setSYPos); }
        private void setSYPos(string y)
        {
            if (isFloat(y))
            {
                syButton.AltTitle = $"{y}";
                marker.setScaleY(float.Parse(y));
            }
        }
        private void setSZ(object sender, EventArgs e) { Tools.GetInput(setSZPos); }
        private void setSZPos(string z)
        {
            if (isFloat(z))
            {
                szButton.AltTitle = $"{z}";
                marker.setScaleZ(float.Parse(z));
            }
        }
        
        
        
        
        
        

        private void setRed(object sender, EventArgs e) { Tools.GetInput(setRedColor); }
        private void setRedColor(string red)
        {
            if (isFloat(red) && int.Parse(red) <= 255 && int.Parse(red) >= 0)
            {
                redButton.AltTitle = $"{red}";
                marker.setRed(int.Parse(red));
            }
            else
            {
                Debug.WriteLine("Valeur invalide (Entier entre 0-255)");
            }
        }
        private void setGreen(object sender, EventArgs e) { Tools.GetInput(setGreenColor); }
        private void setGreenColor(string green)
        {
            if(isFloat(green) && int.Parse(green) <= 255 && int.Parse(green) >= 0)
            {
                greenButton.AltTitle = $"{green}";
                marker.setGreen(int.Parse(green));
            }
            else
            {
                Debug.WriteLine("Valeur invalide (Entier entre 0-255)");
            }
        }
        private void setBlue(object sender, EventArgs e) { Tools.GetInput(setBlueColor); }
        private void setBlueColor(string blue)
        {
            if (isFloat(blue) && int.Parse(blue) <= 255 && int.Parse(blue) >= 0)
            {
                blueButton.AltTitle = $"{blue}";
                marker.setBlue(int.Parse(blue));
            }
            else
            {
                Debug.WriteLine("Valeur invalide (Entier entre 0-255)");
            }
        }
        private void setAlpha(object sender, EventArgs e) { Tools.GetInput(setAlphaColor); }
        private void setAlphaColor(string Alpha)
        {
            if (isFloat(Alpha) && int.Parse(Alpha) <= 255 && int.Parse(Alpha) >= 0)
            {
                alphaButton.AltTitle = $"{Alpha}";
                marker.setAlpha(int.Parse(Alpha));
            }
            else
            {
                Debug.WriteLine("Valeur invalide (Entier entre 0-255)");
            }
            
        }
        
        
        
        private void setBump(object sender, EventArgs e) { setBumpAction(!marker.getBump()); }
        private void setBumpAction(Boolean bump) { marker.setBump(bump); }
        
        private void setRotation(object sender, EventArgs e) { setRotationAction(!marker.getRotation()); }
        private void setRotationAction(Boolean rotate)  { marker.setRotation(rotate); }
        
        
        
        
        
        
        private void copyLua(object sender, EventArgs e) { CopyAction(marker.toStringLua()); }
        private void copyCS(object sender, EventArgs e) { CopyAction(marker.toStringCS()); }
        private void CopyAction(String text)  { Tools.copyToClipboard(text); }
        
        
        
        
        
        
        
        
        private bool isFloat(string s)
        {
            float f;
            return float.TryParse(s, out f);
        }
        
        
        
        private bool isInteger(string s)
        {
            int i;
            return int.TryParse(s, out i);
        }

        private void StopLoop(object sender, EventArgs e){marker.StopLoop();}

        //private void toClipBoard(object sender, EventArgs e) {  }

        public Marker getMarker() { return marker; }

    }
}
