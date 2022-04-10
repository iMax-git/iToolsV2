extern alias FX;
using System;
using System.Collections.Generic;
using FX::CitizenFX.Core;
using LemonUI.Menus;

namespace iToolsV2
{
    public class CameraMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;

        private NativeItem activeButton;
        
        private NativeItem xButton;
        private NativeItem yButton;
        private NativeItem zButton;
        
        private NativeItem rxButton;
        private NativeItem ryButton;
        private NativeItem rzButton;
        
        private NativeItem fovButton;
        
        
        
        private Camera cam;


        public CameraMenu(Menu mainmenu, FunctionTools Tools)
        {
            this.menuiTools = mainmenu;
            this.Tools = Tools;
            
        }
        
        public void CreateCamera(object sender, EventArgs e)
        {
            Vector3 pos = Game.PlayerPed.Position;
            if (cam == null)
            {
                cam = new Camera(pos.X, pos.Y, pos.Z, 0, 0, 0,10.0f);
                cam.CreateCamera();
                Menu menu = menuiTools.getSubMenu("itools-2-camera");
                menu.AddSeparator();
                activeButton = menu.AddCheckBoxButton("Vue de la caméra", cam.isActive(), (o, args) =>
                {
                    bool active = !cam.isActive();
                    cam.SetActive(active);
                });
                menu.AddSeparator();
                xButton = menu.AddButtonValue("Changer la valeur de x:", $"{cam.getX()}", setX);
                yButton = menu.AddButtonValue("Changer la valeur de y:", $"{cam.getY()}", setY);
                zButton = menu.AddButtonValue("Changer la valeur de z:", $"{cam.getZ()}", setZ);
                menu.AddSeparator();
                rxButton = menu.AddButtonValue("Changer la valeur de rx:", $"{cam.getRotX()}", setRotX);
                ryButton = menu.AddButtonValue("Changer la valeur de ry:", $"{cam.getRotY()}", setRotY);
                rzButton = menu.AddButtonValue("Changer la valeur de rz:", $"{cam.getRotZ()}", setRotZ);
                menu.AddSeparator();
                fovButton = menu.AddButtonValue("Changer la valeur de fov:", $"{cam.getFov()}", setFov);
                menu.AddSeparator();
                menu.AddButton("Copier dans le presse papier en Lua.", copyLua);
                menu.AddButton("Copier dans le presse papier en C#.", copyCS);
                menu.AddSeparator();
                menu.AddButton("Supprimer la caméra.", (_, __) =>
                {
                    if (!cam.isActive())
                    {
                        cam.Destroy();
                        activeButton.Enabled = false;
                    }
                    else
                    {
                        Debug.WriteLine("La caméra doit être désactivée pour pouvoir la supprimer.");
                    }
                });

            }
            else
            {
                Reset(pos);
                cam.Destroy();
                cam.CreateCamera();
                activeButton.Enabled = true;
            }
        }

        private void Reset(Vector3 pos)
        {
            
            cam.setX(pos.X);
            cam.setY(pos.Y);
            cam.setZ(pos.Z);
                
            cam.setRotX(0f);
            cam.setRotY(0f);
            cam.setRotZ(0f);
                
            cam.setFov(10.0f);
        }
        
        private void setX(object sender, EventArgs e){Tools.GetInput(setXPos);}
        private void setY(object sender, EventArgs e){Tools.GetInput(setYPos);}
        private void setZ(object sender, EventArgs e){Tools.GetInput(setZPos);}
        
        private void setRotX(object sender, EventArgs e){Tools.GetInput(setRotXPos);}
        private void setRotY(object sender, EventArgs e){Tools.GetInput(setRotYPos);}
        private void setRotZ(object sender, EventArgs e){Tools.GetInput(setRotZPos);}
        
        private void setFov(object sender, EventArgs e){Tools.GetInput(setFovPos);}
        
        private void setXPos(string input)
        {
            float x = 0f;
            float.TryParse(input, out x);
            cam.setX(x);
            xButton.AltTitle = $"{x}";
        }
        
        private void setYPos(string input)
        {
            float y = 0f;
            float.TryParse(input, out y);
            cam.setY(y);
            yButton.AltTitle = $"{y}";
        }
        
        private void setZPos(string input)
        {
            float z = 0f;
            float.TryParse(input, out z);
            cam.setZ(z);
            zButton.AltTitle = $"{z}";
        }
        
        private void setRotXPos(string input)
        {
            float x = 0f;
            float.TryParse(input, out x);
            cam.setRotX(x);
            rxButton.AltTitle = $"{x}";
        }
        
        private void setRotYPos(string input)
        {
            float y = 0f;
            float.TryParse(input, out y);
            cam.setRotY(y);
            ryButton.AltTitle = $"{y}";
        }
        
        private void setRotZPos(string input)
        {
            float z = 0f;
            float.TryParse(input, out z);
            cam.setRotZ(z);
            rzButton.AltTitle = $"{z}";
        }
        
        private void setFovPos(string input)
        {
            float fov = 0f;
            float.TryParse(input, out fov);
            cam.setFov(fov);
            fovButton.AltTitle = $"{fov}";
        }
        
        private void copyLua(object sender, EventArgs e)
        {
            Tools.copyToClipboard(cam.toStringLua());
        }
        
        private void copyCS(object sender, EventArgs e)
        {
            Tools.copyToClipboard(cam.toStringCS());
        }
        
        
        
    }
}