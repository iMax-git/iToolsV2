extern alias FX;
using System;
using System.Collections.Generic;
using FX::CitizenFX.Core.Native;

namespace iToolsV2.Other
{
    public class SoundEffect
    {
        private List<Tuple<string,string>> _sounds = new List<Tuple<string,string>>()
        {
            new Tuple<string, string>(
    "1st_Person_Transition",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FocusOut",
    "HintCamSounds"
  ),
 new Tuple<string,string>(
    "FocusIn",
    "HintCamSounds"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_SETUP_1_Car_Park_Skid_CR",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_SETUP_1_Car_Park_tyre_bump_CR",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_SETUP_1_Car_Park_tyre_bump_creak_CR",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_SETUP_1_Car_Park_tyre_bump_no_skid_CR",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_SETUP_1_Car_Park_tyre_bump_scraped_CR",
    "0"
  ),
 new Tuple<string,string>(
    "Architect_Fall",
    "FBI_HEIST_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_H2_ARCHITECT_GRAB_CASE",
    "0"
  ),
 new Tuple<string,string>(
    "FREIGHT_ELEVATOR_02_MOTOR",
    "0"
  ),
 new Tuple<string,string>(
    "debris",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "FBI_HEIST_H5_FIRE",
    "0"
  ),
 new Tuple<string,string>(
    "Bell",
    "LIFT_NORMAL_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Gasmask",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Explosion_01",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Woosh_01",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Land_01",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Explosion_04",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Woosh_04",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Land_04",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Explosion_03",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Woosh_03",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Land_03",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Explosion_02",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Woosh_02",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Land_02",
    "FBI_HEIST_ELEVATOR_SHAFT_DEBRIS_SOUNDS"
  ),
 new Tuple<string,string>(
    "CEILING_COLLAPSE",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Door_Blast_A",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Door_Blast_B",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "FIB3A_LAND_FROM_HEIGHT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Pre_Glass_Explosion",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Glass_Smash",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "MAIN_EXPLOSION_CHEAP",
    "0"
  ),
 new Tuple<string,string>(
    "LIFTS_TONE",
    "0"
  ),
 new Tuple<string,string>(
    "LIFT_POSH_DOOR_OPEN",
    "0"
  ),
 new Tuple<string,string>(
    "Hum",
    "SECURITY_CAMERA"
  ),
 new Tuple<string,string>(
    "Zoom_In",
    "SECURITY_CAMERA"
  ),
 new Tuple<string,string>(
    "detonation",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Detonation_2",
    "FBI_HEIST_RAID"
  ),
 new Tuple<string,string>(
    "Hit_out",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Short_Transition_In",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Hit_In",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Camera_Move_Loop",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Hit_Out",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Move",
    "LIFT_NORMAL_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Distant_Sirens_Fight",
    "FBI_HEIST_FINALE_CHOPPER"
  ),
 new Tuple<string,string>(
    "Distant_Sirens_Rubble",
    "FBI_HEIST_FINALE_CHOPPER"
  ),
 new Tuple<string,string>(
    "HACKING_DOWNLOADED",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_DOWNLOADING",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_MOVE_CURSOR",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_CLICK_BAD",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_COUNTDOWN_IP_FIND",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_COUNTDOWN_CRACK_PASS",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_FAILURE",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_CLICK_GOOD",
    "0"
  ),
 new Tuple<string,string>(
    "HACKING_CLICK",
    "0"
  ),
 new Tuple<string,string>(
    "Hack_Success",
    "DLC_GR_Steal_Railguns_Sounds"
  ),
 new Tuple<string,string>(
    "HACKING_SUCCESS",
    "0"
  ),
 new Tuple<string,string>(
    "unlocked_bleep",
    "HACKING_DOOR_UNLOCK_SOUNDS"
  ),
 new Tuple<string,string>(
    "Hack_Success",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pin_Movement",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pin_Centred",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pin_Good",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pin_Bad",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "BASEJUMPS_CHOPPER_WIND_WAIT",
    "0"
  ),
 new Tuple<string,string>(
    "TIME_LAPSE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Chopper_Goes_Down",
    "FBI_HEIST_FIGHT_CHOPPER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Chopper_Destroyed",
    "FBI_HEIST_FIGHT_CHOPPER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Heli_Crash",
    "FBI_HEIST_FINALE_CHOPPER"
  ),
 new Tuple<string,string>(
    "RFL_SINGLESHOT_NPC_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_UP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "slow",
    "SHORT_PLAYER_SWITCH_SOUND_SET"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_SKY_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "ScreenFlash",
    "WastedSounds"
  ),
 new Tuple<string,string>(
    "Bed",
    "WastedSounds"
  ),
 new Tuple<string,string>(
    "TextHit",
    "WastedSounds"
  ),
 new Tuple<string,string>(
    "ScreenFlash",
    "MissionFailedSounds"
  ),
 new Tuple<string,string>(
    "YES",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NO",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PROPERTY_PURCHASE",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "PEYOTE_COMPLETED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "COLLECTED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "SINGLE_BLIP_FROM_BOAT",
    "ABIGAIL_SONAR_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SCRIPT_TRIGGERED_FROM_PROP",
    "ABIGAIL_SONAR_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SPECIAL_EVIL_UFO_DEATH_RAY",
    "0"
  ),
 new Tuple<string,string>(
    "SPECIAL_EVIL_UFO_DEATH_RAY_3",
    "0"
  ),
 new Tuple<string,string>(
    "ent_amb_elec_crackle",
    "0"
  ),
 new Tuple<string,string>(
    "spl_stun_npc_master",
    "0"
  ),
 new Tuple<string,string>(
    "Crate_Beeps",
    "MP_CRATE_DROP_SOUNDS"
  ),
 new Tuple<string,string>(
    "ARM_WRESTLING_ARM_IMPACT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "ARM_WRESTLING_WHOOSH_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "LOSER",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "WIN",
    "0"
  ),
 new Tuple<string,string>(
    "Hit_1",
    "LONG_PLAYER_SWITCH_SOUNDS"
  ),
 new Tuple<string,string>(
    "Slow_Clap_Cel",
    "MP_SNACKS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Knuckle_Crack_Slap_Cel",
    "MP_SNACKS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Knuckle_Crack_Hard_Cel",
    "MP_SNACKS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TOGGLE_ON",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pre_Screen_Stinger",
    "DLC_HEISTS_PREP_SCREEN_SOUNDS"
  ),
 new Tuple<string,string>(
    "On",
    "GTAO_Vision_Modes_SoundSet"
  ),
 new Tuple<string,string>(
    "Switch",
    "GTAO_Vision_Modes_SoundSet"
  ),
 new Tuple<string,string>(
    "Off",
    "GTAO_Vision_Modes_SoundSet"
  ),
 new Tuple<string,string>(
    "ARM_WRESTLING_WOOD_CREEK_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "3_2_1_NON_RACE",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "GO_NON_RACE",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "place_bet",
    "0"
  ),
 new Tuple<string,string>(
    "place_max_bet",
    "0"
  ),
 new Tuple<string,string>(
    "start_spin",
    "0"
  ),
 new Tuple<string,string>(
    "spinning",
    "0"
  ),
 new Tuple<string,string>(
    "Garage_Door_Open",
    "GTAO_Script_Doors_Faded_Screen_Sounds"
  ),
 new Tuple<string,string>(
    "Event_Message_Purple",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Sink",
    "DLC_H4_Submarine_Sinking_Sounds"
  ),
 new Tuple<string,string>(
    "LIMIT",
    "GTAO_APT_DOOR_DOWNSTAIRS_GLASS_SOUNDS"
  ),
 new Tuple<string,string>(
    "PUSH",
    "GTAO_APT_DOOR_DOWNSTAIRS_GLASS_SOUNDS"
  ),
 new Tuple<string,string>(
    "elevator_ascend_loop",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "hangar_doors_loop",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "hangar_doors_close",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "elevator_descend_loop",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "hangar_doors_limit",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "hangar_doors_open",
    "dlc_xm_facility_entry_exit_sounds"
  ),
 new Tuple<string,string>(
    "Door_Open_Limit",
    "DLC_SM_Hangar_Door_Sounds"
  ),
 new Tuple<string,string>(
    "Enter_Car_Ramp_Deploy",
    "DLC_GR_MOC_Enter_Exit_Sounds"
  ),
 new Tuple<string,string>(
    "Enter_Car_Ramp_Hits_Ground",
    "DLC_GR_MOC_Enter_Exit_Sounds"
  ),
 new Tuple<string,string>(
    "OK",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Armour_Off",
    "DLC_GR_Steal_Miniguns_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Open_Limit",
    "DLC_GR_Bunker_Door_Sounds"
  ),
 new Tuple<string,string>(
    "CLOSED",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "CLOSING",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "OPENING",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "OPENED",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "Explosion_Countdown",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Altitude_Warning",
    "EXILE_1"
  ),
 new Tuple<string,string>(
    "10S",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Near_Miss_Counter",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Near_Miss_Counter_Reset",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Enter_1st",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Enter_1st",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Lose_1st",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Lose_1st",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Checkpoint_Hit",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "5s_To_Event_Start_Countdown",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Event_Start_Text",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_LEFT_RIGHT",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Checkpoint_Cash_Hit",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Crate_Collect",
    "MP_CRATE_DROP_SOUNDS"
  ),
 new Tuple<string,string>(
    "Criminal_Damage_Low_Value",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Criminal_Damage_Kill_Player",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Criminal_Damage_High_Value",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "WIN",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "GOLF_NEW_RECORD",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "DARTS_HIT_DART_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_HIT_BULLSEYE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_HIT_BOARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_HIT_WALL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_SCORE_TRIPLE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_SCORE_DOUBLE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_HIT_WIRE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DARTS_THROW_DART_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "WINNER",
    "CELEBRATION_SOUNDSET"
  ),
 new Tuple<string,string>(
    "LOSER",
    "CELEBRATION_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DLC_Biker_Darts_Hit_Board_Remote_Master",
    "0"
  ),
 new Tuple<string,string>(
    "Object_Collect_Remote",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Object_Dropped_Remote",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Object_Collect_Player",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "GENERATOR",
    "THE_FERRIS_WHALE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SLOW_SQUEAK",
    "THE_FERRIS_WHALE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CARRIAGE",
    "THE_FERRIS_WHALE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Text_Arrive_Tone",
    "0"
  ),
 new Tuple<string,string>(
    "ROBBERY_MONEY_TOTAL",
    "HUD_FRONTEND_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PURCHASE",
    "HUD_LIQUOR_STORE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_LIQUOR_STORE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_LIQUOR_STORE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "HUD_LIQUOR_STORE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_FREEMODE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_LIQUOR_STORE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Frontend_Beast_Transform_Back",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Frontend_Beast_Fade_Screen",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Frontend_Beast_Freeze_Screen",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Frontend_Beast_Frozen_Screen_Loop",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Frontend_Beast_Text_Hit",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Beast_Calls",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Beast_Hit",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Radar_Beast_Blip",
    "FM_Events_Sasquatch_Sounds"
  ),
 new Tuple<string,string>(
    "Kill_List_Counter",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "NAV_LEFT_RIGHT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PICK_UP",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_PURCHASE",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ascend",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "descend_impact",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "release_toy",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "rare_win",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "win",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "lose",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "laser_power_up",
    "dlc_ch_heist_finale_laser_drill_sounds"
  ),
 new Tuple<string,string>(
    "laser_drill",
    "dlc_ch_heist_finale_laser_drill_sounds"
  ),
 new Tuple<string,string>(
    "laser_power_down",
    "dlc_ch_heist_finale_laser_drill_sounds"
  ),
 new Tuple<string,string>(
    "laser_overheat",
    "dlc_ch_heist_finale_laser_drill_sounds"
  ),
 new Tuple<string,string>(
    "Drill_Jam",
    "DLC_HEIST_FLEECA_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Drill",
    "DLC_HEIST_FLEECA_SOUNDSET"
  ),
 new Tuple<string,string>(
    "laser_pin_break",
    "dlc_ch_heist_finale_laser_drill_sounds"
  ),
 new Tuple<string,string>(
    "Drill_Pin_Break",
    "DLC_HEIST_FLEECA_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ascend_win",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "ascend_lose",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "move",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "descend",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "start",
    "dlc_ch_claw_crane_sounds"
  ),
 new Tuple<string,string>(
    "fortune_bell",
    "dlc_ch_nazar_speaks_sounds"
  ),
 new Tuple<string,string>(
    "fortune_mech_loop",
    "dlc_ch_nazar_speaks_sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Nemesis",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Chillin",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_BuzzKill",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Not",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Schwing",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Pimpin",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Hype",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_Sweet",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_LoveSick",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_SoFine",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Outcome_PerfectMatch",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "Calculate_Outcome",
    "DLC_H3_LoveMachine_Sounds"
  ),
 new Tuple<string,string>(
    "sum20_am_Axe_of_Fury_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Fail_Bink",
    "0"
  ),
 new Tuple<string,string>(
    "Loading_Bink",
    "0"
  ),
 new Tuple<string,string>(
    "Main_Screen_Draw",
    "0"
  ),
 new Tuple<string,string>(
    "OS_Draw",
    "0"
  ),
 new Tuple<string,string>(
    "Disconnect_Wire",
    "0"
  ),
 new Tuple<string,string>(
    "Minigame_Failure",
    "0"
  ),
 new Tuple<string,string>(
    "All_Connected_Correct",
    "0"
  ),
 new Tuple<string,string>(
    "All_Connected_Incorrect",
    "0"
  ),
 new Tuple<string,string>(
    "Minigame_Success",
    "0"
  ),
 new Tuple<string,string>(
    "Success_Bink",
    "0"
  ),
 new Tuple<string,string>(
    "Background_loop",
    "0"
  ),
 new Tuple<string,string>(
    "Connect_Multiply_1",
    "0"
  ),
 new Tuple<string,string>(
    "Connect_Multiply_2",
    "0"
  ),
 new Tuple<string,string>(
    "Connect_Multiply_10",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_down",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_up",
    "0"
  ),
 new Tuple<string,string>(
    "Startup_Sequence",
    "0"
  ),
 new Tuple<string,string>(
    "Draw_Screen",
    "0"
  ),
 new Tuple<string,string>(
    "Hack_Failed",
    "0"
  ),
 new Tuple<string,string>(
    "Hack_Success",
    "0"
  ),
 new Tuple<string,string>(
    "Processing",
    "0"
  ),
 new Tuple<string,string>(
    "Print_Match",
    "0"
  ),
 new Tuple<string,string>(
    "Print_Not_Match",
    "0"
  ),
 new Tuple<string,string>(
    "Pattern_Shift",
    "0"
  ),
 new Tuple<string,string>(
    "Pattern_Scramble",
    "0"
  ),
 new Tuple<string,string>(
    "Window_Clear",
    "0"
  ),
 new Tuple<string,string>(
    "Print_Appears",
    "0"
  ),
 new Tuple<string,string>(
    "Tile_select",
    "0"
  ),
 new Tuple<string,string>(
    "Cursor_Move",
    "0"
  ),
 new Tuple<string,string>(
    "Tile_Select",
    "0"
  ),
 new Tuple<string,string>(
    "Scramble_Countdown_High",
    "0"
  ),
 new Tuple<string,string>(
    "Scramble_Countdown_MED",
    "0"
  ),
 new Tuple<string,string>(
    "Scramble_Countdown_Low",
    "0"
  ),
 new Tuple<string,string>(
    "Background_Hum",
    "0"
  ),
 new Tuple<string,string>(
    "Play_Start",
    "0"
  ),
 new Tuple<string,string>(
    "Cursor_Choose_Good",
    "0"
  ),
 new Tuple<string,string>(
    "Cursor_Choose_Bad",
    "0"
  ),
 new Tuple<string,string>(
    "New_Line_Flash",
    "0"
  ),
 new Tuple<string,string>(
    "Dot_Sequence_Change",
    "0"
  ),
 new Tuple<string,string>(
    "Dot_Sequence_Choose_Flash",
    "0"
  ),
 new Tuple<string,string>(
    "Section_Success_Window_Appears",
    "0"
  ),
 new Tuple<string,string>(
    "Section_Success_Window_Cleared",
    "0"
  ),
 new Tuple<string,string>(
    "Scramble_Countdown_Med",
    "0"
  ),
 new Tuple<string,string>(
    "Window_Draw",
    "0"
  ),
 new Tuple<string,string>(
    "Target_Match",
    "0"
  ),
 new Tuple<string,string>(
    "No_Match",
    "0"
  ),
 new Tuple<string,string>(
    "Print_Shuffle",
    "0"
  ),
 new Tuple<string,string>(
    "Select_Print_Tile",
    "0"
  ),
 new Tuple<string,string>(
    "Deselect_Print_Tile",
    "0"
  ),
 new Tuple<string,string>(
    "Kick_Machine",
    "DLC_H3_Arc_Mac_Degen_DotF_Sounds"
  ),
 new Tuple<string,string>(
    "Wheel_Spin_Start",
    "DLC_AW_Arena_Spin_Wheel_Game_Sounds"
  ),
 new Tuple<string,string>(
    "Pan",
    "DLC_Arena_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pan",
    "MP_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Background",
    "DLC_Arena_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Background",
    "MP_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Change_Cam",
    "DLC_Arena_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Change_Cam",
    "MP_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Door_Open",
    "DLC_AW_Arena_Spectator_Box_Access_Sounds"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_FRONTEND_MP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Highlight_Move_Up_Down",
    "DLC_AW_Arena_Office_Planning_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Back",
    "DLC_AW_Arena_Office_Planning_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Accept",
    "DLC_AW_Arena_Office_Planning_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Activate_Privacy_Glass",
    "dlc_xm_facility_ambient_sounds"
  ),
 new Tuple<string,string>(
    "Deactivate_Privacy_Glass",
    "dlc_xm_facility_ambient_sounds"
  ),
 new Tuple<string,string>(
    "Money_Counter_Loop",
    "DLC_Biker_Business_CFM_Sounds"
  ),
 new Tuple<string,string>(
    "FAKE_ARRIVE",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "Garage_Door_Close",
    "GTAO_Script_Doors_Faded_Screen_Sounds"
  ),
 new Tuple<string,string>(
    "BUTTON",
    "MP_PROPERTIES_ELEVATOR_DOORS"
  ),
 new Tuple<string,string>(
    "Retune_Low",
    "MP_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "MP_RADIO_SFX",
    "0"
  ),
 new Tuple<string,string>(
    "Retune_High",
    "MP_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "Off_Low",
    "MP_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "Off_High",
    "MP_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "DLC_Biker_Warehouse_Intro_Inventory_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "radio_tower_fixed",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "DLC_VW_RULES",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "DLC_VW_CONTINUE",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "Inside_Track_Start",
    "DLC_AW_Casino_Track_Inside_Game_Sounds"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_cabinet_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Beat_Pulse_Default",
    "GTAO_Dancing_Sounds"
  ),
 new Tuple<string,string>(
    "Background",
    "DLC_XM17_Facility_Strike_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Wasted",
    "POWER_PLAY_General_Soundset"
  ),
 new Tuple<string,string>(
    "MP_Flash",
    "WastedSounds"
  ),
 new Tuple<string,string>(
    "MP_Impact",
    "WastedSounds"
  ),
 new Tuple<string,string>(
    "Login",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "scanner_alarm_os",
    "dlc_xm_iaa_player_facility_sounds"
  ),
 new Tuple<string,string>(
    "cannon_active",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "DLC_XM_Explosions_Orbital_Cannon",
    "0"
  ),
 new Tuple<string,string>(
    "inactive_fire_fail",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "menu_select",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "menu_back",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "menu_reset",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "zoom_out_loop",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "cannon_charge_fire_loop",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "pan_loop",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "background_loop",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "cannon_activating_loop",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "menu_up_down",
    "dlc_xm_orbital_cannon_sounds"
  ),
 new Tuple<string,string>(
    "cannon_active_loop",
    "dlc_xm_orbital_cannon_remote_sounds"
  ),
 new Tuple<string,string>(
    "3_2_1_fire",
    "dlc_xm_orbital_cannon_remote_sounds"
  ),
 new Tuple<string,string>(
    "cannon_charge_fire_loop",
    "dlc_xm_orbital_cannon_remote_sounds"
  ),
 new Tuple<string,string>(
    "HUD_Static_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Disconnect",
    "0"
  ),
 new Tuple<string,string>(
    "Out_Of_Bounds_Alarm_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Scanner_Loop",
    "DLC_BTL_Target_Pursuit_Sounds"
  ),
 new Tuple<string,string>(
    "HUD_Shock_Recharge",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Perspective_Fire",
    "DLC_H3_Drone_Tranq_Weapon_Sounds"
  ),
 new Tuple<string,string>(
    "Pilot_Perspective_Fire",
    "DLC_H3_Drone_Tranq_Weapon_Sounds"
  ),
 new Tuple<string,string>(
    "Destroyed",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Detonate_Charge",
    "0"
  ),
 new Tuple<string,string>(
    "Shock_Fire",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Zoom_Change",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Boost_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Boost_Recharge_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Flight_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_Startup",
    "0"
  ),
 new Tuple<string,string>(
    "Missile_Launch",
    "0"
  ),
 new Tuple<string,string>(
    "Select_Spec_Drone",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "club_crowd_transition",
    "dlc_btl_club_open_transition_crowd_sounds"
  ),
 new Tuple<string,string>(
    "GARAGE_DOOR_SCRIPTED_CLOSE",
    "0"
  ),
 new Tuple<string,string>(
    "Engine_Revs",
    "DLC_HEISTS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Elevator_Doors_Opening_Loop",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Garage_Door_Open_Loop",
    "GTAO_Script_Doors_Sounds"
  ),
 new Tuple<string,string>(
    "Elevator_Doors_Closing_Loop",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Garage_Door_Close_Loop",
    "GTAO_Script_Doors_Sounds"
  ),
 new Tuple<string,string>(
    "Speech_Going_Up",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "GARAGE_DOOR_SCRIPTED_OPEN",
    "0"
  ),
 new Tuple<string,string>(
    "DOOR_Intercom_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DOOR_BUZZ",
    "MP_PLAYER_APARTMENT"
  ),
 new Tuple<string,string>(
    "Click_Fail",
    "WEB_NAVIGATION_SOUNDS_PHONE"
  ),
 new Tuple<string,string>(
    "DOOR_BUZZ_ONESHOT_MASTER",
    "GTAO_APT_DOOR_DOWNSTAIRS_GLASS_SOUNDS"
  ),
 new Tuple<string,string>(
    "WOODEN_DOOR_OPEN_NO_HANDLE_AT",
    "0"
  ),
 new Tuple<string,string>(
    "PUSH",
    "GTAO_APT_DOOR_DOWNSTAIRS_WOOD_SOUNDS"
  ),
 new Tuple<string,string>(
    "PUSH",
    "GTAO_APT_DOOR_DOWNSTAIRS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "PUSH",
    "GTAO_APT_DOOR_ROOF_METAL_SOUNDS"
  ),
 new Tuple<string,string>(
    "LIMIT",
    "GTAO_APT_DOOR_DOWNSTAIRS_WOOD_SOUNDS"
  ),
 new Tuple<string,string>(
    "LIMIT",
    "GTAO_APT_DOOR_DOWNSTAIRS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "LIMIT",
    "GTAO_APT_DOOR_ROOF_METAL_SOUNDS"
  ),
 new Tuple<string,string>(
    "Enter_On_Foot",
    "GTAO_ImpExp_Enter_Exit_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "ERROR",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Accept",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Error",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Back",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Move_Left_Right",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Highlight_Move_Up_Down",
    "DLC_Biker_Mission_Wall_Sounds"
  ),
 new Tuple<string,string>(
    "Exit_In_Vehicle",
    "GTAO_ImpExp_Enter_Exit_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "PUSH",
    "DLC_APT_YACHT_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "WOODEN_DOOR_OPEN_HANDLE_AT",
    "0"
  ),
 new Tuple<string,string>(
    "LIMIT",
    "DLC_APT_YACHT_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "WOODEN_DOOR_CLOSING_AT",
    "0"
  ),
 new Tuple<string,string>(
    "SWING_SHUT",
    "GTAO_APT_DOOR_DOWNSTAIRS_WOOD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Closed",
    "DLC_APT_YACHT_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "SWING_SHUT",
    "GTAO_APT_DOOR_DOWNSTAIRS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "SWING_SHUT",
    "GTAO_APT_DOOR_ROOF_METAL_SOUNDS"
  ),
 new Tuple<string,string>(
    "SWING_SHUT",
    "GTAO_APT_DOOR_DOWNSTAIRS_GLASS_SOUNDS"
  ),
 new Tuple<string,string>(
    "WOODEN_DOOR_CLOSED_AT",
    "0"
  ),
 new Tuple<string,string>(
    "Speech_Floor_1",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Speech_Floor_2",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Speech_Floor_3",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Tone",
    "LIFT_POSH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Fake_Game",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Elevator_Start",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Elevator_Stop",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Elevator_Ascending_Loop",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Elevator_Descending_Loop",
    "DLC_IE_Garage_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "10_SEC_WARNING",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TIMER_STOP",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Target_Activate",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Deactivate",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Hit_Head_Black",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Hit_Head_Red",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Hit_Body_Black",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Hit_Body_Red",
    "DLC_GR_Bunker_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "GO",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "3_2_1",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Delivery_Screen_Fade",
    "DLC_Exec1_Buy_Sell_Sounds"
  ),
 new Tuple<string,string>(
    "Delivery_Screen_Fade_On_Foot",
    "DLC_Exec1_Buy_Sell_Sounds"
  ),
 new Tuple<string,string>(
    "Helicopter_Prompt_Exit",
    "0"
  ),
 new Tuple<string,string>(
    "Moonpool_Prompt_Exit",
    "0"
  ),
 new Tuple<string,string>(
    "Crush",
    "DLC_H4_Submarine_Crush_Depth_Sounds"
  ),
 new Tuple<string,string>(
    "Creaking_Loop",
    "DLC_H4_Submarine_Crush_Depth_Sounds"
  ),
 new Tuple<string,string>(
    "Warning_Alarm_Loop",
    "DLC_H4_Submarine_Crush_Depth_Sounds"
  ),
 new Tuple<string,string>(
    "VULKAN_LOCK_ON_AMBER",
    "0"
  ),
 new Tuple<string,string>(
    "VULKAN_LOCK_ON_RED",
    "0"
  ),
 new Tuple<string,string>(
    "Fire",
    "DLC_BTL_Terrobyte_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "Background_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_ZOOM",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_TURN",
    "0"
  ),
 new Tuple<string,string>(
    "Turret_Camera_Hum_Loop",
    "DLC_BTL_Terrobyte_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "ERROR",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "BACK",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "Purchase_Upgrade",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "SELECT",
    "DLC_EXEC_Warehouse_Upgrade_Bench_Sounds"
  ),
 new Tuple<string,string>(
    "ExitWater",
    "GTAO_Hot_Tub_PED_INSIDE_WATER"
  ),
 new Tuple<string,string>(
    "PED_INSIDE_WATER",
    "0"
  ),
 new Tuple<string,string>(
    "Engine",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Deck",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Hot_Tub_Loop",
    "GTAO_Yacht_SoundSet"
  ),
 new Tuple<string,string>(
    "Clothes_On",
    "GTAO_Hot_Tub_Sounds"
  ),
 new Tuple<string,string>(
    "Clothes_Off",
    "GTAO_Hot_Tub_Sounds"
  ),
 new Tuple<string,string>(
    "CLOSED",
    "DLC_APT_YACHT_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "Moor_SEASHARK_Engine",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Moor_Boat_Engine",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Parcel_Vehicle_Lost",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "EXIT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "OOB_Cancel",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "OOB_Start",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "OOB_Timer_Dynamic",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Apt_Style_Purchase",
    "DLC_APT_Apartment_SoundSet"
  ),
 new Tuple<string,string>(
    "Ride_Stop",
    "DLC_IND_ROLLERCOASTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Bar_Unlock_And_Raise",
    "DLC_IND_ROLLERCOASTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Bar_Lower_And_Lock",
    "DLC_IND_ROLLERCOASTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Scan_Success",
    "Scan_Fail"
  ),
 new Tuple<string,string>(
    "Scan_Ped_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Lost_Target",
    "0"
  ),
 new Tuple<string,string>(
    "Bleep",
    "0"
  ),
 new Tuple<string,string>(
    "Fly_Loop",
    "dlc_xm_avngr_sounds"
  ),
 new Tuple<string,string>(
    "Drive_Loop",
    "DLC_GR_MOC_Sounds"
  ),
 new Tuple<string,string>(
    "Background_Hum",
    "DLC_XM_Vehicle_Interior_Security_Camera_Sounds"
  ),
 new Tuple<string,string>(
    "PEYOTE_ATTRACT_SOUNDSET",
    "0"
  ),
 new Tuple<string,string>(
    "Click_Link",
    "DLC_H3_Arcade_Laptop_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Fail",
    "DLC_H3_Arcade_Laptop_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Special",
    "DLC_H3_Arcade_Laptop_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Back",
    "DLC_H3_Arcade_Laptop_Sounds"
  ),
 new Tuple<string,string>(
    "Exit",
    "DLC_H3_Arcade_Laptop_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Link",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Fail",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Back",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Exit",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Cancel",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Fail",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Special",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Business_Shutdown",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Business_Restart",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Popup_Confirm_Fail",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Back",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Exit",
    "DLC_Biker_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Menu_Accept",
    "0"
  ),
 new Tuple<string,string>(
    "Click_Link",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Fail",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Special",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Business_Shutdown",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Business_Restart",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Exit",
    "DLC_GR_Disruption_Logistics_Sounds"
  ),
 new Tuple<string,string>(
    "Click_Special",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Show_Overview_Menu",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Menu_Navigate",
    "0"
  ),
 new Tuple<string,string>(
    "Camera_Zoom",
    "0"
  ),
 new Tuple<string,string>(
    "Camera_Shoot",
    "0"
  ),
 new Tuple<string,string>(
    "Menu_Back",
    "0"
  ),
 new Tuple<string,string>(
    "Dial_and_Remote_Ring",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Ring",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Engaged",
    "0"
  ),
 new Tuple<string,string>(
    "Hang_Up",
    "0"
  ),
 new Tuple<string,string>(
    "Select_Mission_Cancel",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Mission_Unavailable",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Mission_Are_You_Sure",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Mission_Launch",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Mission_Unavailable_OK",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Logout",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Notification",
    "0"
  ),
 new Tuple<string,string>(
    "Log_In",
    "DLC_GR_MOC_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "ATM_WINDOW",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Click_Special",
    "WEB_NAVIGATION_SOUNDS_PHONE"
  ),
 new Tuple<string,string>(
    "Click_Special",
    " WEB_NAVIGATION_SOUNDS_PHONE"
  ),
 new Tuple<string,string>(
    "CLICK_BACK",
    "WEB_NAVIGATION_SOUNDS_PHONE"
  ),
 new Tuple<string,string>(
    "Popup_Confirm_Success",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Popup_Cancel",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Sell",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Navigate",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Mouse_Click",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Sell",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Error",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Confirm",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Cancel",
    "GTAO_Exec_SecuroServ_Warehouse_PC_Sounds"
  ),
 new Tuple<string,string>(
    "Logout",
    "GTAO_Exec_SecuroServ_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Show_Source_Menu",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Show_Sell_Menu",
    "GTAO_SMG_Hangar_Computer_Sounds"
  ),
 new Tuple<string,string>(
    "Lester_Laugh_Phone",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Exit_Menu",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Enter_Menu",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Turret",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Drone",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Select_RC_Car",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Trap_Cam",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Live_Stream",
    "DLC_AW_Spectator_Tablet_Sounds"
  ),
 new Tuple<string,string>(
    "MOD_SHOPS_UPGRADE_BLIP",
    "0"
  ),
 new Tuple<string,string>(
    "Engine_Rev",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "MOD_SHOPS_EXIT_ENGINE_BLIP",
    "0"
  ),
 new Tuple<string,string>(
    "MOD_SHOP_BRAKES_ONESHOT",
    "0"
  ),
 new Tuple<string,string>(
    "Exit_Engine_Blips",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Hood_Open",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Hood_Shut",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Open",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Shut",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Lowrider_Upgrade",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "SultanRS_Upgrade",
    "JA16_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Banshee2_Upgrade",
    "JA16_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Faction3_Upgrade",
    "Low2_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Weapon_Upgrade",
    "DLC_GR_Weapon_Upgrade_Soundset"
  ),
 new Tuple<string,string>(
    "supermod_consumer",
    "Arena_Vehicle_Mod_Shop_Sounds"
  ),
 new Tuple<string,string>(
    "supermod_scifi",
    "Arena_Vehicle_Mod_Shop_Sounds"
  ),
 new Tuple<string,string>(
    "supermod_wasteland",
    "Arena_Vehicle_Mod_Shop_Sounds"
  ),
 new Tuple<string,string>(
    "Super_Mod_Garage_Upgrade_Car_Default",
    "0"
  ),
 new Tuple<string,string>(
    "Trunk_Open",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Hydraulics_Up",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Trunk_Shut",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Hydraulics_Down",
    "Lowrider_Super_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "Remove_Tracker",
    "DLC_IO_Warehouse_Mod_Garage_Sounds"
  ),
 new Tuple<string,string>(
    "NAV",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MOD_SHOPS_ENTER_ENGINE_BLIP",
    "0"
  ),
 new Tuple<string,string>(
    "Lamar_Throttle_Blip",
    "0"
  ),
 new Tuple<string,string>(
    "Franklin_Throttle_Blip",
    "0"
  ),
 new Tuple<string,string>(
    "Idling_Throttle_Blip_Loop",
    "ARM_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Bike_Bell",
    "ARM_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Birds",
    "ARM_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Gas_Explosion",
    "ARM_2_REPO_SOUNDS"
  ),
 new Tuple<string,string>(
    "Garage_Open_01",
    "ARM_2_REPO_SOUNDS"
  ),
 new Tuple<string,string>(
    "Garage_Open_02",
    "ARM_2_REPO_SOUNDS"
  ),
 new Tuple<string,string>(
    "ARM_2_REPO_DOOR_KICK_OPEN",
    "0"
  ),
 new Tuple<string,string>(
    "Biker_Ride_Off",
    "ARM_2_REPO_SOUNDS"
  ),
 new Tuple<string,string>(
    "ARM_2_Repo_Ignite_Petrol",
    "0"
  ),
 new Tuple<string,string>(
    "GARDENING_LEAFBLOWER_ANIM_TRIGGERED",
    "0"
  ),
 new Tuple<string,string>(
    "ARM_3_CAR_GLASS_CRASH",
    "0"
  ),
 new Tuple<string,string>(
    "ARM_3_PISTOL_COCK",
    "0"
  ),
 new Tuple<string,string>(
    "CONTINUE",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "continue",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ASSASSINATIONS_HOTEL_TIMER_COUNTDOWN",
    "ASSASSINATION_MULTI"
  ),
 new Tuple<string,string>(
    "PIN_BUTTON",
    "ATM_SOUNDS"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_UNDER_THE_BRIDGE",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SPAWN",
    "BARRY_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DESPAWN",
    "BARRY_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MIND_CONTROL",
    "BARRY_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PLAYER_BEAMED_UP",
    "BARRY_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CROWD_WATCHING",
    "0"
  ),
 new Tuple<string,string>(
    "HOORAY",
    "BARRY_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "clown_die_wrapper",
    "BARRY_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "IGNITION_FAIL",
    "BARRY_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Helicopter_Wind_Idle",
    "BASEJUMPS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Helicopter_Wind",
    "BASEJUMPS_SOUNDS"
  ),
 new Tuple<string,string>(
    "BASE_JUMP_PASSED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_NORMAL",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_MISSED",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DLC_VW_BET_MAX",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "DLC_VW_ERROR_MAX",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "DLC_VW_BET_UP",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "DLC_VW_WIN_CHIPS",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "dlc_vw_table_games_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "sports_bag",
    "dlc_xm_pickup_sweetener_sounds"
  ),
 new Tuple<string,string>(
    "Air_Drop_Package",
    "DLC_SM_Generic_Mission_Sounds"
  ),
 new Tuple<string,string>(
    "Flyover",
    "DLC_Exec_Buy_Air_Drop_Sounds"
  ),
 new Tuple<string,string>(
    "download_start",
    "DLC_BTL_Break_In_Sounds"
  ),
 new Tuple<string,string>(
    "download_complete",
    "DLC_BTL_Break_In_Sounds"
  ),
 new Tuple<string,string>(
    "Bell_02",
    "ALARMS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DLC_BTL_Break_In_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "MP_AWARD",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Garage_Door_Unlocked",
    "DLC_BTL_Showroom_Sounds"
  ),
 new Tuple<string,string>(
    "5s",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "package_delivered_success",
    "DLC_GR_Generic_Mission_Sounds"
  ),
 new Tuple<string,string>(
    "package_delivered_success_remote",
    "DLC_GR_Generic_Mission_Sounds"
  ),
 new Tuple<string,string>(
    "Air_Drop_Parachute",
    "DLC_SM_Generic_Mission_Sounds"
  ),
 new Tuple<string,string>(
    "Parachute_Land",
    "DLC_Exec_Air_Drop_Sounds"
  ),
 new Tuple<string,string>(
    "TUMBLER_TURN",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TUMBLER_RESET",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TUMBLER_PIN_FALL",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TUMBLER_PIN_FALL_FINAL",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SAFE_DOOR_OPEN",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SAFE_DOOR_CLOSE",
    "SAFE_CRACK_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Safe_Handle_Spin",
    "DLC_Biker_Cracked_Sounds"
  ),
 new Tuple<string,string>(
    "Safe_Door_Open",
    "DLC_Biker_Cracked_Sounds"
  ),
 new Tuple<string,string>(
    "Target_Counter_Tick",
    "DLC_SM_Generic_Mission_Sounds"
  ),
 new Tuple<string,string>(
    "Boss_Message_Orange",
    "0"
  ),
 new Tuple<string,string>(
    "Flyer_Drop",
    "DLC_BTL_Flyer_Promotion_Sounds"
  ),
 new Tuple<string,string>(
    "Crates_Blipped",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "car_fall",
    "DLC_BTL_Collector_Sounds"
  ),
 new Tuple<string,string>(
    "bottles_loop",
    "dlc_btl_stolen_supplies_Sounds"
  ),
 new Tuple<string,string>(
    "lock_break",
    "DLC_BTL_Collector_Sounds"
  ),
 new Tuple<string,string>(
    "stafford_fall",
    "DLC_BTL_Collector_Sounds"
  ),
 new Tuple<string,string>(
    "ramp_fall",
    "DLC_BTL_Collector_Sounds"
  ),
 new Tuple<string,string>(
    "Leave_Station",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "Running",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "DOOR_OPEN",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "DOOR_CLOSE",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "Arrive_Station",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "Interior_Rain",
    "CABLE_CAR_SOUNDS"
  ),
 new Tuple<string,string>(
    "CAR_STEAL_1_IGNITIONS",
    "CAR_STEAL_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TRUCK_HORN",
    "CAR_STEAL_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BUS_HORN",
    "CAR_STEAL_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Microphone",
    "POLICE_CHOPPER_CAM_SOUNDS"
  ),
 new Tuple<string,string>(
    "Garage_Open",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DISTANT_DOG_BARK",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Lost_Target",
    "POLICE_CHOPPER_CAM_SOUNDS"
  ),
 new Tuple<string,string>(
    "Found_Target",
    "POLICE_CHOPPER_CAM_SOUNDS"
  ),
 new Tuple<string,string>(
    "HIT_OUT",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_BACKGROUND",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_BLEEP",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_SCAN_PED_LOOP",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_SCAN_PED_SUCCESS",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_SCAN_PED_FAILURE",
    "0"
  ),
 new Tuple<string,string>(
    "COP_HELI_CAM_BLEEP_TOO_FAR",
    "0"
  ),
 new Tuple<string,string>(
    "Pan_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Pan",
    "0"
  ),
 new Tuple<string,string>(
    "Zoom_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Zoom",
    "0"
  ),
 new Tuple<string,string>(
    "Thermal_Off",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Thermal_On",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pimp_Gunshot_Mic",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pimp_Gunshot",
    "CAR_STEAL_2_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CAR_STEAL_3_AGENT_TYRE_BURST",
    "CAR_STEAL_3_AGENT"
  ),
 new Tuple<string,string>(
    "CAR_THEFT_MOVIE_LOT_DROP_SPIKES",
    "0"
  ),
 new Tuple<string,string>(
    "CAR_THEFT_MOVIE_LOT_EJECT_SEAT",
    "0"
  ),
 new Tuple<string,string>(
    "Ejector_Scream",
    "CAR_STEAL_3_AGENT"
  ),
 new Tuple<string,string>(
    "FRANKLIN_GUN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "JB700_GUN_PLAYER_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "spikes",
    "CAR_THEFT_DB5_ESCAPE"
  ),
 new Tuple<string,string>(
    "tyre",
    "CAR_THEFT_DB5_ESCAPE"
  ),
 new Tuple<string,string>(
    "CAR_STEAL_4_RAMP_SCRAPE",
    "CAR_STEAL_4_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Destroy_Cop_Car",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "out",
    "SHORT_PLAYER_SWITCH_SOUND_SET"
  ),
 new Tuple<string,string>(
    "CAR_STEAL_4_BURNOUT",
    "CAR_STEAL_4_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SPRAY",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "DRYER",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "SPRAY_CAR",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "BRUSHES_SPINNING",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "BRUSHES_MOVE",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "BRUSHES_HIT_CAR",
    "CARWASH_SOUNDS"
  ),
 new Tuple<string,string>(
    "CHALLENGE_UNLOCKED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "dlc_vw_casino_lucky_wheel_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Win",
    "dlc_vw_casino_lucky_wheel_sounds"
  ),
 new Tuple<string,string>(
    "Spin_Single_Ticks",
    "dlc_vw_casino_lucky_wheel_sounds"
  ),
 new Tuple<string,string>(
    "Spin_Start",
    "dlc_vw_casino_lucky_wheel_sounds"
  ),
 new Tuple<string,string>(
    "no_win",
    "0"
  ),
 new Tuple<string,string>(
    "small_win",
    "0"
  ),
 new Tuple<string,string>(
    "big_win",
    "0"
  ),
 new Tuple<string,string>(
    "jackpot",
    "0"
  ),
 new Tuple<string,string>(
    "wheel_stop_clunk",
    "0"
  ),
 new Tuple<string,string>(
    "wheel_stop_on_prize",
    "0"
  ),
 new Tuple<string,string>(
    "welcome_stinger",
    "0"
  ),
 new Tuple<string,string>(
    "spin_wheel",
    "0"
  ),
 new Tuple<string,string>(
    "spin_wheel_win",
    "0"
  ),
 new Tuple<string,string>(
    "attract_loop",
    "0"
  ),
 new Tuple<string,string>(
    "Pre_Screen_Stinger",
    "DLC_HEISTS_FINALE_SCREEN_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pull_Out",
    "0"
  ),
 new Tuple<string,string>(
    "Hang_Up",
    "Phone_SoundSet_Michael"
  ),
 new Tuple<string,string>(
    "Put_Away",
    "0"
  ),
 new Tuple<string,string>(
    "CR_WEAPONS_BURST_SHORT",
    "0"
  ),
 new Tuple<string,string>(
    "Change_Station_Loud",
    "Radio_Soundset"
  ),
 new Tuple<string,string>(
    "FarmhouseFire_Ignite",
    "CHINESE2_SOUNDS"
  ),
 new Tuple<string,string>(
    "PICKUP_WEAPON_BALL",
    "HUD_FRONTEND_WEAPONS_PICKUPS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_FRONTEND_CLOTHESSHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_ARMOR",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_FRONTEND_CLOTHESSHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "HUD_FRONTEND_CLOTHESSHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_FRONTEND_CLOTHESSHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "End_Squelch",
    "CB_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "Start_Squelch",
    "CB_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "Background_Loop",
    "CB_RADIO_SFX"
  ),
 new Tuple<string,string>(
    "Radio_Off",
    "TAXI_SOUNDS"
  ),
 new Tuple<string,string>(
    "Radio_On",
    "TAXI_SOUNDS"
  ),
 new Tuple<string,string>(
    "Short_Transition_Out",
    "PLAYER_SWITCH_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MEDAL_UP",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "RACE_PLACED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "DISTANT_RACERS",
    "ROAD_RACE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SELECT",
    "0"
  ),
 new Tuple<string,string>(
    "ERROR",
    "0"
  ),
 new Tuple<string,string>(
    "BACK",
    "0"
  ),
 new Tuple<string,string>(
    "EDIT",
    "HUD_DEATHMATCH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DELETE",
    "HUD_DEATHMATCH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_POINT_WON",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "OTHER_TEXT",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "LOOSE_MATCH",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DARTS_SCOREBOARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CAM_PAN_DARTS",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MP_SNACKS_SOUNDSET",
    "0"
  ),
 new Tuple<string,string>(
    "WAYPOINT_SET",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Load_Scene",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Place_Prop_Fail",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Save_Scene",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Delete_Placed_Prop",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Select_Placed_Prop",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Prop_Drop_Water",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Prop_Drop_Land",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Place_Prop_Success",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Cycle_Item",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Rotate_Loop",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Move_Loop",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Elevation_Loop",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "Reset_Prop_Position",
    "DLC_Dmod_Prop_Editor_Sounds"
  ),
 new Tuple<string,string>(
    "BODY_FALL_DIVE_WATER_MASTER",
    "docks_heist_finale_2a_sounds"
  ),
 new Tuple<string,string>(
    "Attach_Cargo",
    "docks_heist_finale_2a_sounds"
  ),
 new Tuple<string,string>(
    "CONDUCTORS_PORT_OF_LS_2A_LOOP",
    "0"
  ),
 new Tuple<string,string>(
    "SNIPER_SHOT_ZIP",
    "DOCKS_HEIST_FINALE_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "SNIPER_SHOT_SPLAT",
    "DOCKS_HEIST_FINALE_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "SNIPER_SHOT_SPRAY",
    "DOCKS_HEIST_FINALE_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "rebreather",
    "docks_heist_finale_2a_sounds"
  ),
 new Tuple<string,string>(
    "uw_ambience",
    "0"
  ),
 new Tuple<string,string>(
    "foot_swish",
    "docks_heist_finale_2a_sounds"
  ),
 new Tuple<string,string>(
    "sonar_pulse",
    "docks_heist_finale_2a_sounds"
  ),
 new Tuple<string,string>(
    "All",
    "SHORT_PLAYER_SWITCH_SOUND_SET"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_DOWN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DOCKS_HEIST_FINALE_2A_SUB_LAND",
    "DOCKS_HEIST_FINALE_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "SWAP_POSITION",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Door_Open",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Missile_Incoming_Miss",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Missile_Incoming_Hit",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Sub_Lift",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Attach_Cargo",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "VEHICLE_WATER_SPLASH_HEAVY_SCRIPT",
    "0"
  ),
 new Tuple<string,string>(
    "UW_Ambience",
    "0"
  ),
 new Tuple<string,string>(
    "UW_Rebreather",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_05_RAID_FOOT_SWISH",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_05_RAID_BREATH",
    "0"
  ),
 new Tuple<string,string>(
    "SUB_RELEASE",
    "DOCKS_HEIST_PREP_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SUB_SPLASH",
    "DOCKS_HEIST_PREP_1_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DOCKS_HEIST_PREP_1_SUB_SWING",
    "0"
  ),
 new Tuple<string,string>(
    "DOCKS_HEIST_PREP_1_SUB_TILT",
    "0"
  ),
 new Tuple<string,string>(
    "DOCKS_HEIST_PREP_1_CABLE_SNAP",
    "0"
  ),
 new Tuple<string,string>(
    "Generic_Alarm_Electronic_01",
    "0"
  ),
 new Tuple<string,string>(
    "Floyd_Beating",
    "DOCKS_HEIST_SETUP_SOUNDS"
  ),
 new Tuple<string,string>(
    "Truck_Stop",
    "DOCKS_HEIST_SETUP_SOUNDS"
  ),
 new Tuple<string,string>(
    "CRANE_MOVE_U_D",
    "0"
  ),
 new Tuple<string,string>(
    "Move_L_R",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Clamp",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Move_Fail",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Move_U_D",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Move_Base",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Attach_Container_Fail",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Container_Impact",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Container_Impact_Land",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Strain",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Detach_Container",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Attach_Container",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Container_Release",
    "CONTAINER_LIFTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Container_Land",
    "CONTAINER_LIFTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "Container_Attach",
    "CONTAINER_LIFTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "CREAK_01",
    "DOCKS_HEIST_SETUP_SOUNDS"
  ),
 new Tuple<string,string>(
    "Strain_No_Container",
    "CRANE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Game_Over_Blink",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Music_Game_Over",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Insert_Coin",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Cancel",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Background",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Music_Win",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trail_1",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trail_2",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trail_3",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trail_4",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Turn",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Turn_NPC",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Crash",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Crash_NPC",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Go",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "321",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Ready",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Degenatron_Logo",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Degenatron_Star",
    "DLC_EXEC_ARC_MAC_SOUNDS"
  ),
 new Tuple<string,string>(
    "CLOSED",
    "DOOR_GARAGE"
  ),
 new Tuple<string,string>(
    "CLOSING",
    "DOOR_GARAGE"
  ),
 new Tuple<string,string>(
    "OPENED",
    "DOOR_GARAGE"
  ),
 new Tuple<string,string>(
    "OPENING",
    "DOOR_GARAGE"
  ),
 new Tuple<string,string>(
    "CONTINUAL_BEEP",
    "EPSILONISM_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "IDLE_BEEP",
    "EPSILONISM_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SCAN",
    "EPSILONISM_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DEVICE",
    "EPSILONISM_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "IDLE_BEEP_NPC",
    "EPSILONISM_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Falling_Crates",
    "EXILE_1"
  ),
 new Tuple<string,string>(
    "Transition_Sound",
    "EXILE_1"
  ),
 new Tuple<string,string>(
    "Pt2_Fail",
    "exile_1"
  ),
 new Tuple<string,string>(
    "EXILE_1",
    "0"
  ),
 new Tuple<string,string>(
    "Generic_Alarm_Fire_Electronic",
    "0"
  ),
 new Tuple<string,string>(
    "SPL_RPG_DIST_FLIGHT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Jet_Explosions",
    "exile_1"
  ),
 new Tuple<string,string>(
    "CHOP_CAM_A",
    "0"
  ),
 new Tuple<string,string>(
    "CHOP_CAM_B",
    "0"
  ),
 new Tuple<string,string>(
    "CHOP_CAM_C",
    "0"
  ),
 new Tuple<string,string>(
    "Fire_RPG",
    "EXILE_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Fire_Missile_Loop",
    "EXILE_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Fire_RPG_On_Foot",
    "EXILE_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Missile_Warning_Sound",
    "EXILE_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "EXILE_2_GANG_CAR_FIRE",
    "0"
  ),
 new Tuple<string,string>(
    "BOAT_WAVE_HIT_SCRIPT",
    "0"
  ),
 new Tuple<string,string>(
    "EXILE_3_TRAIN_FALL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "EXILE_3_TYRE_CHIRPS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "EXILE_3_LAND_ON_TRAIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "EXILE_3_TRAIN_BRAKE_PULL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "EXILE_3_TRAIN_BRAKE_RELEASE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "WIND",
    "EXTREME_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PLAYER_AT_SPEED_FREEFALL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Scraping_Ramp",
    "EXTREME_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DOM",
    "EXTREME_04_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FAMILY1_JUMPTOYACHT",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_FAKE_RICOCHET",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_THROWN_OVERBOARD1",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_BOOM_SWING1",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_LAND_ON_BONNET",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY_1_CAR_BREAKDOWN",
    "FAMILY1_BOAT"
  ),
 new Tuple<string,string>(
    "FAMILY_1_CAR_BREAKDOWN_ADDITIONAL",
    "FAMILY1_BOAT"
  ),
 new Tuple<string,string>(
    "FAMILY1_DROP_IN_CAR",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_BOX_HIT_FRANKLIN",
    "0"
  ),
 new Tuple<string,string>(
    "TEST_SCREAM_LONG",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY1_CAR_CRASH_BIG",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY3_REAR_END_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY3_CABLE_STRAIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "FAMILY3_POST_DEBRIS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "UNHITCH_TRAILER",
    "FAM4_UNHITCH_TRAILER"
  ),
 new Tuple<string,string>(
    "FAMILY_5_SOUNDS",
    "0"
  ),
 new Tuple<string,string>(
    "FLYING_STREAM_END_INSTANT",
    "FAMILY_5_SOUNDS"
  ),
 new Tuple<string,string>(
    "MICHAEL_LONG_SCREAM",
    "FAMILY_5_SOUNDS"
  ),
 new Tuple<string,string>(
    "YOGA_FAIL",
    "FAMILY_5_SOUNDS"
  ),
 new Tuple<string,string>(
    "YOGA_INHALE",
    "FAMILY_5_SOUNDS"
  ),
 new Tuple<string,string>(
    "YOGA_EXHALE",
    "FAMILY_5_SOUNDS"
  ),
 new Tuple<string,string>(
    "Snip_Ponytail",
    "FAMILY_6_SOUNDS"
  ),
 new Tuple<string,string>(
    "Tattoo",
    "FAMILY_6_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pierce",
    "FAMILY_6_SOUNDS"
  ),
 new Tuple<string,string>(
    "Amanda_Pulls_Away",
    "FAMILY_6_SOUNDS"
  ),
 new Tuple<string,string>(
    "FRANKLINS_HOUSE_SECURITY_LIGHT_ON",
    "0"
  ),
 new Tuple<string,string>(
    "FRANKLINS_HOUSE_SECURITY_LIGHT_OFF",
    "0"
  ),
 new Tuple<string,string>(
    "MICHAELS_HOUSE_DAUGHTER_SICK_ONESHOT",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_01_DMW_GARBAGE_LAND",
    "FBI_01_DMW_02_SOUNDS"
  ),
 new Tuple<string,string>(
    "PICK_UP_PARACHUTE",
    "HUD_FRONTEND_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FBI_01_DMW_LIFT_ARRIVE",
    "FBI_01_SOUNDS"
  ),
 new Tuple<string,string>(
    "UNZIP",
    "FBI_01_SOUNDS"
  ),
 new Tuple<string,string>(
    "FBI_02_SNATCH_AND_GRAB_HELI_DOWN",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_02_SNATCH_AND_GRAB_DANGLE",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Sniper_Rifle_Fire",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_02_SNATCH_AND_GRAB_SMASH_WINDOW",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_02_SNATCH_AND_GRAB_AMB_HELI",
    "0"
  ),
 new Tuple<string,string>(
    "Party_panic",
    "FBI_03_Torture_Sounds"
  ),
 new Tuple<string,string>(
    "Teeth_Initial_Pain",
    "FBI_03_Torture_Sounds"
  ),
 new Tuple<string,string>(
    "PED_PHONE_DIAL_01",
    "0"
  ),
 new Tuple<string,string>(
    "SIRENS_DISTANT_01_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Distant_Sirens_Skip_Start",
    "FBI_04_HEAT_SOUNDS"
  ),
 new Tuple<string,string>(
    "Garbage_Truck_Explosion",
    "FBI_04_HEAT_SOUNDS"
  ),
 new Tuple<string,string>(
    "Distant_Sirens",
    "FBI_04_HEAT_SOUNDS"
  ),
 new Tuple<string,string>(
    "Distant_Sirens",
    "0"
  ),
 new Tuple<string,string>(
    "FBI_04_HEAT_C4_DOORS",
    "0"
  ),
 new Tuple<string,string>(
    "Securicar_Horn",
    "FBI_04_HEAT_SOUNDS"
  ),
 new Tuple<string,string>(
    "Tow_truck_damage",
    "FBI_04_HEAT_SOUNDS"
  ),
 new Tuple<string,string>(
    "Torch",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Bar_Cut",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Torch_Cut",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Shoot_Door",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Release_Crate",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Crate_Land",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Cable_Strain",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gasmask",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Monkey_Yell",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Monkey_Scream",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Scientist_Approaching",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "LIFT_POSH_MOVE",
    "0"
  ),
 new Tuple<string,string>(
    "Move_Fade_In",
    "LIFT_POSH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Grate_Release",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Flare",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Speech_Bubble",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "Foot_Swish",
    "FBI_05_SOUNDS"
  ),
 new Tuple<string,string>(
    "FINALE_PETROL_SPILL",
    "0"
  ),
 new Tuple<string,string>(
    "FINALE_C2_DEVIN_INSIDE_TRUNK_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CAR_WHEELS",
    "FINALE_C2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Car_Push_Flex",
    "FINALE_C2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Camera_Zoom",
    "BIG_SCORE_SETUP_SOUNDS"
  ),
 new Tuple<string,string>(
    "Camera_Hum",
    "BIG_SCORE_SETUP_SOUNDS"
  ),
 new Tuple<string,string>(
    "TRAFFIC_CONTROL_CHANGE_CAM",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "TRAFFIC_CONTROL_MOVE_CROSSHAIR",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "TRAFFIC_CONTROL_TOGGLE_LIGHT",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Traffic_Control_Light_Switch_Back",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "TRAFFIC_CONTROL_BG_NOISE",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Traffic_Control_Fail",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Traffic_Control_Fail_Blank",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Truck_Ramp_Scrape",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gas_Tanker_Explosion",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Truck_Ramp_Raise",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Muscle_Jump",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Muscle_Land",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "SIREN_BLIP",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gold_Trolley_Roll_Player",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gold_Trolley_Roll_NPC",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "FREIGHT_ELEVATOR_01_DOOR_OPEN",
    "0"
  ),
 new Tuple<string,string>(
    "FREIGHT_ELEVATOR_01_DOOR_CLOSE",
    "0"
  ),
 new Tuple<string,string>(
    "VAULT_DOOR_CLOSE",
    "0"
  ),
 new Tuple<string,string>(
    "FREIGHT_ELEVATOR_01_MOTOR",
    "0"
  ),
 new Tuple<string,string>(
    "BANK_DOOR_OPEN",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "BLOWOUT",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "BLOWOUT_B",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "DROP_STINGER",
    "BIG_SCORE_3A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gold_Cage_Collisions",
    "BIG_SCORE_3B_SOUNDS"
  ),
 new Tuple<string,string>(
    "SPL_RPG_NPC_SHOT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CUTTER",
    "BIG_SCORE_3B_SOUNDS"
  ),
 new Tuple<string,string>(
    "Gold_Vault_Explosions",
    "BIG_SCORE_3B_SOUNDS"
  ),
 new Tuple<string,string>(
    "ELECTRO_MAGNET_DRONE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TRAIN_PICK_UP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TRAIN_PICK_UP_IMPACT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "HELI_TURNING_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TRAIN_SWITCH_TRACKS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "UNDER_THE_BRIDGE",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "On_Call_Player_Join",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "BOATS_PLANES_HELIS_BOOM",
    "MP_LOBBY_SOUNDS"
  ),
 new Tuple<string,string>(
    "CAR_BIKE_WHOOSH",
    "MP_LOBBY_SOUNDS"
  ),
 new Tuple<string,string>(
    "Whoosh_1s_R_to_L",
    "MP_LOBBY_SOUNDS"
  ),
 new Tuple<string,string>(
    "Whoosh_1s_L_to_R",
    "MP_LOBBY_SOUNDS"
  ),
 new Tuple<string,string>(
    "MP_5_SECOND_TIMER",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_FRONTEND_MP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Back",
    "0"
  ),
 new Tuple<string,string>(
    "Select",
    "0"
  ),
 new Tuple<string,string>(
    "SCREEN_FLASH",
    "CELEBRATION_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Continue_Accepted",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Continue_Appears",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_In",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Highlight_Cancel",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_Out",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Highlight_Move",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pen_Tick",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Highlight_Accept",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Highlight_Error",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_Right",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Map_Roll_Up",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_Left",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Map_Roll_Down",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Paper_Shuffle",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Alarm_Interior_Gate_Loop",
    "DLC_H4_Island_Alarms_Sounds"
  ),
 new Tuple<string,string>(
    "Alarm_Oneshot",
    "DLC_H4_Island_Alarms_Sounds"
  ),
 new Tuple<string,string>(
    "silo_alarm_loop",
    "dlc_xm_silo_finale_sounds"
  ),
 new Tuple<string,string>(
    "launch_power_up_loop",
    "dlc_xm_silo_finale_sounds"
  ),
 new Tuple<string,string>(
    "NET_RACE_START_EVENT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "health_lost",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Hit",
    "RESPAWN_ONLINE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Count_Stop",
    "0"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "Car_Club_Races_Pursuit_Series_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "Car_Club_Races_Street_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "Car_Club_Races_Pursuit_Series_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "Car_Club_Races_Street_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Orientation_Success",
    "DLC_Air_Race_Sounds_Player"
  ),
 new Tuple<string,string>(
    "Orientation_Fail",
    "DLC_Air_Race_Sounds_Player"
  ),
 new Tuple<string,string>(
    "Checkpoint_Buzz",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "Car_Club_Races_Pursuit_Series_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "Car_Club_Races_Street_Race_Sounds"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_AHEAD",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_BEHIND",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Out_Of_Ammo",
    "DLC_AW_Machine_Gun_Ammo_Counter_Sounds"
  ),
 new Tuple<string,string>(
    "Recharging_Loop",
    "DLC_AW_Machine_Gun_Ammo_Counter_Sounds"
  ),
 new Tuple<string,string>(
    "Empty_Fire_Fail",
    "DLC_AW_Machine_Gun_Ammo_Counter_Sounds"
  ),
 new Tuple<string,string>(
    "Recharged",
    "DLC_AW_Machine_Gun_Ammo_Counter_Sounds"
  ),
 new Tuple<string,string>(
    "1st_Place_Gain",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "1st_Place_Lose",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Place_Gain",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Place_Lose",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "tyre_burst",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "tyre_health_warning",
    "DLC_sum20_Open_Wheel_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Pit_Stop_Loop",
    "DLC_H3_Circuit_Racing_Sounds"
  ),
 new Tuple<string,string>(
    "Count_Start",
    "0"
  ),
 new Tuple<string,string>(
    "INFO",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Turret_Activated_Alt",
    "dlc_aw_Arena_Gun_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "Turret_Activated",
    "dlc_aw_Arena_Gun_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "DPAD_WEAPON_SCROLL",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Turret_Available_Alt",
    "dlc_aw_Arena_Gun_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "Turret_Available",
    "dlc_aw_Arena_Gun_Turret_Sounds"
  ),
 new Tuple<string,string>(
    "DLC_Stunt_Race_Alarms_Soundset",
    "0"
  ),
 new Tuple<string,string>(
    "DLC_Stunt_Race_Stinger_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Slipstream_Leader",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Slipstream_Follower",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Slipstream",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "SLIPSTREAM_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Arrow_Ahead",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Nav_Arrow_Behind",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Nav_Arrow_Left",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Nav_Arrow_Right",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Countdown_GO",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown_3",
    "0"
  ),
 new Tuple<string,string>(
    "321",
    "Car_Club_Races_Pursuit_Series_Sounds"
  ),
 new Tuple<string,string>(
    "321",
    "Car_Club_Races_Street_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_2",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown_1",
    "0"
  ),
 new Tuple<string,string>(
    "Go",
    "Car_Club_Races_Pursuit_Series_Sounds"
  ),
 new Tuple<string,string>(
    "Go",
    "Car_Club_Races_Street_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Open_Wheel_Racing_Start_Lights_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Round_Start_Blade",
    "POWER_PLAY_General_Soundset"
  ),
 new Tuple<string,string>(
    "FE_Intro_Banner",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "LEADER_BOARD",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Vehicle_Warp",
    "DLC_Air_Race_Sounds_Player"
  ),
 new Tuple<string,string>(
    "Beast_Sprint_Loop",
    "DLC_AR_Beast_Soundset"
  ),
 new Tuple<string,string>(
    "Beast_Jump",
    "DLC_AR_Beast_Soundset"
  ),
 new Tuple<string,string>(
    "Beast_Jump_Land",
    "DLC_AR_Beast_Soundset"
  ),
 new Tuple<string,string>(
    "Vehicle_Transform",
    "DLC_Air_Race_Sounds_Player"
  ),
 new Tuple<string,string>(
    "Beast_Attack",
    "DLC_AR_Beast_Soundset"
  ),
 new Tuple<string,string>(
    "Rocket_Detonate",
    "DLC_IE_VV_Rocket_Player_Sounds"
  ),
 new Tuple<string,string>(
    "SPIKES",
    "MP_RACE_SPIKES_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DLC_AW_Arena_Traps_Turntable_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "DLC_AW_Arena_Traps_Rams_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Idle",
    "0"
  ),
 new Tuple<string,string>(
    "Active",
    "0"
  ),
 new Tuple<string,string>(
    "Arm",
    "0"
  ),
 new Tuple<string,string>(
    "FIRST_PLACE",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Shard_Disappear",
    "GTAO_Biker_FM_Shard_Sounds"
  ),
 new Tuple<string,string>(
    "Shard_Disappear",
    "GTAO_Boss_Goons_FM_Shard_Sounds"
  ),
 new Tuple<string,string>(
    "PowerupShard_Disappear",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "Shard_Disappear",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Blade_Appear",
    "0"
  ),
 new Tuple<string,string>(
    "Resurrected",
    "DLC_SR_RS_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Reset_Win",
    "DLC_SR_RS_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Reset_Win",
    "DLC_SR_RS_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "shard",
    "dlc_vw_hidden_collectible_sounds"
  ),
 new Tuple<string,string>(
    "killer_down",
    "dlc_ch_hidden_collectibles_sk_sounds"
  ),
 new Tuple<string,string>(
    "PowerupShard_Appear",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "MP_RANK_UP",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DELETE",
    "0"
  ),
 new Tuple<string,string>(
    "Camera_Shoot",
    "Phone_Soundset_Franklin"
  ),
 new Tuple<string,string>(
    "ADD_SPAWN_POINT",
    "0"
  ),
 new Tuple<string,string>(
    "Creator_Snap",
    "DLC_Stunt_Race_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "PLACE_VEHICLE",
    "0"
  ),
 new Tuple<string,string>(
    "PLACE_OBJECT",
    "0"
  ),
 new Tuple<string,string>(
    "PLACE_ENEMY",
    "0"
  ),
 new Tuple<string,string>(
    "YES",
    "0"
  ),
 new Tuple<string,string>(
    "EDIT",
    "0"
  ),
 new Tuple<string,string>(
    "SELECT_LOCATION",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_FREEMODE_CANCEL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "collect_part",
    "DLC_sum20_BB_Captured_Sounds"
  ),
 new Tuple<string,string>(
    "06",
    "0"
  ),
 new Tuple<string,string>(
    "Air_Defences_Activated",
    "DLC_sum20_Business_Battle_AC_Sounds"
  ),
 new Tuple<string,string>(
    "Air_Defenses_Disabled",
    "DLC_sum20_Business_Battle_AC_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Fail",
    "DLC_sum20_Business_Battle_AC_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Success",
    "DLC_sum20_Business_Battle_AC_Sounds"
  ),
 new Tuple<string,string>(
    "door_unlocked",
    "dlc_sum20_factory_raid_sounds"
  ),
 new Tuple<string,string>(
    "Power_Down",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Beep_Red",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Beep_Green",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Success",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Put_Away",
    "Phone_SoundSet_Michael"
  ),
 new Tuple<string,string>(
    "Crash",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Failure",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Click",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Start",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trail_Custom",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Turn",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Goal",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Background",
    "DLC_HEIST_HACKING_SNAKE_SOUNDS"
  ),
 new Tuple<string,string>(
    "PRM2_BEDROOM_AMANDA_SNORE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Phone_Text_Arrive",
    "DLC_H4_MM_Sounds"
  ),
 new Tuple<string,string>(
    "Barge_Door",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Push",
    "GTAO_APT_DOOR_DOWNSTAIRS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Use_Fuse_Box_Foley_Only",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Use_Fuse_Box_Off",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Barge_Door_Metal",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Barge_Door_Glass",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Generic_Door_Closed",
    "GTAO_Script_Doors_Sounds"
  ),
 new Tuple<string,string>(
    "Barge_Door_Metal_Bars",
    "dlc_h4_Prep_FC_Sounds"
  ),
 new Tuple<string,string>(
    "Klaxon_03",
    "ALARMS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Scope_Spot_POI",
    "GTAO_Heists_HUD_Sounds"
  ),
 new Tuple<string,string>(
    "Zoom",
    "MP_CCTV_SOUNDSET"
  ),
 new Tuple<string,string>(
    "movie_prop",
    "DLC_SUM20_HIDDEN_COLLECTIBLES"
  ),
 new Tuple<string,string>(
    "Spawn_FE",
    "0"
  ),
 new Tuple<string,string>(
    "FE_Spawn",
    "DLC_Tuner_Halloween_Slasher_Soundset"
  ),
 new Tuple<string,string>(
    "Ingame_Spawn",
    "DLC_Tuner_Halloween_Slasher_Soundset"
  ),
 new Tuple<string,string>(
    "Character_Loop",
    "DLC_Tuner_Halloween_Slasher_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_FE",
    "DLC_Tuner_Halloween_Slasher_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_Ingame",
    "DLC_Tuner_Halloween_Slasher_Soundset"
  ),
 new Tuple<string,string>(
    "FE_Spawn",
    "DLC_Tuner_Halloween_Driver_Soundset"
  ),
 new Tuple<string,string>(
    "Ingame_Spawn",
    "DLC_Tuner_Halloween_Driver_Soundset"
  ),
 new Tuple<string,string>(
    "Character_Loop",
    "DLC_Tuner_Halloween_Driver_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_FE",
    "DLC_Tuner_Halloween_Driver_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_Ingame",
    "DLC_Tuner_Halloween_Driver_Soundset"
  ),
 new Tuple<string,string>(
    "FE_Spawn",
    "DLC_Tuner_Halloween_Psycho_Soundset"
  ),
 new Tuple<string,string>(
    "Ingame_Spawn",
    "DLC_Tuner_Halloween_Psycho_Soundset"
  ),
 new Tuple<string,string>(
    "Character_Loop",
    "DLC_Tuner_Halloween_Psycho_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_FE",
    "DLC_Tuner_Halloween_Psycho_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_Ingame",
    "DLC_Tuner_Halloween_Psycho_Soundset"
  ),
 new Tuple<string,string>(
    "FE_Spawn",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Ingame_Spawn",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Character_Loop",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Honk_Loop",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_FE",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Despawn_Ingame",
    "DLC_Tuner_Halloween_Clown_Soundset"
  ),
 new Tuple<string,string>(
    "Attach",
    "Prep_Signal_Jammers_Sounds"
  ),
 new Tuple<string,string>(
    "Collect_Pass",
    "Prep_Elevator_Pass_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Close",
    "LIFT_NORMAL_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Tone",
    "LIFT_NORMAL_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Push",
    "GTAO_APT_DOOR_DOWNSTAIRS_WOOD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Focus",
    "DLC_AW_Trap_Controller_Sounds"
  ),
 new Tuple<string,string>(
    "Next_Trap",
    "DLC_AW_Trap_Controller_Sounds"
  ),
 new Tuple<string,string>(
    "Previous_Trap",
    "DLC_AW_Trap_Controller_Sounds"
  ),
 new Tuple<string,string>(
    "Activate_Trap",
    "DLC_AW_Trap_Controller_Sounds"
  ),
 new Tuple<string,string>(
    "Go_To_Target",
    "DLC_AW_Trap_Controller_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Captured",
    "dlc_vw_koth_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Held",
    "dlc_vw_koth_Sounds"
  ),
 new Tuple<string,string>(
    "5S",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Start",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Finish_Win",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Finish_Default",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_GO",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_3",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_3",
    "DLC_SR_TR_General_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_2",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_2",
    "DLC_SR_TR_General_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_1",
    "DLC_AW_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_1",
    "DLC_SR_TR_General_Sounds"
  ),
 new Tuple<string,string>(
    "Airhorn",
    "DLC_TG_Running_Back_Sounds"
  ),
 new Tuple<string,string>(
    "Go_Kart_Death_Match_Soundset",
    "0"
  ),
 new Tuple<string,string>(
    "PowerupShard_Attract_Loop",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "Fire_Powerup_Amped",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "Fire_Loop",
    "DLC_IE_VV_Gun_Player_Sounds"
  ),
 new Tuple<string,string>(
    "30_Secs_Remaining",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "20_Secs_Remaining",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "10_Secs_Countdown",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "Powerup_Block_Loop",
    "Go_Kart_Death_Match_Soundset"
  ),
 new Tuple<string,string>(
    "Out_of_Bounds_Explode",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Bomb_Countdown",
    "DLC_AW_PTB_Sounds"
  ),
 new Tuple<string,string>(
    "Bomb_Passed",
    "DLC_AW_PTB_Sounds"
  ),
 new Tuple<string,string>(
    "Bomb_Collected",
    "DLC_AW_PTB_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Captured_Remote",
    "dlc_vw_koth_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Lost",
    "dlc_vw_koth_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Contested",
    "dlc_vw_koth_Sounds"
  ),
 new Tuple<string,string>(
    "MP_WAVE_COMPLETE",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Hit",
    "RESPAWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "HORDE_COOL_DOWN_TIMER",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pre_Screen_Stinger",
    "DLC_HEISTS_FAILED_SCREEN_SOUNDS"
  ),
 new Tuple<string,string>(
    "Cheers",
    "DLC_TG_Running_Back_Sounds"
  ),
 new Tuple<string,string>(
    "Whistle",
    "DLC_TG_Running_Back_Sounds"
  ),
 new Tuple<string,string>(
    "Round_End",
    "DLC_BTL_SM_Remix_Soundset"
  ),
 new Tuple<string,string>(
    "Round_End",
    "DLC_LOW2_Sumo_Soundset"
  ),
 new Tuple<string,string>(
    "Match_End",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "Payment_Player",
    "DLC_HEISTS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Payment_Non_Player",
    "DLC_HEISTS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Mission_Pass_Notify",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Nightvision_Loop",
    "GTAO_Vision_Modes_SoundSet"
  ),
 new Tuple<string,string>(
    "Thermal_Loop",
    "GTAO_Vision_Modes_SoundSet"
  ),
 new Tuple<string,string>(
    "Put_On_Mask",
    "DLC_HEISTS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "vault_unlock",
    "dlc_heist_fleeca_bank_door_sounds"
  ),
 new Tuple<string,string>(
    "Gain_Point",
    "dlc_xm_aqo_sounds"
  ),
 new Tuple<string,string>(
    "Swap_Sides",
    "0"
  ),
 new Tuple<string,string>(
    "Swap_Sides",
    "DLC_HALLOWEEN_FVJ_Sounds"
  ),
 new Tuple<string,string>(
    "Goggles_Update",
    "DLC_XM17_Silo_Pred_Sounds"
  ),
 new Tuple<string,string>(
    "elevator_descend_loop",
    "dlc_xm_IAA_Finale_sounds"
  ),
 new Tuple<string,string>(
    "ROUND_ENDING_STINGER_CUSTOM",
    "CELEBRATION_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Beast_Checkpoint",
    "0"
  ),
 new Tuple<string,string>(
    "Player_Collect",
    "DLC_PILOT_MP_HUD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Checkpoint_Collect",
    "DLC_SR_TR_General_Sounds"
  ),
 new Tuple<string,string>(
    "CHECKPOINT_PERFECT",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Bomb_Disarmed",
    "GTAO_Speed_Convoy_Soundset"
  ),
 new Tuple<string,string>(
    "Player_Enter_Line",
    "GTAO_FM_Cross_The_Line_Soundset"
  ),
 new Tuple<string,string>(
    "Exit_Capture_Zone",
    "0"
  ),
 new Tuple<string,string>(
    "Player_Exit_Line",
    "GTAO_FM_Cross_The_Line_Soundset"
  ),
 new Tuple<string,string>(
    "Friend_Pick_Up",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Beast_Attack",
    "0"
  ),
 new Tuple<string,string>(
    "Become_JN",
    "DLC_GR_PM_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_JN_VFX",
    "DLC_GR_PM_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_JN_VFX",
    "DLC_BTL_TP_Remix_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_JN_VFX",
    "DLC_IE_JN_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Zone_Captured",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Captured_Remote",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Lost",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Contested",
    "0"
  ),
 new Tuple<string,string>(
    "Stop",
    "0"
  ),
 new Tuple<string,string>(
    "Deactivate",
    "0"
  ),
 new Tuple<string,string>(
    "Hover_Unlock",
    "DLC_XM17_IAA_Deluxos_Sounds"
  ),
 new Tuple<string,string>(
    "Flight_Unlock",
    "DLC_XM17_IAA_Deluxos_Sounds"
  ),
 new Tuple<string,string>(
    "Arming_Countdown",
    "GTAO_Speed_Convoy_Soundset"
  ),
 new Tuple<string,string>(
    "Bomb_Armed",
    "GTAO_Speed_Convoy_Soundset"
  ),
 new Tuple<string,string>(
    "Out_of_Bounds",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Drone_View",
    "DLC_GR_WVM_APC_Sounds"
  ),
 new Tuple<string,string>(
    "Team_Vehicle_Destroyed",
    "DLC_LOW2_Sumo_Soundset"
  ),
 new Tuple<string,string>(
    "Vehicle_Destroyed",
    "DLC_LOW2_Sumo_Soundset"
  ),
 new Tuple<string,string>(
    "5_Second_Timer",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Timer_10s",
    "DLC_TG_Dinner_Sounds"
  ),
 new Tuple<string,string>(
    "Timer_To_Night",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "Timer_To_Day",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "Timer_5s",
    "DLC_TG_Dinner_Sounds"
  ),
 new Tuple<string,string>(
    "Oneshot_Final",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "10s",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Explosion_Countdown",
    "0"
  ),
 new Tuple<string,string>(
    "Explosion_Timer",
    "0"
  ),
 new Tuple<string,string>(
    "Brawl_Start_Oneshot",
    "dlc_vw_hk_sounds"
  ),
 new Tuple<string,string>(
    "Brawl_Walla_Loop",
    "dlc_vw_hk_sounds"
  ),
 new Tuple<string,string>(
    "Wasted",
    "DLC_IE_VV_General_Sounds"
  ),
 new Tuple<string,string>(
    "Become_Attacker",
    "DLC_IE_JN_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Become_Attacker",
    "DLC_BTL_TP_Remix_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Losing_Team_Shard",
    "DLC_Exec_TP_SoundSet"
  ),
 new Tuple<string,string>(
    "Crash",
    "0"
  ),
 new Tuple<string,string>(
    "Crash",
    "DLC_Biker_DL_Sounds"
  ),
 new Tuple<string,string>(
    "Bomb_Detonate",
    "0"
  ),
 new Tuple<string,string>(
    "Bomb_Timer_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Camera_Destroy",
    "DLC_HEIST_FLEECA_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Security_Box_Online",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Camera_Online",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Zone_Neutral",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Team_Capture",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Enemy_Capture",
    "0"
  ),
 new Tuple<string,string>(
    "Door_Open_Limit",
    "DLC_XM_Silo_Secret_Door_Sounds"
  ),
 new Tuple<string,string>(
    "Prop_Flash",
    "0"
  ),
 new Tuple<string,string>(
    "Prop_Delete",
    "0"
  ),
 new Tuple<string,string>(
    "Screech",
    "DLC_HEIST_BIOLAB_MONKEYS_SOUNDS"
  ),
 new Tuple<string,string>(
    "General_Chatter",
    "DLC_HEIST_BIOLAB_MONKEYS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Cage_Rattle",
    "DLC_HEIST_BIOLAB_MONKEYS_SOUNDS"
  ),
 new Tuple<string,string>(
    "Flare",
    "DLC_HEISTS_BIOLAB_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Flare",
    "DLC_GR_DR_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Crashed_Plane_Ambience",
    "DLC_Apartments_Extraction_SoundSet"
  ),
 new Tuple<string,string>(
    "Powerup_Despawn",
    "0"
  ),
 new Tuple<string,string>(
    "Powerup_Respawn",
    "POWER_PLAY_General_Soundset"
  ),
 new Tuple<string,string>(
    "transform_oneshot",
    "dlc_xm_stromberg_sounds"
  ),
 new Tuple<string,string>(
    "tag_entity",
    "dlc_xm_heists_iaa_morgue_sounds"
  ),
 new Tuple<string,string>(
    "Beacon",
    "DLC_GR_WVM_MOC_Soundset"
  ),
 new Tuple<string,string>(
    "Armed",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown",
    "0"
  ),
 new Tuple<string,string>(
    "Beacon",
    "0"
  ),
 new Tuple<string,string>(
    "Fire_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Use_Bunnyhop",
    "DLC_Biker_DL_Sounds"
  ),
 new Tuple<string,string>(
    "Use_Boost",
    "DLC_Biker_DL_Sounds"
  ),
 new Tuple<string,string>(
    "Use_Zoned",
    "DLC_Biker_DL_Sounds"
  ),
 new Tuple<string,string>(
    "Last_Alive",
    "DLC_SR_RS_Player_Sounds"
  ),
 new Tuple<string,string>(
    "submarine_sunk",
    "dlc_xm_submarine_sounds"
  ),
 new Tuple<string,string>(
    "Bounds_Timer_Pulse",
    "DLC_SM_VEHWA_Player_Sounds"
  ),
 new Tuple<string,string>(
    "TIMER_RADIAL_Pulse",
    "DLC_AS_TRP_Sounds"
  ),
 new Tuple<string,string>(
    "TIMER_RADIAL_Pulse",
    "DLC_BTL_SM_Remix_Soundset"
  ),
 new Tuple<string,string>(
    "TIMER_RADIAL_Reset",
    "DLC_AS_TRP_Sounds"
  ),
 new Tuple<string,string>(
    "TIMER_RADIAL_Reset",
    "DLC_BTL_SM_Remix_Soundset"
  ),
 new Tuple<string,string>(
    "Hack_Start",
    "DLC_IE_SVM_Voltic2_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Loop",
    "DLC_IE_SVM_Voltic2_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Complete",
    "DLC_IE_SVM_Voltic2_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "power_on",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "End_Zone_Flash",
    "DLC_BTL_RB_Remix_Sounds"
  ),
 new Tuple<string,string>(
    "Carrying",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "dlc_ch_heist_finale_poison_gas_coughs_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Beast_Sprint_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Beast_Jump",
    "0"
  ),
 new Tuple<string,string>(
    "Beast_Jump_Land",
    "0"
  ),
 new Tuple<string,string>(
    "Beast_Cloak",
    "0"
  ),
 new Tuple<string,string>(
    "Beast_Uncloak",
    "0"
  ),
 new Tuple<string,string>(
    "Transmitter_Beeps",
    "DLC_GR_DR_Player_Sounds"
  ),
 new Tuple<string,string>(
    "NightFall_Stinger",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "DayBreak_Stinger",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "Round_End",
    "0"
  ),
 new Tuple<string,string>(
    "Round_Start",
    "0"
  ),
 new Tuple<string,string>(
    "Reset_Timer",
    "0"
  ),
 new Tuple<string,string>(
    "Vehicle_Transform",
    "dlc_xm_aqo_sounds"
  ),
 new Tuple<string,string>(
    "Become_Slasher",
    "dlc_xm_sls_Sounds"
  ),
 new Tuple<string,string>(
    "Become_Hunted",
    "dlc_xm_sls_Sounds"
  ),
 new Tuple<string,string>(
    "Next_Level_Gun",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "Next_Level_Explosive",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "Next_Level_Melee",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "Next_Level_Generic",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "R2_Boost",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Teammate_Checkpoint",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Take_First",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Lose_First",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Out_Of_Range",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "In_Range",
    "DLC_Biker_SL_Sounds"
  ),
 new Tuple<string,string>(
    "Period_Start",
    "DLC_AW_BB_Sounds"
  ),
 new Tuple<string,string>(
    "Become_Target",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "No_Longer_Target",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "Collect_Pickup",
    "DLC_IE_PL_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Collect_Pickup",
    "DLC_IE_PL_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Collect_Pickup",
    "DLC_IE_PL_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Pickup",
    "DLC_IE_PL_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Pickup",
    "DLC_IE_PL_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Pickup",
    "DLC_IE_PL_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Up",
    "DLC_IE_PL_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Up",
    "DLC_IE_PL_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Up",
    "DLC_IE_PL_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Down",
    "DLC_IE_PL_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Down",
    "DLC_IE_PL_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Down",
    "DLC_IE_PL_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_To_Win",
    "DLC_IE_PL_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_To_Win",
    "DLC_IE_PL_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Timer_10s",
    "0"
  ),
 new Tuple<string,string>(
    "alarm_loop",
    "dlc_xm_farm_sounds"
  ),
 new Tuple<string,string>(
    "alarm_loop",
    "dlc_xm_submarine_sounds"
  ),
 new Tuple<string,string>(
    "Condemned_Heartbeat",
    "DLC_SM_CND_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Condemned",
    "DLC_SM_CND_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Uncondemned",
    "DLC_SM_CND_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Trash_Bag_Land",
    "DLC_HEIST_SERIES_A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Bus_Schedule_Pickup",
    "DLC_PRISON_BREAK_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "Metal_Detector_Offline",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Security_Box_Offline_Gun",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Metal_Detector_Online",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "keypad_break",
    "dlc_ch_heist_thermal_charge_sounds"
  ),
 new Tuple<string,string>(
    "Gate_Lock_Break",
    "DLC_HEISTS_ORNATE_BANK_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Hack_Success_Remote",
    "0"
  ),
 new Tuple<string,string>(
    "Test_Circuit",
    "0"
  ),
 new Tuple<string,string>(
    "Hack_Fail",
    "0"
  ),
 new Tuple<string,string>(
    "Hack_Fail_Remote",
    "0"
  ),
 new Tuple<string,string>(
    "Grab_Wire",
    "0"
  ),
 new Tuple<string,string>(
    "Attach_Wire",
    "0"
  ),
 new Tuple<string,string>(
    "Error",
    "0"
  ),
 new Tuple<string,string>(
    "Output_Highlight",
    "0"
  ),
 new Tuple<string,string>(
    "Input_Highlight",
    "0"
  ),
 new Tuple<string,string>(
    "laptop_download_loop",
    "dlc_xm_heists_iaa_morgue_sounds"
  ),
 new Tuple<string,string>(
    "generator_on_loop",
    "dlc_xm_stealavg_sounds"
  ),
 new Tuple<string,string>(
    "handle_up",
    "dlc_xm_stealavg_sounds"
  ),
 new Tuple<string,string>(
    "cash_room_door_button",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "Hit_Mirror",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Pass",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Pass_Remote",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Fail",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Fail_Remote",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Blue_Target_Explode",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Red_Target_Explode",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Node_Release",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Node_Select",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Background",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Blue_Target_Charge",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Red_Target_Charge",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Cursor_Move",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Rotate_Mirror",
    "dlc_xm_silo_laser_hack_sounds"
  ),
 new Tuple<string,string>(
    "Keycard_Success",
    "DLC_HEISTS_BIOLAB_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Keycard_Fail",
    "DLC_HEISTS_BIOLAB_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Hack_Failed",
    "DLC_HEIST_BIOLAB_PREP_HACKING_SOUNDS"
  ),
 new Tuple<string,string>(
    "HACKING_DOOR_UNLOCK_SOUNDS",
    "0"
  ),
 new Tuple<string,string>(
    "container_door",
    "dlc_prison_break_heist_sounds"
  ),
 new Tuple<string,string>(
    "DLC_AW_BB_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Explosion_Timer",
    "DLC_Lowrider_Relay_Race_Sounds"
  ),
 new Tuple<string,string>(
    "EMP_Vehicle_Hum",
    "DLC_HEIST_BIOLAB_DELIVER_EMP_SOUNDS"
  ),
 new Tuple<string,string>(
    "Hack_Loop",
    "dlc_xm_deluxos_hacking_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Start",
    "dlc_xm_deluxos_hacking_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Stop",
    "dlc_xm_deluxos_hacking_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Stop",
    "DLC_IE_SVM_Voltic2_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "Remote_Friendly_Enter_Line",
    "GTAO_FM_Cross_The_Line_Soundset"
  ),
 new Tuple<string,string>(
    "Remote_Enemy_Enter_Line",
    "GTAO_FM_Cross_The_Line_Soundset"
  ),
 new Tuple<string,string>(
    "Enter_Capture_Zone",
    "0"
  ),
 new Tuple<string,string>(
    "Zone_Enter",
    "0"
  ),
 new Tuple<string,string>(
    "sub_scanner_loop",
    "dlc_xm_stromberg_sounds"
  ),
 new Tuple<string,string>(
    "cash_room_door_open",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "cash_room_door_open_end",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "cash_room_door_close_end",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "Garage_Door",
    "DLC_HEISTS_GENERIC_SOUNDS"
  ),
 new Tuple<string,string>(
    "Plane_Door_Open",
    "DLC_GR_WVM_Oppressor2_Sounds"
  ),
 new Tuple<string,string>(
    "Plane_Alarm_Loop",
    "DLC_GR_WVM_Oppressor2_Sounds"
  ),
 new Tuple<string,string>(
    "Hack_Complete",
    "dlc_xm_deluxos_hacking_Hacking_Sounds"
  ),
 new Tuple<string,string>(
    "lights_on",
    "dlc_xm_stealavg_sounds"
  ),
 new Tuple<string,string>(
    "EMP_Blast",
    "DLC_HEISTS_BIOLAB_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "EMP",
    "DLC_HALLOWEEN_FVJ_Sounds"
  ),
 new Tuple<string,string>(
    "EMP",
    "0"
  ),
 new Tuple<string,string>(
    "Weapon_Disabled",
    "DLC_SR_LG_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Weapon_Enabled",
    "DLC_SR_LG_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Metal_Detector_Big_Guns",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Metal_Detector_Small_Guns",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Breaker_02",
    "0"
  ),
 new Tuple<string,string>(
    "Enter_Area",
    "DLC_Lowrider_Relay_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Out_Of_Area",
    "DLC_Lowrider_Relay_Race_Sounds"
  ),
 new Tuple<string,string>(
    "Round_Start",
    "DLC_LOW2_Sumo_Soundset"
  ),
 new Tuple<string,string>(
    "Round_Start",
    "DLC_BTL_SM_Remix_Soundset"
  ),
 new Tuple<string,string>(
    "Airhorn",
    "DLC_BTL_RB_Remix_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_GO",
    "DLC_SR_TR_General_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_Attacker_VFX",
    "DLC_BTL_TP_Remix_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_Attacker_VFX",
    "DLC_IE_JN_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_Local_Player",
    "DLC_Exec_TP_SoundSet"
  ),
 new Tuple<string,string>(
    "Transform_Loser_Local_Player",
    "DLC_Exec_TP_SoundSet"
  ),
 new Tuple<string,string>(
    "Period_Over",
    "DLC_AW_BB_Sounds"
  ),
 new Tuple<string,string>(
    "Breaker_01",
    "0"
  ),
 new Tuple<string,string>(
    "Match_Start",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "Round_Start_JN",
    "0"
  ),
 new Tuple<string,string>(
    "Cargobob_Door_Open",
    "0"
  ),
 new Tuple<string,string>(
    "Helicopter_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "CUTSCENE_DIALOGUE_OVERRIDE_SOUND_01",
    "0"
  ),
 new Tuple<string,string>(
    "CUTSCENE_DIALOGUE_OVERRIDE_SOUND_02",
    "0"
  ),
 new Tuple<string,string>(
    "vault_door_explosion",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "Leave_Horn",
    "DLC_Apartment_Yacht_Streams_Soundset"
  ),
 new Tuple<string,string>(
    "Arrive_Horn",
    "DLC_Apartment_Yacht_Streams_Soundset"
  ),
 new Tuple<string,string>(
    "JN_Death",
    "0"
  ),
 new Tuple<string,string>(
    "Enemy_Killed_1p",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "Enemy_Killed_3p",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "Team_Killed_1p",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "Team_Killed_3p",
    "dlc_xm_hata_Sounds"
  ),
 new Tuple<string,string>(
    "Become_JN",
    "DLC_IE_JN_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Become_JN",
    "DLC_BTL_TP_Remix_Juggernaut_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Winning_Team_Shard",
    "DLC_Exec_TP_SoundSet"
  ),
 new Tuple<string,string>(
    "Night_Die",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "Day_Die",
    "DLC_Biker_LostAndDamned_Sounds"
  ),
 new Tuple<string,string>(
    "Beast_Die",
    "0"
  ),
 new Tuple<string,string>(
    "Security_Box_Offline_Tazer",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "Camera_Offline",
    "dlc_ch_heist_finale_security_alarms_sounds"
  ),
 new Tuple<string,string>(
    "emp_activate",
    "dlc_ch_heist_finale_sounds"
  ),
 new Tuple<string,string>(
    "Score_Goal",
    "DLC_AW_BB_Sounds"
  ),
 new Tuple<string,string>(
    "LOCAL_PLYR_CASH_COUNTER_COMPLETE",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "LOCAL_PLYR_CASH_COUNTER_INCREASE",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "REMOTE_PLYR_CASH_COUNTER_COMPLETE",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "REMOTE_PLYR_CASH_COUNTER_INCREASE",
    "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS"
  ),
 new Tuple<string,string>(
    "Collect",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "Drop",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "Score",
    "DLC_Low2_Ibi_Sounds"
  ),
 new Tuple<string,string>(
    "Transform_Remote_Player",
    "DLC_Exec_TP_SoundSet"
  ),
 new Tuple<string,string>(
    "Player_Pick_Up",
    "In_And_Out_Attacker_Sounds"
  ),
 new Tuple<string,string>(
    "Friend_Pick_Up",
    "In_And_Out_Attacker_Sounds"
  ),
 new Tuple<string,string>(
    "Enemy_Pick_Up",
    "In_And_Out_Defender_Sounds"
  ),
 new Tuple<string,string>(
    "Dropped",
    "In_And_Out_Attacker_Sounds"
  ),
 new Tuple<string,string>(
    "Dropped",
    "In_And_Out_Defender_Sounds"
  ),
 new Tuple<string,string>(
    "Deliver",
    "In_And_Out_Attacker_Sounds"
  ),
 new Tuple<string,string>(
    "Enemy_Deliver",
    "In_And_Out_Defender_Sounds"
  ),
 new Tuple<string,string>(
    "Vehicle_Destroyed",
    "0"
  ),
 new Tuple<string,string>(
    "Successful_Landing",
    "0"
  ),
 new Tuple<string,string>(
    "Failed_Landing",
    "0"
  ),
 new Tuple<string,string>(
    "Reset_Win",
    "0"
  ),
 new Tuple<string,string>(
    "Lose_Powerup",
    "DLC_IE_VV_General_Sounds"
  ),
 new Tuple<string,string>(
    "Steal_Powerup",
    "DLC_IE_VV_General_Sounds"
  ),
 new Tuple<string,string>(
    "Bounds_Timer_Reset",
    "DLC_SM_VEHWA_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Prop_Reset",
    "0"
  ),
 new Tuple<string,string>(
    "police_notification",
    "DLC_AS_VNT_Sounds"
  ),
 new Tuple<string,string>(
    "Prop_Tagged",
    "0"
  ),
 new Tuple<string,string>(
    "Prop_Contested",
    "0"
  ),
 new Tuple<string,string>(
    "Loop",
    "0"
  ),
 new Tuple<string,string>(
    "",
    "0"
  ),
 new Tuple<string,string>(
    "Activate",
    "0"
  ),
 new Tuple<string,string>(
    "Bomb_Release",
    "0"
  ),
 new Tuple<string,string>(
    "Powerup_Collect_local",
    "0"
  ),
 new Tuple<string,string>(
    "Powerup_Collect_Remote",
    "0"
  ),
 new Tuple<string,string>(
    "Bomb_Collect",
    "DLC_SR_TR_Bomb_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Bomb_Collect",
    "DLC_SR_TR_Bomb_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Rocket_Collect",
    "DLC_SR_TR_Rocket_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Rocket_Collect",
    "DLC_SR_TR_Rocket_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Gun_Collect",
    "DLC_SR_TR_Gun_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Gun_Collect",
    "DLC_SR_TR_Gun_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Collect_Powerup",
    "0"
  ),
 new Tuple<string,string>(
    "Start",
    "0"
  ),
 new Tuple<string,string>(
    "Resurrected",
    "DLC_SR_RS_Team_Sounds"
  ),
 new Tuple<string,string>(
    "Resurrected",
    "DLC_SR_RS_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Powerup_Collect_Player",
    "0"
  ),
 new Tuple<string,string>(
    "Flag_Collected",
    "DLC_SM_STPI_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Flag_Collected",
    "DLC_SM_STPI_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Flag_Delivered",
    "DLC_SM_STPI_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Flag_Delivered",
    "DLC_SM_STPI_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Flag_Dropped",
    "DLC_SM_STPI_Player_Sounds"
  ),
 new Tuple<string,string>(
    "Flag_Dropped",
    "DLC_SM_STPI_Enemy_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Team",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "Score_Opponent",
    "DLC_Biker_KQ_Sounds"
  ),
 new Tuple<string,string>(
    "Goal_Reached",
    "dlc_xm_aqo_sounds"
  ),
 new Tuple<string,string>(
    "Beast_Checkpoint_NPC",
    "0"
  ),
 new Tuple<string,string>(
    "Checkpoint_Teammate",
    "GTAO_Shepherd_Sounds"
  ),
 new Tuple<string,string>(
    "Activate_From_Vehicle",
    "0"
  ),
 new Tuple<string,string>(
    "Powerup_Respawn",
    "0"
  ),
 new Tuple<string,string>(
    "Weapon_Respawn",
    "0"
  ),
 new Tuple<string,string>(
    "dlc_ch_heist_finale_HEALTH_DRAIN_ZONE_coughs_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Overheat_Loop",
    "DLC_H4_anims_glass_cutter_Sounds"
  ),
 new Tuple<string,string>(
    "StartCutting",
    "DLC_H4_anims_glass_cutter_Sounds"
  ),
 new Tuple<string,string>(
    "Overheated",
    "DLC_H4_anims_glass_cutter_Sounds"
  ),
 new Tuple<string,string>(
    "Input_Code_Enter_Correct",
    "Safe_Minigame_Sounds"
  ),
 new Tuple<string,string>(
    "Input_Code_Up",
    "Safe_Minigame_Sounds"
  ),
 new Tuple<string,string>(
    "Input_Code_Down",
    "Safe_Minigame_Sounds"
  ),
 new Tuple<string,string>(
    "Input_Code_Enter_Correct_Final",
    "Safe_Minigame_Sounds"
  ),
 new Tuple<string,string>(
    "Input_Code_Enter_Wrong",
    "Safe_Minigame_Sounds"
  ),
 new Tuple<string,string>(
    "Blowtorch_On",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "Blowtorch_Loop",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "Blowtorch_Off",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "Blowtorch_Cut_Loop",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "Cut_Final_Bar",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "Cut_Bar",
    "DLC_H4_Underwater_Blowtorch_Sounds"
  ),
 new Tuple<string,string>(
    "shotgun_shard",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "gadget_pistol_shard",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "BreakerDown",
    "DLC_H4_scripted_island_power_sounds"
  ),
 new Tuple<string,string>(
    "BreakerUp",
    "DLC_H4_scripted_island_power_sounds"
  ),
 new Tuple<string,string>(
    "Clothes_Swap",
    "GTAO_Change_Outfit_Sounds"
  ),
 new Tuple<string,string>(
    "Hack",
    "Military_Convoy_HiJack_Sounds"
  ),
 new Tuple<string,string>(
    "Remove_Keycard",
    "Twin_Card_Entry_Sounds"
  ),
 new Tuple<string,string>(
    "magnetic_explosion",
    "dlc_h4_heist_finale_sounds_soundset"
  ),
 new Tuple<string,string>(
    "Keycard_Success",
    "Twin_Card_Entry_Sounds"
  ),
 new Tuple<string,string>(
    "Keycard_Fail",
    "Twin_Card_Entry_Sounds"
  ),
 new Tuple<string,string>(
    "Insert_Keycard",
    "Twin_Card_Entry_Sounds"
  ),
 new Tuple<string,string>(
    "Fake_Close",
    "Union_Depository_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Elevator_Moving",
    "Union_Depository_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Fake_Arrival",
    "Union_Depository_Elevator_Sounds"
  ),
 new Tuple<string,string>(
    "Hang_Up",
    "Phone_SoundSet_Default"
  ),
 new Tuple<string,string>(
    "PowerUp",
    "DLC_H4_scripted_island_power_sounds"
  ),
 new Tuple<string,string>(
    "Disabled",
    "DLC_H4_Island_Defences_Soundset"
  ),
 new Tuple<string,string>(
    "Active",
    "DLC_H4_Island_Defences_Soundset"
  ),
 new Tuple<string,string>(
    "Methamphetamine_Job_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "External_Explosion",
    "Methamphetamine_Job_Sounds"
  ),
 new Tuple<string,string>(
    "Internal_Explosion",
    "Methamphetamine_Job_Sounds"
  ),
 new Tuple<string,string>(
    "PT_FAKE_CAR_ONE_REV_SLOW",
    "0"
  ),
 new Tuple<string,string>(
    "PT_FAKE_CAR_TWO_REVS_FAST",
    "0"
  ),
 new Tuple<string,string>(
    "PT_FAKE_CAR_THREE_QUICK_REVS",
    "0"
  ),
 new Tuple<string,string>(
    "Pickup_Keyring",
    "dlc_h4_heist_finale_sounds_soundset"
  ),
 new Tuple<string,string>(
    "Distant_Roar",
    "DLC_H4_EscPan_Sounds"
  ),
 new Tuple<string,string>(
    "Keycard_Wait_Loop",
    "Twin_Card_Entry_Sounds"
  ),
 new Tuple<string,string>(
    "Goon_Paid_Large",
    "GTAO_Boss_Goons_FM_Soundset"
  ),
 new Tuple<string,string>(
    "Menu_Accept",
    "Phone_SoundSet_Default"
  ),
 new Tuple<string,string>(
    "Friend_Deliver",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Enemy_Deliver",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Deliver_Pick_Up",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Dropped",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Enemy_Pick_Up",
    "HUD_FRONTEND_MP_COLLECTABLE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Boss_Message_Orange",
    "GTAO_Biker_FM_Soundset"
  ),
 new Tuple<string,string>(
    "Boss_Message_Orange",
    "GTAO_Boss_Goons_FM_Soundset"
  ),
 new Tuple<string,string>(
    "Crate_Pickup_Remote",
    "DLC_IE_Vip_Stockpile_Sounds"
  ),
 new Tuple<string,string>(
    "Crate_Destroy_Remote",
    "DLC_IE_Vip_Stockpile_Sounds"
  ),
 new Tuple<string,string>(
    "Pickup_Standard",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "playing_card",
    "dlc_vw_hidden_collectible_sounds"
  ),
 new Tuple<string,string>(
    "dlc_vw_hidden_collectible_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "SELECT_START_GRID_POSITION",
    "0"
  ),
 new Tuple<string,string>(
    "PLACE_CHECKPOINT",
    "0"
  ),
 new Tuple<string,string>(
    "Survival_Passed",
    "0"
  ),
 new Tuple<string,string>(
    "Survival_Failed",
    "DLC_VW_AS_Sounds"
  ),
 new Tuple<string,string>(
    "Round_Passed",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown_Tick_Last",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown_Tick",
    "0"
  ),
 new Tuple<string,string>(
    "Health_Pickup_Loop",
    "DLC_VW_AS_Sounds"
  ),
 new Tuple<string,string>(
    "Armour_Pickup_Loop",
    "DLC_VW_AS_Sounds"
  ),
 new Tuple<string,string>(
    "Pickup_Spawn",
    "0"
  ),
 new Tuple<string,string>(
    "Initial_Spawn",
    "DLC_VW_AS_Sounds"
  ),
 new Tuple<string,string>(
    "Ship_Loop",
    "DLC_VW_AS_Sounds"
  ),
 new Tuple<string,string>(
    "SIGN_DESTROYED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "Franklin_Whistle_For_Chop",
    "SPEECH_RELATED_SOUNDS"
  ),
 new Tuple<string,string>(
    "Boxcar_Door_Slide",
    "FRANKLIN_0_SOUNDS"
  ),
 new Tuple<string,string>(
    "Boxcar_Door_Limit",
    "FRANKLIN_0_SOUNDS"
  ),
 new Tuple<string,string>(
    "Crash_Through_Fence",
    "FRANKLIN_0_SOUNDS"
  ),
 new Tuple<string,string>(
    "FRANKLIN_1_PHOTO_SHOOT",
    "0"
  ),
 new Tuple<string,string>(
    "HORN",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Moor_SEASHARK3_Engine",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "clue_seen",
    "dlc_ch_hidden_collectibles_sk_sounds"
  ),
 new Tuple<string,string>(
    "dlc_ch_hidden_collectibles_sk_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "clue_complete_shard",
    "dlc_btl_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "item_found",
    "dlc_btl_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "item_close_loop",
    "dlc_btl_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "item_found",
    "dlc_xm_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "clue_complete_shard",
    "dlc_xm_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "item_close_loop",
    "dlc_xm_fm_th_sounds"
  ),
 new Tuple<string,string>(
    "destroyed",
    "dlc_ch_hidden_collectibles_sj_sounds"
  ),
 new Tuple<string,string>(
    "shard",
    "dlc_ch_hidden_collectibles_sj_sounds"
  ),
 new Tuple<string,string>(
    "attract",
    "dlc_ch_hidden_collectibles_sj_sounds"
  ),
 new Tuple<string,string>(
    "Sonar_Pulse_No_Target",
    "dlc_hei4_hidden_collectibles_sonar_locator_sounds"
  ),
 new Tuple<string,string>(
    "Sonar_Pulse",
    "dlc_hei4_hidden_collectibles_sonar_locator_sounds"
  ),
 new Tuple<string,string>(
    "cache_attract_loop",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "chest_attract_loop",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "radio_tower_attract_loop",
    "dlc_hei4_hidden_collectibles_sounds"
  ),
 new Tuple<string,string>(
    "Shipwreck_Attract",
    "Tuner_Collectables_General_Sounds"
  ),
 new Tuple<string,string>(
    "EMP_vehicle_affected",
    "DLC_AW_EMP_Sounds"
  ),
 new Tuple<string,string>(
    "formation_active",
    "formation_flying_blips_soundset"
  ),
 new Tuple<string,string>(
    "formation_inactive",
    "formation_flying_blips_soundset"
  ),
 new Tuple<string,string>(
    "player_riding",
    "biker_formation_sounds"
  ),
 new Tuple<string,string>(
    "Crates_Blipped",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Goon_Paid_Small",
    "GTAO_Boss_Goons_FM_Soundset"
  ),
 new Tuple<string,string>(
    "GTAO_Biker_FM_Soundset",
    "0"
  ),
 new Tuple<string,string>(
    "GTAO_Boss_Goons_FM_Soundset",
    "0"
  ),
 new Tuple<string,string>(
    "FestiveGift",
    "Feed_Message_Sounds"
  ),
 new Tuple<string,string>(
    "bombs_empty",
    "DLC_SM_Bomb_Bay_Bombs_Sounds"
  ),
 new Tuple<string,string>(
    "bomb_deployed",
    "DLC_SM_Bomb_Bay_Bombs_Sounds"
  ),
 new Tuple<string,string>(
    "collect_water",
    "dlc_sum20_yacht_missions_ah_sounds"
  ),
 new Tuple<string,string>(
    "chaff_cooldown",
    "DLC_SM_Countermeasures_Sounds"
  ),
 new Tuple<string,string>(
    "chaff_empty",
    "DLC_SM_Countermeasures_Sounds"
  ),
 new Tuple<string,string>(
    "chaff_released",
    "DLC_SM_Countermeasures_Sounds"
  ),
 new Tuple<string,string>(
    "flares_empty",
    "DLC_SM_Countermeasures_Sounds"
  ),
 new Tuple<string,string>(
    "flares_released",
    "DLC_SM_Countermeasures_Sounds"
  ),
 new Tuple<string,string>(
    "rc_mines_empty",
    "DLC_AW_RCBandito_Mine_Sounds"
  ),
 new Tuple<string,string>(
    "Rappel_Loop",
    "GTAO_Rappel_Sounds"
  ),
 new Tuple<string,string>(
    "Rappel_Stop",
    "GTAO_Rappel_Sounds"
  ),
 new Tuple<string,string>(
    "Rappel_Land",
    "GTAO_Rappel_Sounds"
  ),
 new Tuple<string,string>(
    "movie_prop_reward_cut_music",
    "DLC_sum20_hidden_collectible_sounds"
  ),
 new Tuple<string,string>(
    "movie_prop_reward_cut_roar",
    "DLC_sum20_hidden_collectible_sounds"
  ),
 new Tuple<string,string>(
    "Armour_On",
    "DLC_GR_Steal_Miniguns_Sounds"
  ),
 new Tuple<string,string>(
    "Wheel_Spin_Start",
    "DLC_AW_Arena_Spin_Wheel_Game_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_Timer_Bleep_Red",
    "DLC_AW_Arena_Spin_Wheel_Game_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "Countdown_Timer_Bleep",
    "DLC_AW_Arena_Spin_Wheel_Game_Frontend_Sounds"
  ),
 new Tuple<string,string>(
    "BULL_SHARK_TESTOSTERONE_START_MASTER",
    ""
  ),
 new Tuple<string,string>(
    "BULL_SHARK_TESTOSTERONE_END_MASTER",
    ""
  ),
 new Tuple<string,string>(
    "5_SEC_WARNING",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "RANK_UP",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "MP_IDLE_TIMER",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MP_IDLE_KICK",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Remote_Control_Fob",
    "PI_Menu_Sounds"
  ),
 new Tuple<string,string>(
    "Remote_Control_Close",
    "PI_Menu_Sounds"
  ),
 new Tuple<string,string>(
    "Remote_Control_Open",
    "PI_Menu_Sounds"
  ),
 new Tuple<string,string>(
    "Toggle_Lights",
    "PI_Menu_Sounds"
  ),
 new Tuple<string,string>(
    "Timer_10s",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Return_To_Vehicle_Timer",
    "GTAO_FM_Events_Soundset"
  ),
 new Tuple<string,string>(
    "Accept_Ghosting_Mode",
    "RESPAWN_ONLINE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Faster_Bar_Full",
    "RESPAWN_ONLINE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Faster_Click",
    "RESPAWN_ONLINE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Pickup_Briefcase",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Pickup_Briefcase",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Blip_Pickup",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Enemy_Pickup_Briefcase",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Deliver_Item",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Crate_Explosion",
    "DLC_Biker_Burn_Assets_Sounds"
  ),
 new Tuple<string,string>(
    "Counter_Tick",
    "DLC_Biker_Burn_Assets_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Zone_Alarm",
    "0"
  ),
 new Tuple<string,string>(
    "Altitude_Warning_Loop",
    "DLC_Exec_Fly_Low_Sounds"
  ),
 new Tuple<string,string>(
    "Generic_Positive_Event",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Generic_Negative_Event",
    "GTAO_Biker_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Get_Back_In_Vehicle",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Blow_Cell_Door",
    "DLC_Biker_POW_Sounds"
  ),
 new Tuple<string,string>(
    "Unlock_Cell",
    "DLC_Biker_POW_Sounds"
  ),
 new Tuple<string,string>(
    "Enemy_In_Zone",
    "DLC_Biker_SYG_Sounds"
  ),
 new Tuple<string,string>(
    "Enter_Zone",
    "DLC_Biker_SYG_Sounds"
  ),
 new Tuple<string,string>(
    "Leave_Zone",
    "DLC_Biker_SYG_Sounds"
  ),
 new Tuple<string,string>(
    "Lose_1st",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Enter_1st",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "container_detach",
    "dlc_vw_slot_machines_sounds"
  ),
 new Tuple<string,string>(
    "car_crushed",
    "dlc_vw_body_disposal_sounds"
  ),
 new Tuple<string,string>(
    "Klaxon_01",
    "ALARMS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "dlc_vw_heisters_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "laptop_download",
    "dlc_vw_heisters_sounds"
  ),
 new Tuple<string,string>(
    "boot_pop",
    "dlc_vw_body_disposal_sounds"
  ),
 new Tuple<string,string>(
    "distant_gunfire",
    "dlc_vw_missing_delivery_sounds"
  ),
 new Tuple<string,string>(
    "collect_chips_handed",
    "dlc_vw_tracking_chips_sounds"
  ),
 new Tuple<string,string>(
    "container_attach",
    "dlc_vw_slot_machines_sounds"
  ),
 new Tuple<string,string>(
    "Bunker_Hatch",
    "GTAO_Script_Doors_Faded_Screen_Sounds"
  ),
 new Tuple<string,string>(
    "Flight_Loop",
    "DLC_H3_Prep_Drones_Sounds"
  ),
 new Tuple<string,string>(
    "Alarm_Interior",
    "DLC_H3_FM_FIB_Raid_Sounds"
  ),
 new Tuple<string,string>(
    "Alarm_Exterior",
    "DLC_H3_FM_FIB_Raid_Sounds"
  ),
 new Tuple<string,string>(
    "DLC_H3_FM_FIB_Raid_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Vent_Fizzing",
    "dlc_ch_maintenance_sounds"
  ),
 new Tuple<string,string>(
    "Bunker_Alarm_Interior",
    "dlc_ch_armoured_equipment_sounds"
  ),
 new Tuple<string,string>(
    "Bunker_Alarm_Exterior",
    "dlc_ch_armoured_equipment_sounds"
  ),
 new Tuple<string,string>(
    "Airhorn_Blast_Long",
    "DLC_AW_General_Sounds"
  ),
 new Tuple<string,string>(
    "DLC_HEIST_EMP_IDLE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Launch",
    "DLC_H3_Tracker_App_Sounds"
  ),
 new Tuple<string,string>(
    "Signal_Loop",
    "DLC_H3_Tracker_App_Sounds"
  ),
 new Tuple<string,string>(
    "Close",
    "DLC_H3_Tracker_App_Sounds"
  ),
 new Tuple<string,string>(
    "bin_bag_bugs",
    "dlc_ch_bugstars_sounds"
  ),
 new Tuple<string,string>(
    "Back",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Paper_Stick",
    "DLC_HEIST_PLANNING_BOARD_SOUNDS"
  ),
 new Tuple<string,string>(
    "Bell_01",
    "ALARMS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Crashed_Plane_Ambience",
    "DLC_Exec_Crash_Site_SoundSet"
  ),
 new Tuple<string,string>(
    "Crow_Caw",
    "DLC_Exec_Aftermath_Sounds"
  ),
 new Tuple<string,string>(
    "Fly_Buzz",
    "DLC_Exec_Aftermath_Sounds"
  ),
 new Tuple<string,string>(
    "Car_Creak",
    "DLC_Exec_Aftermath_Sounds"
  ),
 new Tuple<string,string>(
    "Deliver_Item",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Drop_Package",
    "DLC_Exec_Land_Multiple_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Zone_Alarm",
    "DLC_Exec_Air_Drop_Sounds"
  ),
 new Tuple<string,string>(
    "Charge_Full",
    "DLC_Exec_Jammer_Sounds"
  ),
 new Tuple<string,string>(
    "Active",
    "DLC_Exec_Jammer_Sounds"
  ),
 new Tuple<string,string>(
    "Active_Empty",
    "DLC_Exec_Jammer_Sounds"
  ),
 new Tuple<string,string>(
    "Charging",
    "DLC_Exec_Jammer_Sounds"
  ),
 new Tuple<string,string>(
    "Drop_Package",
    "DLC_Exec_Air_Drop_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Knock_Normal",
    "dlc_btl_deliver_goods_sounds"
  ),
 new Tuple<string,string>(
    "flatbed_delivery",
    "DLC_SM_Precision_Delivery_Sounds"
  ),
 new Tuple<string,string>(
    "flatbed_delivery_impact",
    "DLC_SM_Precision_Delivery_Sounds"
  ),
 new Tuple<string,string>(
    "Case_Beep",
    "GTAO_Magnate_Finders_Keepers_Soundset"
  ),
 new Tuple<string,string>(
    "Plane_Crash_Oneshot",
    "DLC_XM17_Silo_Flight_Recorder_Sounds"
  ),
 new Tuple<string,string>(
    "Tone",
    "Lift_Normal_Soundset"
  ),
 new Tuple<string,string>(
    "security_scanner_beep_os",
    "dlc_xm_heists_fm_uc_sounds"
  ),
 new Tuple<string,string>(
    "download_start",
    "dlc_xm_heists_fm_uc_sounds"
  ),
 new Tuple<string,string>(
    "download_complete",
    "dlc_xm_heists_fm_uc_sounds"
  ),
 new Tuple<string,string>(
    "Klaxon_06",
    "ALARMS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "keys",
    "dlc_xm_pickup_sweetener_sounds"
  ),
 new Tuple<string,string>(
    "Plane_Damaged_Loop",
    "DLC_XM17_Silo_Flight_Recorder_Sounds"
  ),
 new Tuple<string,string>(
    "Use",
    "0"
  ),
 new Tuple<string,string>(
    "Finale_Available",
    "0"
  ),
 new Tuple<string,string>(
    "Launch_Mission",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Blocked",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Up_Down",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Left_Right",
    "0"
  ),
 new Tuple<string,string>(
    "Decrease_Loot_Share",
    "0"
  ),
 new Tuple<string,string>(
    "Increase_Loot_Share",
    "0"
  ),
 new Tuple<string,string>(
    "Background",
    "0"
  ),
 new Tuple<string,string>(
    "Draw_Board",
    "0"
  ),
 new Tuple<string,string>(
    "Bootup",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Up_Down_Photo_Change",
    "0"
  ),
 new Tuple<string,string>(
    "Nav_Left_Right_Photo_Change",
    "0"
  ),
 new Tuple<string,string>(
    "Pay",
    "0"
  ),
 new Tuple<string,string>(
    "DLC_GR_Steal_Railguns_Sounds",
    "0"
  ),
 new Tuple<string,string>(
    "04",
    "0"
  ),
 new Tuple<string,string>(
    "05",
    "0"
  ),
 new Tuple<string,string>(
    "03",
    "0"
  ),
 new Tuple<string,string>(
    "07",
    "0"
  ),
 new Tuple<string,string>(
    "01",
    "0"
  ),
 new Tuple<string,string>(
    "02",
    "0"
  ),
 new Tuple<string,string>(
    "Signal_Off",
    "DLC_GR_Ambushed_Sounds"
  ),
 new Tuple<string,string>(
    "Signal_On",
    "DLC_GR_Ambushed_Sounds"
  ),
 new Tuple<string,string>(
    "Connection_Established",
    "DLC_GR_FTL_Sounds"
  ),
 new Tuple<string,string>(
    "Connection_Lost",
    "DLC_GR_FTL_Sounds"
  ),
 new Tuple<string,string>(
    "Exploding_Entity_Start",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Exploding_Entity_Loop",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Exploding_Entity_Stop",
    "MP_MISSION_COUNTDOWN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Bomb_Armed",
    "DLC_GR_Disarm_Bombs_Sounds"
  ),
 new Tuple<string,string>(
    "Bomb_Disarmed",
    "DLC_GR_Disarm_Bombs_Sounds"
  ),
 new Tuple<string,string>(
    "Boss_Blipped",
    "GTAO_Magnate_Hunt_Boss_SoundSet"
  ),
 new Tuple<string,string>(
    "Crush_Car",
    "DLC_IE_Deliver_Vehicle_Scrapyard_Sounds"
  ),
 new Tuple<string,string>(
    "Door_Open",
    "GTAO_EXEC_WH_GARAGE_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "Door_Close",
    "GTAO_EXEC_WH_GARAGE_DOOR_SOUNDS"
  ),
 new Tuple<string,string>(
    "PICKUP_AMMO_BULLET_MP",
    "PICKUP_DEFAULT"
  ),
 new Tuple<string,string>(
    "Sniper_Fire",
    "DLC_Biker_Resupply_Meet_Contact_Sounds"
  ),
 new Tuple<string,string>(
    "Sniper_Bullet_Hit",
    "DLC_Biker_Resupply_Meet_Contact_Sounds"
  ),
 new Tuple<string,string>(
    "Control_Panel_Disabled",
    "DLC_BTL_Jewel_Store_Grab_Sounds"
  ),
 new Tuple<string,string>(
    "Destroy_Supply_Player",
    "DLC_IE_Vip_Plowed_Sounds"
  ),
 new Tuple<string,string>(
    "Destroy_Supply_Remote",
    "DLC_IE_Vip_Plowed_Sounds"
  ),
 new Tuple<string,string>(
    "Flare",
    "DLC_Exec_Salvage_Sounds"
  ),
 new Tuple<string,string>(
    "RADAR_ACTIVATE",
    "DLC_BTL_SECURITY_VANS_RADAR_PING_SOUNDS"
  ),
 new Tuple<string,string>(
    "RADAR_READY",
    "DLC_BTL_SECURITY_VANS_RADAR_PING_SOUNDS"
  ),
 new Tuple<string,string>(
    "flight_recorder",
    "dlc_xm_pickup_sweetener_sounds"
  ),
 new Tuple<string,string>(
    "Blip_Pickup",
    "GTAO_Magnate_Boss_Modes_Soundset"
  ),
 new Tuple<string,string>(
    "Altitude_Warning_Loop",
    "DLC_SM_Under_The_Radar_Sounds"
  ),
 new Tuple<string,string>(
    "container_detach",
    "DLC_SM_Heavy_Lifting_Sounds"
  ),
 new Tuple<string,string>(
    "Altitude_Checkpoint",
    "DLC_SM_Infiltration_Sounds"
  ),
 new Tuple<string,string>(
    "Altitude_Beeps",
    "DLC_SM_Infiltration_Sounds"
  ),
 new Tuple<string,string>(
    "crashed_heli_ambience",
    "DLC_SM_Blackbox_Sounds"
  ),
 new Tuple<string,string>(
    "alarm_loop",
    "DLC_SM_Escort_Sounds"
  ),
 new Tuple<string,string>(
    "hook_attach",
    "DLC_SM_Precision_Delivery_Sounds"
  ),
 new Tuple<string,string>(
    "hook_detach",
    "DLC_SM_Precision_Delivery_Sounds"
  ),
 new Tuple<string,string>(
    "cargo_alarm_loop",
    "DLC_SM_Cargo_Plane_Sounds"
  ),
 new Tuple<string,string>(
    "Crate_Pickup_Player",
    "0"
  ),
 new Tuple<string,string>(
    "Crate_Destroy_Player",
    "0"
  ),
 new Tuple<string,string>(
    "Countdown_Loop",
    "0"
  ),
 new Tuple<string,string>(
    "Arming_Countdown",
    "0"
  ),
 new Tuple<string,string>(
    "Bomb_Armed",
    "0"
  ),
 new Tuple<string,string>(
    "Bomb_Disarmed",
    "0"
  ),
 new Tuple<string,string>(
    "Meter_Fill_Loop",
    "DLC_IE_Tail_Vehicle_Sounds"
  ),
 new Tuple<string,string>(
    "Meter_Full",
    "DLC_IE_Tail_Vehicle_Sounds"
  ),
 new Tuple<string,string>(
    "Hook_Attach",
    "DLC_IE_Steal_Cargobob_Sounds"
  ),
 new Tuple<string,string>(
    "Hook_Detach",
    "DLC_IE_Steal_Cargobob_Sounds"
  ),
 new Tuple<string,string>(
    "Hook_Engage",
    "DLC_IE_Steal_Cargobob_Sounds"
  ),
 new Tuple<string,string>(
    "Speed_Boost",
    "DLC_IE_Stunt_Man_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Player",
    "0"
  ),
 new Tuple<string,string>(
    "Timer_Reduced",
    "0"
  ),
 new Tuple<string,string>(
    "Horn",
    "DLC_Apt_Yacht_Ambient_Soundset"
  ),
 new Tuple<string,string>(
    "Enemy_Capture_Start",
    "GTAO_Magnate_Yacht_Attack_Soundset"
  ),
 new Tuple<string,string>(
    "Team_Capture_Start",
    "GTAO_Magnate_Yacht_Attack_Soundset"
  ),
 new Tuple<string,string>(
    "QUIT_WHOOSH",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "GOLF_HUD_HOLE_IN_ONE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_EAGLE",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "GOLF_BIRDIE",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "HIGHLIGHT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "GOLF_HUD_SCORECARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_ROLL_PUTT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_IMPACT_FLAG_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_CUP_MISS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_CUP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_IN_WATER_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BALL_IMPACT_LEAVES_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_FORWARD_SWING_PERFECT_VB_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_FORWARD_SWING_VB_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_BACK_SWING_HARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "HIGHLIGHT_NAV_UP_DOWN",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "0"
  ),
 new Tuple<string,string>(
    "GOLF_FORWARD_SWING_HARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_tw_frontend_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_tw_global_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Frontend_Player_No_Territory_Loop",
    "dlc_vw_am_tw_frontend_sounds"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_OTHER",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_AMMO_PURCHASE",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_ATTACHMENT_EQUIP",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_ATTACHMENT_UNEQUIP",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_HANDGUN",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_SHOTGUN",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_RIFLE",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_GRENADE_LAUNCHER",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_RPG_LAUNCHER",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_KNIFE",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_BATON",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_PARACHUTE",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WEAPON_SELECT_FUEL_CAN",
    "HUD_AMMO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Scissors",
    "Barber_Sounds"
  ),
 new Tuple<string,string>(
    "Makeup",
    "Barber_Sounds"
  ),
 new Tuple<string,string>(
    "CONTINUOUS_SLIDER",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "UNDER_WATER_COME_UP",
    "0"
  ),
 new Tuple<string,string>(
    "MARKER_ERASE",
    "HEIST_BULLETIN_BOARD_SOUNDSET"
  ),
 new Tuple<string,string>(
    "UNDO",
    "HEIST_BULLETIN_BOARD_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PERSON_SELECT",
    "HEIST_BULLETIN_BOARD_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PERSON_SCROLL",
    "HEIST_BULLETIN_BOARD_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COYOTE_BARK_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "COYOTE_CRY_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "ELK_PAIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "ELK_BREY_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "PLAYER_CALLS_ELK_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Heart_Breathing",
    "0"
  ),
 new Tuple<string,string>(
    "MEDAL_BRONZE",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "MEDAL_SILVER",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "MEDAL_GOLD",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "TARP",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "RAMP_DOWN",
    "TRUCK_RAMP_DOWN"
  ),
 new Tuple<string,string>(
    "RAMP_UP",
    "TRUCK_RAMP_DOWN"
  ),
 new Tuple<string,string>(
    "In",
    "SHORT_PLAYER_SWITCH_SOUND_SET"
  ),
 new Tuple<string,string>(
    "Gunman_Bike_Crash",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "all",
    "SHORT_PLAYER_SWITCH_SOUND_SET"
  ),
 new Tuple<string,string>(
    "DROP_ITEMS",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "SMASH_CABINET_PLAYER",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "SMASH_CABINET_NPC",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "Grenade_Throw_Success",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "Grenade_Throw_Miss",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "Seagulls",
    "JEWEL_HEIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "PICKUP_WEAPON_SMOKEGRENADE",
    "HUD_FRONTEND_WEAPONS_PICKUPS_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Drop_Case",
    "JWL_PREP_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Lock_Destroyed",
    "JWL_PREP_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Lock_Damage",
    "JWL_PREP_2A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Background_Sound",
    "Phone_SoundSet_Glasses_Cam"
  ),
 new Tuple<string,string>(
    "Camera_Shoot",
    "Phone_SoundSet_Glasses_Cam"
  ),
 new Tuple<string,string>(
    "Camera_Zoom",
    "Phone_SoundSet_Glasses_Cam"
  ),
 new Tuple<string,string>(
    "HOUSE_FIRE",
    "JOSH_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BBQ_EXPLODE",
    "JOSH_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "LAMAR1_FAKE_POLICE_SIREN2_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "LAMAR1_BustDoorOpen1",
    "0"
  ),
 new Tuple<string,string>(
    "LAMAR1_WAREHOUSE_FIRE",
    "0"
  ),
 new Tuple<string,string>(
    "LAMAR1_PARTYGIRLS_master",
    "0"
  ),
 new Tuple<string,string>(
    "Grab_Parachute",
    "BASEJUMPS_SOUNDS"
  ),
 new Tuple<string,string>(
    "DOM_BREATHING",
    "EXTREME_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TRUNK_THUMPS",
    "0"
  ),
 new Tuple<string,string>(
    "MICHAEL_SOFA_TV_CHANGE_CHANNEL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MICHAEL_SOFA_REMOTE_CLICK_VOLUME_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Ring",
    "Phone_SoundSet_Michael"
  ),
 new Tuple<string,string>(
    "Answer_Phone",
    "Lester1B_Sounds"
  ),
 new Tuple<string,string>(
    "COMPUTERS_MOUSE_CLICK",
    "0"
  ),
 new Tuple<string,string>(
    "CLOSE_WINDOW",
    "LESTER1A_SOUNDS"
  ),
 new Tuple<string,string>(
    "OPEN_WINDOW",
    "LESTER1A_SOUNDS"
  ),
 new Tuple<string,string>(
    "LESTER1A_SOUNDS",
    "0"
  ),
 new Tuple<string,string>(
    "FINDING_VIRUS",
    "LESTER1A_SOUNDS"
  ),
 new Tuple<string,string>(
    "Virus_Eradicated",
    "LESTER1A_SOUNDS"
  ),
 new Tuple<string,string>(
    "UNLOCK_DOOR",
    "LESTER1A_SOUNDS"
  ),
 new Tuple<string,string>(
    "ON",
    "0"
  ),
 new Tuple<string,string>(
    "LOOP",
    "0"
  ),
 new Tuple<string,string>(
    "OFF",
    "0"
  ),
 new Tuple<string,string>(
    "ON",
    "NOIR_FILTER_SOUNDS"
  ),
 new Tuple<string,string>(
    "HUD_PROPERTY_SOUNDSET",
    "0"
  ),
 new Tuple<string,string>(
    "Take_Picture",
    "MUGSHOT_CHARACTER_CREATION_SOUNDS"
  ),
 new Tuple<string,string>(
    "Lights_On",
    "GTAO_MUGSHOT_ROOM_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_Out",
    "MUGSHOT_CHARACTER_CREATION_SOUNDS"
  ),
 new Tuple<string,string>(
    "Zoom_In",
    "MUGSHOT_CHARACTER_CREATION_SOUNDS"
  ),
 new Tuple<string,string>(
    "Remote_Sniper_Rifle_Move",
    "0"
  ),
 new Tuple<string,string>(
    "Remote_Sniper_Rifle_Zoom",
    "0"
  ),
 new Tuple<string,string>(
    "PLANE_ON_FIRE",
    "0"
  ),
 new Tuple<string,string>(
    "MARTIN1_DISTANT_TRAIN_HORNS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MARTIN_1_PLANE_CRASH_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "SUBWAY_TRAIN_HORNS_AIR_HORN",
    "0"
  ),
 new Tuple<string,string>(
    "SOLOMON_1_JET_SHOT_EXPLODE",
    "0"
  ),
 new Tuple<string,string>(
    "SCOPE_UI_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MICHAEL_EVENT_AMANDA_REMOVE_HANDCUFFS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Train_Bell",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "RING",
    "CHURCH_BELL_SOUNDSET"
  ),
 new Tuple<string,string>(
    "MIC_1_RAIN_ON_PLANE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MINCER_FALL",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "MIC_2_CHOPPED_UP_JUMPIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MEAT_SLIDE",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "MINCER_LOOP",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "ACID_BATH_FALL",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Rail_Loop_Skip_Start",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Pull_Out",
    "Phone_SoundSet_Franklin"
  ),
 new Tuple<string,string>(
    "RAIL_LOOP",
    "MICHAEL_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "MIC4_CAMERA_FLASH_master",
    "0"
  ),
 new Tuple<string,string>(
    "STUN_COLLECT",
    "MINUTE_MAN_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PASSPORT",
    "MINUTE_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "KISS",
    "ROAD_RACE_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FAMILY3_COACH_OUT_WINDOW_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "ASS_PAYPHONE_RING_master",
    "0"
  ),
 new Tuple<string,string>(
    "Flush",
    "DOCKS_HEIST_FINALE_2B_SOUNDS"
  ),
 new Tuple<string,string>(
    "DOOR_BUZZER_LOOP",
    "FINALE_INTRO_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TOOTH_PING",
    "NIGEL_1A_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WHISTLING",
    "NIGEL_1B_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COLLAR",
    "NIGEL_1C_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COLLECT_IN_BAG",
    "NIGEL_1D_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COLLECT_OUT_BAG",
    "NIGEL_1D_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CAR_DROP_WRAP",
    "0"
  ),
 new Tuple<string,string>(
    "DOOR_CRASH",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SCREAMS",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "PANIC_WALLA",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WALL_CRASH",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "WINDOW_CRASH",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FAKE_REVS_VEHICLE_02",
    "NIGEL_02_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CRASH",
    "NIGEL_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TRAIN_COMING",
    "NIGEL_03_SOUNDSET"
  ),
 new Tuple<string,string>(
    "dj_crowd_cheer",
    "dlc_btl_club_dj_callout_crowd_cheers_sounds"
  ),
 new Tuple<string,string>(
    "MP_APARTMENT_SHOWER_GET_UNDRESSED_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MP_APARTMENT_SHOWER_DOOR_OPEN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MP_APARTMENT_SHOWER_GET_DRESSED_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "GTAO_MP_APARTMENT_SHOWER_PLASTIC_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "MP_APARTMENT_SHOWER_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Insert_Coin",
    "0"
  ),
 new Tuple<string,string>(
    "Timer",
    "0"
  ),
 new Tuple<string,string>(
    "Turn",
    "0"
  ),
 new Tuple<string,string>(
    "Turn_Limit",
    "0"
  ),
 new Tuple<string,string>(
    "Zoom_Limit",
    "0"
  ),
 new Tuple<string,string>(
    "10_Seconds",
    "0"
  ),
 new Tuple<string,string>(
    "MICHAEL_SOFA_TV_ON_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_MINI_GAME_SOUNDSET",
    "0"
  ),
 new Tuple<string,string>(
    "CROWD_CHEER_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "SWING",
    "0"
  ),
 new Tuple<string,string>(
    "CAMERA",
    "0"
  ),
 new Tuple<string,string>(
    "ZOOM",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "SMALL_CRASH",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "LOOP_REV",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "BUILDING_SITE_CRASH",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "HIGHREV",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "AMBIENT_SEX",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "CAMERA_FOLEY",
    "PAPARAZZO_02_SOUNDSETS"
  ),
 new Tuple<string,string>(
    "POLICE_CRASH",
    "PAPARAZZO_03A"
  ),
 new Tuple<string,string>(
    "CRASH",
    "PAPARAZZO_03A"
  ),
 new Tuple<string,string>(
    "FLIGHT_SCHOOL_LESSON_PASSED",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Spawn",
    "DLC_PILOT_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "move",
    "DLC_PILOT_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "stop",
    "DLC_PILOT_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Destroyed",
    "DLC_PILOT_Shooting_Range_Sounds"
  ),
 new Tuple<string,string>(
    "Jump",
    "DLC_Pilot_Chase_Parachute_Sounds"
  ),
 new Tuple<string,string>(
    "Grab_Chute_Foley",
    "DLC_Pilot_Chase_Parachute_Sounds"
  ),
 new Tuple<string,string>(
    "Plane_Wind",
    "DLC_Pilot_Chase_Parachute_Sounds"
  ),
 new Tuple<string,string>(
    "engineexplosion",
    "DLC_PILOT_CITY_LANDING"
  ),
 new Tuple<string,string>(
    "Engine_fail",
    "DLC_PILOT_ENGINE_FAILURE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Warning_Tones",
    "DLC_PILOT_ENGINE_FAILURE_SOUNDS"
  ),
 new Tuple<string,string>(
    "Landing_Tone",
    "DLC_PILOT_ENGINE_FAILURE_SOUNDS"
  ),
 new Tuple<string,string>(
    "BAR_DELIVER_BOOZE_RATTLE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "PROPERTIES_PLANE_PROMO_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TAKINGS_TIRES_PEELAWAY_master",
    "0"
  ),
 new Tuple<string,string>(
    "Cops_Arrive_2",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Train_Horn",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Security_Door_Bomb_Bleeps",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "COPS_ARRIVE",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Security_Door_Alarm",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Guard_Headshot",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Barge_Door",
    "Prologue_Sounds"
  ),
 new Tuple<string,string>(
    "Music_Dynamic_Banked",
    "sum20_am_Qub3d_sounds"
  ),
 new Tuple<string,string>(
    "MENU_SELECT",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_TIMER_COUNTDOWN_LOOP_3_MIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_TIMER_COUNTDOWN_LOOP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_ROAR_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_KILLED_HEAD_SHOT_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_KILLED_COUNTER_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "RAMPAGE_PASSED_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "SHOOTING_RANGE_ROUND_OVER",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "TARGET_PRACTICE_FLIP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TARGET_PRACTICE_STOP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TARGET_PRACTICE_SLIDE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "HUD_FRONTEND_DEFAULT_SOUNDSET",
    "0"
  ),
 new Tuple<string,string>(
    "TIMER_STOP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TextHit",
    "MissionFailedSounds"
  ),
 new Tuple<string,string>(
    "SKIP",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "RETRY",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "RESTART",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Bed",
    "MissionFailedSounds"
  ),
 new Tuple<string,string>(
    "ScreenFlash",
    "0"
  ),
 new Tuple<string,string>(
    "Bed",
    "0"
  ),
 new Tuple<string,string>(
    "TextHit",
    "0"
  ),
 new Tuple<string,string>(
    "Warning_Once",
    "TRAIN_HORN"
  ),
 new Tuple<string,string>(
    "SUSPENSION_SCRIPT_FORCE",
    "0"
  ),
 new Tuple<string,string>(
    "WEAKEN",
    "CONSTRUCTION_ACCIDENT_1_SOUNDS"
  ),
 new Tuple<string,string>(
    "WIND",
    "CONSTRUCTION_ACCIDENT_1_SOUNDS"
  ),
 new Tuple<string,string>(
    "CABLE_SNAPS",
    "CONSTRUCTION_ACCIDENT_1_SOUNDS"
  ),
 new Tuple<string,string>(
    "PIPES_LAND",
    "CONSTRUCTION_ACCIDENT_1_SOUNDS"
  ),
 new Tuple<string,string>(
    "ROPE_CUT",
    "ROPE_CUT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CLOTHES_THROWN",
    "RE_DOMESTIC_SOUNDSET"
  ),
 new Tuple<string,string>(
    "VARIABLE_COUNTDOWN_CLOCK_wp",
    "0"
  ),
 new Tuple<string,string>(
    "SHUTTER_FLASH",
    "CAMERA_FLASH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SHUTTER",
    "CAMERA_FLASH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "FLASH",
    "CAMERA_FLASH_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DOORS_BLOWN",
    "RE_SECURITY_VAN_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BIG_STOP",
    "0"
  ),
 new Tuple<string,string>(
    "PS2A_DISTANT_TRAIN_HORNS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "PS2A_TRACTOR_THRU_CHAIN_LINK_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DiggerRevOneShot",
    "BulldozerDefault"
  ),
 new Tuple<string,string>(
    "TEST_SCREAM_SHORT",
    "0"
  ),
 new Tuple<string,string>(
    "Gas_Station_Explosion",
    "RURAL_BANK_HEIST_FINALE_SOUNDS"
  ),
 new Tuple<string,string>(
    "PS2A_MONEY_LOST",
    "PALETO_SCORE_2A_BANK_SS"
  ),
 new Tuple<string,string>(
    "PS2A_WELDTORCH_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "Shoot_box",
    "Paleto_Score_Setup_Sounds"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_ip_frontend_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_ip_tank_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Tank_Engine_Loop",
    "dlc_vw_am_ip_tank_sounds"
  ),
 new Tuple<string,string>(
    "Tank_Critical_Damage_Loop",
    "dlc_vw_am_ip_tank_sounds"
  ),
 new Tuple<string,string>(
    "dlc_vw_am_ip_enemy_sounds",
    "0"
  ),
 new Tuple<string,string>(
    "Tank_Weapon_Lightning_Gun_Fire_Hit",
    "dlc_vw_am_ip_tank_sounds"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_CHARACTER_01_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_DPAD_DOWN_MP_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "CHARACTER_CHANGE_DPAD_DOWN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "SwitchRedWarning",
    "SPECIAL_ABILITY_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SwitchWhiteWarning",
    "SPECIAL_ABILITY_SOUNDSET"
  ),
 new Tuple<string,string>(
    "CHARACTER_SELECT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Jet_Engine",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Man_Sucked_In",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Tanker_Horn",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Tanker_Explosion",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Flying_Car",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Carsplosion",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Molly_Open_Doors",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_Loud_Fire",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_4_747_TV",
    "0"
  ),
 new Tuple<string,string>(
    "CANCEL",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Phone_Generic_Key_02",
    "HUD_MINIGAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Phone_Generic_Key_03",
    "HUD_MINIGAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "QUIT",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "NAV_UP_DOWN",
    "HUD_FRONTEND_TATTOO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "SELECT",
    "HUD_FRONTEND_TATTOO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_FRONTEND_TATTOO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ERROR",
    "HUD_FRONTEND_TATTOO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Tattooing_Oneshot",
    "TATTOOIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "PURCHASE",
    "HUD_FRONTEND_TATTOO_SHOP_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Tattooing_Oneshot_Remove",
    "TATTOOIST_SOUNDS"
  ),
 new Tuple<string,string>(
    "Burglar_Bell",
    "Generic_Alarms"
  ),
 new Tuple<string,string>(
    "Biker_Ring_Tone",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "TENNIS_MATCH_POINT",
    "HUD_AWARDS"
  ),
 new Tuple<string,string>(
    "TENNIS_FOOT_SQUEAKS_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_SMASH_MASTER",
    "TENNIS_NPC_SMASH_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_SMASH_BACKSLICE_MASTER",
    "TENNIS_NPC_SMASH_BACKSLICE_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_LOB_MASTER",
    "TENNIS_NPC_LOB_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_FOREARM_MASTER",
    "TENNIS_NPC_FOREARM_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_BACKSLICE_MASTER",
    "TENNIS_NPC_BACKSLICE_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_TOPSPIN_MASTER",
    "TENNIS_NPC_TOPSPIN_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_FOREARM_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_NET_BALL_MEDIUM_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_NET_BALL_SKIM_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_CLS_BALL_HARD_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_CLS_BALL_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_AMB_SMASH_MASTER",
    "TENNIS_NPC_SMASH_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_AMB_SERVE_MASTER",
    "TENNIS_NPC_SERVE_MASTER"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_SMASH_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_PLYR_SERVE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "LEADERBOARD",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TENNIS_NPC_FOREARM_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_NPC_BACKSLICE_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TENNIS_NPC_TOPSPIN_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "WOUNDED",
    "SASQUATCH_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "ALERT",
    "SASQUATCH_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "RUNNING",
    "SASQUATCH_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "COUGH",
    "SASQUATCH_01_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DLC_VW_BET_DOWN",
    "dlc_vw_table_games_frontend_sounds"
  ),
 new Tuple<string,string>(
    "TOWING_ENGINE_TURNING_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "DRUG_TRAFFIC_AIR_SCREAMS",
    "0"
  ),
 new Tuple<string,string>(
    "CONFIRM_BEEP",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "DRUG_TRAFFIC_AIR_BOMB_DROP_ERROR_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "PICK_UP_WEAPON",
    "HUD_FRONTEND_CUSTOM_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TRAFFIC_GROUND_ENEMY_PICK_UP_WEAPON_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "TIMER",
    "HUD_FRONTEND_DEFAULT_SOUNDSET"
  ),
 new Tuple<string,string>(
    "TREVOR_1_RAM_TRAILER_REVS",
    "0"
  ),
 new Tuple<string,string>(
    "TREVOR_1_TRAILER_IMPACT_MASTER_B",
    "0"
  ),
 new Tuple<string,string>(
    "TREVOR_1_TRAILER_IMPACT_MASTER_A",
    "0"
  ),
 new Tuple<string,string>(
    "TREVOR_1_TRAILER_IMPACT_MASTER_C",
    "0"
  ),
 new Tuple<string,string>(
    "TREVOR_1_LEAD_OUT_CR",
    "0"
  ),
 new Tuple<string,string>(
    "Trevor_2_cargo_drop",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trevor_2_cargo_bay_open",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trevor_2_chopper_explode",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "BIKER_PROP_GRIND",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "TREVOR_2_PLANE_START",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "Trevor_2_van_rev",
    "TREVOR_2_SOUNDS"
  ),
 new Tuple<string,string>(
    "ALARMS_KLAXON_03_FAR",
    "0"
  ),
 new Tuple<string,string>(
    "ALARMS_KLAXON_03_CLOSE",
    "0"
  ),
 new Tuple<string,string>(
    "DAMAGED_TRUCK_IDLE",
    "0"
  ),
 new Tuple<string,string>(
    "POSITIONED_WALLA_MASTER",
    "0"
  ),
 new Tuple<string,string>(
    "BACK",
    "HUD_MINI_GAME_SOUNDSET"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish",
    "Car_Club_Races_Sprint_Challenge_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "Car_Club_Races_Sprint_Challenge_Sounds"
  ),
 new Tuple<string,string>(
    "Go",
    "DLC_Tuner_Car_Meet_Test_Area_Events_Sounds"
  ),
 new Tuple<string,string>(
    "321",
    "DLC_Tuner_Car_Meet_Test_Area_Events_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Finish_Winner",
    "DLC_Tuner_Car_Meet_Test_Area_Events_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint",
    "DLC_Tuner_Car_Meet_Test_Area_Events_Sounds"
  ),
 new Tuple<string,string>(
    "Go",
    "Car_Club_Races_Sprint_Challenge_Sounds"
  ),
 new Tuple<string,string>(
    "321",
    "Car_Club_Races_Sprint_Challenge_Sounds"
  ),
 new Tuple<string,string>(
    "Checkpoint_Lap",
    "DLC_Tuner_Car_Meet_Test_Area_Events_Sounds"
  ),
 new Tuple<string,string>(
    "05",
    "DLC_GR_CS2_Sounds"
  ),
 new Tuple<string,string>(
    "07",
    "DLC_GR_CS2_Sounds"
  ),
 new Tuple<string,string>(
    "PROPERTY_PURCHASE_MEDIUM",
    "HUD_PROPERTY_SOUNDSET"
  )
        };
        
        
        
        public SoundEffect()
        {
            
        }

        public void playSound(String AudioName,String AudioRef)
        {
            API.PlaySoundFrontend(1,AudioName,AudioRef,true);
        }

        public void stopSound()
        {
            API.PlaySoundFrontend(1,"BACK","HUD_FRONTEND_DEFAULT_SOUNDSET",true);
        }

        public List<Tuple<String, String>> getSounds() => _sounds;

    }
}