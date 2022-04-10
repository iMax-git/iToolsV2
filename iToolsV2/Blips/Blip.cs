extern alias FX;
using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;

namespace iToolsV2
{
    public class Blip
    {
        private int blip = 0;
        private float x;
        private float y;
        private float z;
        private string name;
        private int sprite;
        private int color;
        private float scale;
        private bool ShowShortRange = false;
        
        
        public Blip(int blip, Vector3 position, string name, int sprite, int color, float scale)
        {
            this.blip = blip;
            this.x = position.X;
            this.y = position.Y;
            this.z = position.Z;
            this.name = name;
            this.sprite = sprite;
            this.color = color;
            this.scale = scale;
            this.blip = API.AddBlipForCoord(this.x, this.y, this.z);
        }
        
        public int GetBlip() => blip;
        
        public float GetX() => x;
        
        public float GetY() => y;
        
        public float GetZ() => z;

        public string GetName() => name;
        
        public int GetSprite() => sprite;
        
        public int GetColor() => color;
        
        public float GetScale() => scale;
        
        public bool GetShowShortRange() => ShowShortRange;


        public void SetX(float x)
        {
            this.x = x;
            API.SetBlipCoords(blip, x, y, z);
        }
        
        public void SetY(float y)
        {
            this.y = y;
            API.SetBlipCoords(blip, x, y, z);
        }
        
        public void SetZ(float z)
        {
            this.z = z;
            API.SetBlipCoords(blip, x, y, z);
        }
        
        public void SetName(string name)
        {
            this.name = name;
            API.BeginTextCommandSetBlipName("STRING");
            API.AddTextComponentSubstringPlayerName(name);
            API.EndTextCommandSetBlipName(this.blip);
        }
        
        
        public void SetSprite(int sprite)
        {
            this.sprite = sprite;
            API.SetBlipSprite(this.blip, sprite);
        }
        
        public void SetColor(int color)
        {
            this.color = color;
            API.SetBlipColour(this.blip, color);
        }
        
        public void SetScale(float scale)
        {
            this.scale = scale;
            API.SetBlipScale(this.blip, scale);
        }
        
        public void SetShowShortRange(bool show)
        {
            this.ShowShortRange = show;
            API.SetBlipAsShortRange(this.blip, show);
        }
        
        public void Delete()=> API.RemoveBlip(ref blip);

        public string toStringLua() => $"blip = AddBlipForCoord({x},{y},{z})\n" +
                                       $"SetBlipColour(blip, {this.color})\n" +
                                       $"SetBlipSprite(blip, {this.sprite})\n" +
                                       $"SetBlipScale(blip, {this.scale})\n" +
                                       $"SetBlipAsShortRange(blip, {this.ShowShortRange.ToString().ToLower()})\n" +
                                       $"BeginTextCommandSetBlipName(\"STRING\")\n" +
                                       $"AddTextComponentSubstringPlayerName('{this.name}')\n" +
                                       $"EndTextCommandSetBlipName(blip)\n"+
        "";

        public string toStringCS() => $"int blip = API.AddBlipForCoord({this.x},{this.y}, {this.z});\n" +
                                      $"API.SetBlipSprite(blip, {this.sprite});\n" +
                                      $"API.SetBlipColour(blip, {this.color});\n" +
                                      $"API.SetBlipScale(blip, {this.scale});\n" +
                                      $"API.SetBlipAsShortRange(blip, {this.ShowShortRange.ToString().ToLower()});\n" +
                                      $"API.BeginTextCommandSetBlipName(\"STRING\");\n"+
                                      $"API.AddTextComponentSubstringPlayerName('{this.name}')\n" +
                                      $"API.EndTextCommandSetBlipName(blip)\n"+
        "";

    }
}