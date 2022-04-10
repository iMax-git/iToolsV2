extern alias FX;
using System;
using System.Collections;
using System.Collections.Generic;
using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;


namespace iToolsV2
{
    public class Camera
    {
        
        private bool active = false;
        private int cameraHandle;
        private float x;
        private float y;
        private float z;
        private float rotX;
        private float rotY;
        private float rotZ;
        private float fov;



        public Camera(float x, float y, float z, float rotX, float rotY, float rotZ, float fov)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.rotX = rotX;
            this.rotY = rotY;
            this.rotZ = rotZ;
            this.fov = fov;
        }

        public void CreateCamera()
        {
            this.cameraHandle = API.CreateCamWithParams("DEFAULT_SCRIPTED_CAMERA", x, y, z, rotX, rotY, rotZ, fov, active, 2);
            API.RenderScriptCams(active, false,0, active, active);
            Vector3 pos = Game.PlayerPed.Position;
            API.SetFocusPosAndVel(pos.X, pos.Y, pos.Z,x, y, z);
            //Debug.WriteLine($"Camera created {cameraHandle}");
        }
        
        
        public void SetActive(bool active)
        {
            if (cameraHandle != -1)
            {
                this.active = active;
                API.SetCamActive(this.cameraHandle, active);
                API.RenderScriptCams(active, false, 0, active, active);
                //Debug.WriteLine($"Camera set active {active}");
            } 
        }
        public void setX(float x)
        {
            this.x = x;
            API.SetCamCoord(this.cameraHandle, x, y, z);
        }
        public void setY(float y)
        {
            this.y = y;
            API.SetCamCoord(this.cameraHandle, x, y, z);
        }
        public void setZ(float z)
        {
            this.z = z;
            API.SetCamCoord(this.cameraHandle, x, y, z);
        }
        public void setRotX(float rotX)
        {
            this.rotX = rotX;
            API.SetCamRot(this.cameraHandle, rotX, rotY, rotZ, 2);
        }
        public void setRotY(float rotY)
        {
            this.rotY = rotY;
            API.SetCamRot(this.cameraHandle, rotX, rotY, rotZ, 2);
        }
        public void setRotZ(float rotZ)
        {
            this.rotZ = rotZ;
            API.SetCamRot(this.cameraHandle, rotX, rotY, rotZ, 2);
        }
        public void setFov(float fov)
        {
            this.fov = fov;
            API.SetCamFov(this.cameraHandle, fov);
        }
        
        
        public bool isActive() => this.active;
        public int getHandle() => this.cameraHandle;
        public float getX() => this.x;
        public float getY() => this.y;
        public float getZ() => this.z;
        public float getRotX() => this.rotX;
        public float getRotY() => this.rotY;
        public float getRotZ() => this.rotZ;
        public float getFov() => this.fov;
        
        public void Destroy()
        {
            SetActive(false);
            API.DestroyCam(this.cameraHandle, false);
            this.cameraHandle = -1;
        }

        public String toStringLua()
        {
            return $"CreateCamWithParams('DEFAULT_SCRIPTED_CAMERA', {this.x}, {this.y}, {this.z}, {this.rotX}, {this.rotY}, {this.rotZ}, {this.fov}, {this.active}, {this.cameraHandle})";
        }

        public String toStringCS()
        {
            return $"API.CreateCam('DEFAULT_SCRIPTED_CAMERA', {this.x}, {this.y}, {this.z}, {this.rotX}, {this.rotY}, {this.rotZ}, {this.fov}, {this.active}, {this.cameraHandle})";
        }
        
    }
}