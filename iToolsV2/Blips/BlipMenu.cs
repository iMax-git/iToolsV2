extern alias FX;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using FX::CitizenFX.Core;
using LemonUI.Menus;

namespace iToolsV2
{
    class BlipMenu
    {
        private Menu menuiTools;
        private FunctionTools Tools;
        
        private Blip blip;
        
        private List<int> blipList = new List<int>()
        {1,8,11,16,36,38,40,43,50,51,52,56,60,61,66,67,68,71,72,73,75,76,77,78,79,80,84,85,88,89,90,93,94,100,102,103,106,108,109,110,119,120,121,122,126,127,133,135,136,140,141,147,149,150,151,152,153,154,155,156,157,158,159,160,162,163,164,171,173,174,175,181,184,188,197,198,205,206,207,225,226,229,238,251,
        255, 266, 267, 269, 270, 273, 274, 277, 279, 280, 285, 303, 304, 305, 306, 307, 308, 310, 311, 313, 314, 315, 316, 318, 350, 351, 352, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 365, 366, 367, 368, 369
        , 370, 371, 372, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 387, 388, 389, 390, 398, 400, 401, 402, 403, 404, 405, 408, 409, 410, 411, 415, 417, 418, 419, 420, 421, 427, 430, 431, 432, 433, 434, 435, 436, 437, 439, 440, 441, 442, 445, 446, 455, 456, 458, 459, 460, 461, 463, 464, 465, 466, 467, 468
        , 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 483, 484, 485, 486, 487, 488, 489, 490
        , 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 512, 513, 514, 515, 521, 522, 523, 524, 525, 526
        , 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547
        , 548, 549, 550, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568, 569, 570, 571, 572, 573
        , 574, 575, 576, 577, 578, 579, 580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590, 591, 592, 593, 594
        , 595, 596, 597, 598, 599, 600, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650, 651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677, 678
        , 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689, 690, 691, 692, 693, 694, 695, 696, 697, 698, 699, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767, 768, 769, 770, 771, 772, 773, 774, 775, 776, 777, 778, 779, 780, 781, 782, 783
        , 784, 785, 786, 787, 788, 789, 790, 791, 792, 793, 794, 795, 796, 797, 798, 799, 800, 801, 802, 803, 804, 805, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826
        
        } ;

        private List<int> colorList = new List<int>();

        private NativeItem nameButton;
        private NativeItem scaleButton;
        private NativeItem xButton;
        private NativeItem yButton;
        private NativeItem zButton;
        private NativeItem rangeButton;
        

        public BlipMenu(Menu mainmenu,FunctionTools Tools)
        {
            for(int color = 1 ; color <= 85 ; color++)
            {
                colorList.Add(color);
            }
            this.menuiTools = mainmenu;
            this.Tools = Tools;
        }

        public void CreateBlip(object sender, EventArgs e)
        {
            Vector3 pos = Game.PlayerPed.Position;
            if (blip is null)
            {
                blip = new Blip(0, pos,"New Marker",0,0,(float)0.7);    
                Menu menu = menuiTools.getSubMenu("itools-2-blip");   
                menu.AddSeparator();
                menu.AddListItem("Changer le type de blip : ", blipList, setType);
                menu.AddSeparator();
                menu.AddListItem("Changer la couleur du blip: ", colorList, setColor);
                menu.AddSeparator();
                xButton = menu.AddButtonValue("Changer la position X", $"{blip.GetX()}", setX);
                yButton = menu.AddButtonValue("Changer la position Y", $"{blip.GetY()}", setY);
                zButton = menu.AddButtonValue("Changer la position Z", $"{blip.GetZ()}", setZ);
                menu.AddSeparator();
                nameButton = menu.AddButtonValue("Changer le nom du blip", blip.GetName(), setName);
                menu.AddSeparator();
                scaleButton = menu.AddButtonValue("Changer la taille", $"{blip.GetScale()}", setScale);
                menu.AddSeparator();
                rangeButton = menu.AddCheckBoxButton("Mettre le blip en courte portée.", blip.GetShowShortRange(), setRange);
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

        private void setType(object sender, ItemChangedEventArgs<int> type) => blip.SetSprite(type.Object);

        private void setColor(object sender, ItemChangedEventArgs<int> type) => blip.SetColor(type.Object);
        
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
        
        private void setScale(object sender, EventArgs e) => Tools.GetInput(setScalePos);
        
        private void setScalePos(string input)
        {
            if (isFloat(input))
            {
                blip.SetScale(float.Parse(input));
                scaleButton.AltTitle = $"{input}";
            }
            else
            {
                Debug.WriteLine("Valeur non valide (Float requis)");
            }
        }
        
        private void setName(object sender, EventArgs e) => Tools.GetInput(setNamePos);
        
        private void setNamePos(string input)
        {
            blip.SetName(input);
            nameButton.AltTitle = input;
        }
        
        private void setRange(object sender, EventArgs e) => blip.SetShowShortRange(!blip.GetShowShortRange());
        
        private void deleteBlip(object sender, EventArgs e) => blip.Delete();
        
        private void copyLua(object sender, EventArgs e) => CopyAction(blip.toStringLua());
        private void copyCS(object sender, EventArgs e) => CopyAction(blip.toStringCS());
        
        private void CopyAction(String text)  { Tools.copyToClipboard(text); }
        private bool isFloat(string s)
        {
            float f;
            return float.TryParse(s, out f);
        }
        
        
    }
}