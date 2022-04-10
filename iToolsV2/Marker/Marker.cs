extern alias FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;

namespace iToolsV2
{
    class Marker
    {
        private int type = 1;
        
        private float x = (float)0.0;
        private float y = (float)0.0;
        private float z = (float)0.0;

        private float dirx = (float)0.0;
        private float diry = (float)0.0;
        private float dirz = (float)0.0;

        private float rotx = (float)0.0;
        private float roty = (float)0.0;
        private float rotz = (float)0.0;

        private float scalex = (float)0.5;
        private float scaley = (float)0.5;
        private float scalez = (float)0.5;

        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 0;
        private Boolean bumpUpandDown = false;
        private Boolean rotate = false;
        private Boolean faceCamera = false;

        private Boolean ActiveLoop = false;
        private FunctionTools tools = new FunctionTools();
        public Marker(int Type, float x,float y,float z,int Red, int Green, int Blue,int Alpha,Boolean bumpUpandDown,Boolean rotate)
        {
            type = Type;
            this.x = x;
            this.y = y;
            this.z = z;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.alpha = Alpha;
            this.bumpUpandDown = bumpUpandDown;
            this.rotate = rotate;
            this.ActiveLoop = true;
            loop();
        
            
        }

        public void SetPositionOnPlayer()
        {
            Vector3 playerPos = API.GetEntityCoords(API.PlayerPedId(), true);
            this.x = playerPos.X;
            this.y = playerPos.Y;
            this.z = playerPos.Z;
        }

        public void SetHeadingOnPlayer()
        {
            float playerHeading = API.GetEntityHeading(API.PlayerPedId());
            this.rotz = playerHeading;
        }

        public void StopLoop() { this.ActiveLoop = false; }
        public void StartLoop() { this.ActiveLoop = true; }

        public Boolean loopIsActive() { return this.ActiveLoop; }

        public int getType() { return this.type; }
        public void setType(int Type) { this.type = Type; }
        
        public float getX() { return this.x; }
        public float getY() { return this.y; }
        public float getZ() { return this.z; }

        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }
        public void setZ(float z) { this.z = z; }

        public float getDirX() { return this.dirx; }
        public float getDirY() { return this.diry; }
        public float getDirZ() { return this.dirz; }

        public void setDirX(float x) { this.dirx = x; }
        public void setDirY(float y) { this.diry = y; }
        public void setDirZ(float z) { this.dirz = z; }
        
        public float getRotX() { return this.rotx; }
        public float getRotY() { return this.roty; }
        public float getRotZ() { return this.rotz; }
        
        public void setRotX(float x) { this.rotx = x; }
        public void setRotY(float y) { this.roty = y; }
        public void setRotZ(float z) { this.rotz = z; }
        
        public float getScaleX() { return this.scalex; }
        public float getScaleY() { return this.scaley; }
        public float getScaleZ() { return this.scalez; }
        
        public void setScaleX(float x) { this.scalex = x; }
        public void setScaleY(float y) { this.scaley = y; }
        public void setScaleZ(float z) { this.scalez = z; }

        public int getRed() { return this.red; }
        public int getGreen() { return this.green; }
        public int getBlue() { return this.blue; }
        public int getAlpha() { return this.alpha; }

        public void setRed(int red) { this.red = red; }
        public void setGreen(int green) { this.green = green; }
        public void setBlue(int blue) { this.blue = blue; }
        public void setAlpha(int alpha) { this.alpha = alpha; }

        public Boolean getBump() { return this.bumpUpandDown; }
        public void setBump(Boolean bump) { this.bumpUpandDown = bump; }
        public Boolean getRotation() { return this.rotate; }
        public void setRotation(Boolean rotate) { this.rotate = rotate; }

        public void loop()
        {
            API.Wait(1);
            API.DrawMarker(this.type, this.x, this.y, this.z, this.dirx, this.diry, this.dirz, this.rotx, this.roty, this.rotz, this.scalex, this.scaley, this.scalez, this.red, this.green, this.blue, this.alpha, this.bumpUpandDown, this.faceCamera, 0, this.rotate, null, null, false);
            
        }

        public String toStringLua()
        {
            return $"DrawMarker({this.type},{this.x},{this.y},{this.z},{String.Format("{0:0.0}",this.dirx)},{String.Format("{0:0.0}",this.diry)},{String.Format("{0:0.0}",this.dirz)},{String.Format("{0:0.0}",this.rotx)},{String.Format("{0:0.0}",this.roty)},{String.Format("{0:0.0}",this.rotz)},{String.Format("{0:0.0}",this.scalex)},{String.Format("{0:0.0}",this.scaley)},{String.Format("{0:0.0}",this.scalez)},{this.red},{this.green},{this.blue},{this.alpha},{this.bumpUpandDown.ToString().ToLower()},{this.faceCamera.ToString().ToLower()},0,{this.rotate.ToString().ToLower()},nil,nil,false)";
        }
        public String toStringCS()
        {
            return $"API.DrawMarker({this.type},{this.x},{this.y},{this.z},(float){String.Format("{0:0.0}",this.dirx)},(float){String.Format("{0:0.0}",this.diry)},(float){String.Format("{0:0.0}",this.dirz)},(float){String.Format("{0:0.0}",this.rotx)},(float){String.Format("{0:0.0}",this.roty)},(float){String.Format("{0:0.0}",this.rotz)},(float){String.Format("{0:0.0}",this.scalex)},(float){String.Format("{0:0.0}",this.scaley)},(float){String.Format("{0:0.0}",this.scalez)},{this.red},{this.green},{this.blue},{this.alpha},{this.bumpUpandDown.ToString().ToLower()},{this.faceCamera.ToString().ToLower()},0,{this.rotate.ToString().ToLower()},null,null,false);";
        }
    }
}
