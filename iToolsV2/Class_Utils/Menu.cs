extern alias FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FX::CitizenFX.Core;
using FX::CitizenFX.Core.Native;
using LemonUI;
using LemonUI.Elements;
using LemonUI.Extensions;
using LemonUI.Menus;

namespace iToolsV2
{
    public class Menu : BaseScript
    {
        private String titlemenu;
        private NativeMenu menu;
        private Dictionary<string, Menu> table_submenu = new Dictionary<string, Menu>();
        private PointF Position = new PointF();
        private ObjectPool pool = new ObjectPool();
        public Menu(String title, String subtitle, float X, float Y)
        {
            this.CreateMenu(title, subtitle, X, Y);
        }

        private void CreateMenu(String title, String subtitle, float X, float Y)
        {
            menu = new NativeMenu(title, subtitle);
            this.titlemenu = title;
            Position.X = X;
            Position.Y = Y;
            menu.Offset = Position;
            menu.UseMouse = false;
            refreshPool();
        }

        public void OpenMenu() { menu.Visible = true; }
        public void CloseMenu() { menu.Visible = false; }

        public void setPosition(float X, float Y)
        {
            Position.X = X;
            Position.Y = Y;
            menu.Offset = Position;
        }

        public void AddSub(String id, String title)
        {
            Menu submenu = new Menu(title,"",this.Position.X,this.Position.Y);
            table_submenu.Add(id, submenu);
            NativeSubmenuItem button = menu.AddSubMenu(submenu.getMainMenu());
            button.Title= title;
            pool.Add(submenu.getMainMenu());

        }
        public void AddSub(String id, String title, String subtitle)
        {
            Menu submenu = new Menu(subtitle,"",this.Position.X,this.Position.Y);
            table_submenu.Add(id, submenu);
            NativeSubmenuItem button = menu.AddSubMenu(submenu.getMainMenu());
            button.Title= title;
            pool.Add(submenu.getMainMenu());

        }
        public void AddSub(String id, String title, PointF position)
        {
            Menu submenu = new Menu(title,"Test", this.Position.X, this.Position.Y);
            table_submenu.Add(id, submenu);
            submenu.getMainMenu().Offset = position;
            menu.AddSubMenu(submenu.getMainMenu());

        }
        /*
        public void AddSub(String id, String title, String description)
        {
            Menu submenu = new Menu(title, "", this.Position.X, this.Position.Y);
            table_submenu.Add(id, submenu);
            submenu.getMainMenu().Offset = this.Position;
            menu.AddSubMenu(submenu.getMainMenu());

        }
        */
        public void AddSub(String id, String title, String description, PointF position)
        {
            Menu submenu = new Menu(title, "", this.Position.X, this.Position.Y);
            table_submenu.Add(id, submenu);
            submenu.getMainMenu().Offset = position;
            menu.AddSubMenu(submenu.getMainMenu());

        }
        public void AddSub(String id, String title, String subtitle, String description)
        {
            Menu submenu = new Menu(title, subtitle, this.Position.X, this.Position.Y);
            table_submenu.Add(id, submenu);
            submenu.getMainMenu().Offset = this.Position;
            menu.AddSubMenu(submenu.getMainMenu());

        }
        public void AddSub(String id, String title, String subtitle, String description, PointF position)
        {
            Menu submenu = new Menu(title, subtitle, this.Position.X, this.Position.Y);
            table_submenu.Add(id, submenu);
            submenu.getMainMenu().Offset = position;
            menu.AddSubMenu(submenu.getMainMenu());

        }


        public void AddButton(String title)
        {
            NativeItem button = new NativeItem(title);
            menu.Add(button);
        }
        public void AddButton(String title, String description)
        {
            NativeItem button = new NativeItem(title, description);
            button.Description = description;
            menu.Add(button);
            
        }
        public void AddButton( String title, Boolean isActive)
        {
            NativeItem button = new NativeItem(title);
            button.Enabled = isActive;
            menu.Add(button);

        }

        public void AddButton( String title, EventHandler cb)
        {
            NativeItem button = new NativeItem(title);
            button.Activated += cb;
            menu.Add(button);

        }
        public void AddButton( String title, Boolean isActive, EventHandler cb)
        {
            NativeItem button = new NativeItem(title);
            button.Activated += cb;
            button.Enabled = isActive;
            menu.Add(button);

        }

        public NativeItem AddButtonValue(String title, EventHandler cb)
        {
            NativeItem button = new NativeItem(title);
            button.Activated += cb;
            menu.Add(button);
            return button;
        }
        public NativeItem AddButtonValue(String title, String FirstVal, EventHandler cb)
        {
            NativeItem button = new NativeItem(title);
            button.Activated += cb;
            button.AltTitle = $"{FirstVal}";
            menu.Add(button);
            return button;
        }

        public NativeCheckboxItem AddCheckBoxButton(String title, Boolean active)
        {
            NativeCheckboxItem checkbox = new NativeCheckboxItem(title, active);
            menu.Add(checkbox);
            return checkbox;
        }
        public NativeCheckboxItem AddCheckBoxButton(String title, Boolean active, EventHandler cb)
        {
            NativeCheckboxItem checkbox = new NativeCheckboxItem(title, active);
            checkbox.CheckboxChanged += cb;
            menu.Add(checkbox);
            return checkbox;
        }
        public NativeCheckboxItem AddCheckBoxButton(String title, String description, Boolean active)
        {
            NativeCheckboxItem checkbox = new NativeCheckboxItem(title, description, active);
            menu.Add(checkbox);
            return checkbox;
        }
        public NativeCheckboxItem AddCheckBoxButton(String title, String description, Boolean active, EventHandler cb)
        {
            NativeCheckboxItem checkbox = new NativeCheckboxItem(title, description, active);
            checkbox.CheckboxChanged += cb;
            menu.Add(checkbox);
            return checkbox;
        }
        
        
        
        public NativeListItem AddListItem(String title, List<int> values, ItemChangedEventHandler<int> cb)
        {
            NativeListItem<int> list = new NativeListItem<int>(title, "") ;
            list.Items = values;
            list.ItemChanged += cb;
            menu.Add(list);
            return list;
        }
        
        public NativeListItem AddListItem(String title, List<String> values, ItemChangedEventHandler<String> cb)
        {
            NativeListItem<String> list = new NativeListItem<String>(title, "") ;
            list.Items = values;
            list.ItemChanged += cb;
            menu.Add(list);
            return list;
        }
        
        
        
        
        
        
        
        

        public void AddSeparator()
        {
            NativeSeparatorItem separator = new NativeSeparatorItem();
            separator.Enabled = false;
            menu.Add(separator);
        }

        public Boolean isOpen(){return menu.Visible;}

        private void refreshPool() {pool.Add(menu);}
        public ObjectPool getPool() {return pool;}

        public NativeMenu getMainMenu() { return menu; }
        public Menu getSubMenu(String id){ return table_submenu[id]; }

    }
}
