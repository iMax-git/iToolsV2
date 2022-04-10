extern alias FX;
using FX::CitizenFX.Core.Native;

namespace iToolsV2
{
    public class BlipRadius
    {
        private int blip;
        private float x;
        private float y;
        private float z;
        private float radius;

        private int color;
        private int alpha = 255;
        
        
        public BlipRadius(float x, float y, float z, float radius)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.radius = radius;
            CreateBlip();
        }

        public void CreateBlip()
        {
            blip = API.AddBlipForRadius(x,y,z,radius);
            API.SetBlipColour(blip, 1);
            API.SetBlipAlpha(blip, alpha);
        }

        public int GetBlip() => blip;
        
        public float GetX() => x;
        
        public float GetY() => y;
        
        public float GetZ() => z;
        
        public float GetRadius() => radius;
        
        public int GetColor() => color;
        
        public int GetAlpha() => alpha;
        

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

        public void SetRadius(float radius)
        {
            this.radius = radius;
            API.SetBlipScale(blip,radius);
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

        
        public void DeleteBlip() => API.RemoveBlip(ref blip);

        public string toStringLua() => $"radiusblip = AddBlipForRadius({x},{y},{z},{radius}) \n" +
                                       $"SetBlipColour(radiusblip,{color})\n" +
                                       $"SetBlipAlpha(radiusblip,{alpha})\n";

        public string toStringCS() => $"int radiusblip = API.AddBlipForRadius({x},{y},{z},{(double)radius});\n" +
                                      $"API.SetBlipColour(radiusblip,{color});\n" +
                                      $"API.SetBlipAlpha(radiusblip,{alpha});\n";


    }
}