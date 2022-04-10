extern alias FX;
using FX::CitizenFX.Core.Native;

namespace iToolsV2
{
    public class BlipArea
    {
        private int blip;
        private float x;
        private float y;
        private float z;
        private float width;
        private float height;

        private int rotation;

        private int color;
        private int alpha = 255;
        
        
        public BlipArea(float x, float y, float z, float width,float height)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.width = width;
            this.height = height;
            CreateBlip();
        }

        public void CreateBlip()
        {
            blip = API.AddBlipForArea(x,y,z,width,height);
            API.SetBlipColour(blip, 1);
            API.SetBlipAlpha(blip, alpha);
        }

        public int GetBlip() => blip;
        
        public float GetX() => x;
        
        public float GetY() => y;
        
        public float GetZ() => z;
        
        public float GetWidth() => width;
        
        public float GetHeight() => height;
        
        public int GetColor() => color;
        
        public int GetAlpha() => alpha;
        
        public int GetRotation() => rotation;
        

        public void SetX(float x)
        {
            this.x = x;
            API.SetBlipCoords(blip,x,y,z);
        }

        public void SetY(float y)
        {
            this.y = y;
            API.SetBlipCoords(blip,x,y,z);
        }
        
        public void SetZ(float z)
        { 
            this.z = z;
            API.SetBlipCoords(blip,x,y,z);
        }

        
        public void SetWidth(float width)
        {
            this.width = width;
            API.SetBlipScaleTransformation(blip, width, height);
        }
        
        public void SetHeight(float height)
        {
            this.height = height;
            API.SetBlipScaleTransformation(blip, width, height);
        }

        public void SetColor(int color)
        {
            this.color = color;
            API.SetBlipColour(blip,color);
        }
        
        public void SetAlpha(int alpha)
        { 
            this.alpha = alpha;
            API.SetBlipAlpha(blip,alpha);
        }
        
        public void SetRotation(int rotation)
        {
            this.rotation = rotation;
            API.SetBlipRotation(blip,rotation);
        }

        
        public void DeleteBlip() => API.RemoveBlip(ref blip);

        public string toStringLua() => $"areablip = AddBlipForArea({x},{y},{z},{width},{height}) \n" +
                                       $"SetBlipColour(areablip,{color})\n" +
                                       $"SetBlipAlpha(areablip,{alpha})\n" +
                                       $"SetBlipRotation(areablip,{rotation})\n";

        public string toStringCS() => $"int areablip = API.AddBlipForArea({x},{y},{z},{width},{height});\n" +
                                      $"API.SetBlipColour(areablip,{color});\n" +
                                      $"API.SetBlipAlpha(areablip,{alpha});\n" +
                                      $"API.SetBlipRotation(areablip,{rotation});\n";

 
    }
}