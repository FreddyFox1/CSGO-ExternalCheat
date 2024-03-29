﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Globals
{
    /// <summary>
    /// rus: Базовые адреса для смещений в памяти.
    /// eng: Base adresses for offssets memory
    /// </summary>
    public static class Netvars
    {
        public static Int32 cs_gamerules_data = 0x0;
        public static Int32 m_ArmorValue = 0xB378;
        public static Int32 m_Collision = 0x320;
        public static Int32 m_CollisionGroup = 0x474;
        public static Int32 m_Local = 0x2FBC;
        public static Int32 m_MoveType = 0x25C;
        public static Int32 m_OriginalOwnerXuidHigh = 0x31C4;
        public static Int32 m_OriginalOwnerXuidLow = 0x31C0;
        public static Int32 m_SurvivalGameRuleDecisionTypes = 0x1328;
        public static Int32 m_SurvivalRules = 0xD00;
        public static Int32 m_aimPunchAngle = 0x302C;
        public static Int32 m_aimPunchAngleVel = 0x3038;
        public static Int32 m_angEyeAnglesX = 0xB37C;
        public static Int32 m_angEyeAnglesY = 0xB380;
        public static Int32 m_bBombDefused = 0x29B0;
        public static Int32 m_bBombPlanted = 0x9A5;
        public static Int32 m_bBombTicking = 0x2980;
        public static Int32 m_bFreezePeriod = 0x20;
        public static Int32 m_bGunGameImmunity = 0x3944;
        public static Int32 m_bHasDefuser = 0xB388;
        public static Int32 m_bHasHelmet = 0xB36C;
        public static Int32 m_bInReload = 0x32A5;
        public static Int32 m_bIsDefusing = 0x3930;
        public static Int32 m_bIsQueuedMatchmaking = 0x74;
        public static Int32 m_bIsScoped = 0x3928;
        public static Int32 m_bIsValveDS = 0x7C;
        public static Int32 m_bSpotted = 0x93D;
        public static Int32 m_bSpottedByMask = 0x980;
        public static Int32 m_bStartedArming = 0x33F0;
        public static Int32 m_bUseCustomAutoExposureMax = 0x9D9;
        public static Int32 m_bUseCustomAutoExposureMin = 0x9D8;
        public static Int32 m_bUseCustomBloomScale = 0x9DA;
        public static Int32 m_clrRender = 0x70;
        public static Int32 m_dwBoneMatrix = 0x26A8;
        public static Int32 m_fAccuracyPenalty = 0x3330;
        public static Int32 m_fFlags = 0x104;
        public static Int32 m_flC4Blow = 0x2990;
        public static Int32 m_flCustomAutoExposureMax = 0x9E0;
        public static Int32 m_flCustomAutoExposureMin = 0x9DC;
        public static Int32 m_flCustomBloomScale = 0x9E4;
        public static Int32 m_flDefuseCountDown = 0x29AC;
        public static Int32 m_flDefuseLength = 0x29A8;
        public static Int32 m_flFallbackWear = 0x31D0;
        public static Int32 m_flFlashDuration = 0xA420;
        public static Int32 m_flFlashMaxAlpha;
        public static Int32 m_flLastBoneSetupTime = 0x2924;
        public static Int32 m_flLowerBodyYawTarget = 0x3A90;
        public static Int32 m_flNextAttack = 0x2D70;
        public static Int32 m_flNextPrimaryAttack = 0x3238;
        public static Int32 m_flSimulationTime = 0x268;
        public static Int32 m_flTimerLength = 0x2994;
        public static Int32 m_hActiveWeapon = 0x2EF8;
        public static Int32 m_hBombDefuser = 0x29B4;
        public static Int32 m_hMyWeapons = 0x2DF8;
        public static Int32 m_hObserverTarget = 0x338C;
        public static Int32 m_hOwner = 0x29CC;
        public static Int32 m_hOwnerEntity = 0x14C;
        public static Int32 m_hViewModel = 0x32F8;
        public static Int32 m_iAccountID = 0x2FC8;
        public static Int32 m_iClip1 = 0x3264;
        public static Int32 m_iCompetitiveRanking = 0x1A84;
        public static Int32 m_iCompetitiveWins = 0x1B88;
        public static Int32 m_iCrosshairId = 0xB3E4;
        public static Int32 m_iDefaultFOV = 0x332C;
        public static Int32 m_iEntityQuality = 0x2FAC;
        public static Int32 m_iFOVStart = 0x31E8;
        public static Int32 m_iGlowIndex = 0xA438;
        public static Int32 m_iHealth = 0x100;
        public static Int32 m_iItemDefinitionIndex = 0x2FAA;
        public static Int32 m_iItemIDHigh = 0x2FC0;
        public static Int32 m_iMostRecentModelBoneCounter = 0x2690;
        public static Int32 m_iObserverMode = 0x3378;
        public static Int32 m_iShotsFired = 0xA390;
        public static Int32 m_iState = 0x3258;
        public static Int32 m_iTeamNum;
        public static Int32 m_lifeState = 0x25F;
        public static Int32 m_nBombSite = 0x2984;
        public static Int32 m_nFallbackPaintKit = 0x31C8;
        public static Int32 m_nFallbackSeed = 0x31CC;
        public static Int32 m_nFallbackStatTrak = 0x31D4;
        public static Int32 m_nForceBone = 0x268C;
        public static Int32 m_nTickBase = 0x3430;
        public static Int32 m_nViewModelIndex = 0x29C0;
        public static Int32 m_rgflCoordinateFrame = 0x444;
        public static Int32 m_szCustomName = 0x303C;
        public static Int32 m_szLastPlaceName = 0x35B4;
        public static Int32 m_thirdPersonViewAngles = 0x31D8;
        public static Int32 m_vecOrigin = 0x138;
        public static Int32 m_vecVelocity = 0x114;
        public static Int32 m_vecViewOffset = 0x108;
        public static Int32 m_viewPunchAngle = 0x3020;
        public static Int32 m_zoomLevel = 0x33D0;
    }
    public static class signatures
    {
        public static Int32 anim_overlays = 0x2980;
        public static Int32 clientstate_choked_commands = 0x4D30;
        public static Int32 clientstate_delta_ticks = 0x174;
        public static Int32 clientstate_last_outgoing_command = 0x4D2C;
        public static Int32 clientstate_net_channel = 0x9C;
        public static Int32 convar_name_hash_table = 0x2F0F8;
        public static Int32 dwClientState = 0x58EFE4;
        public static Int32 dwClientState_GetLocalPlayer = 0x180;
        public static Int32 dwClientState_IsHLTV = 0x4D48;
        public static Int32 dwClientState_Map = 0x28C;
        public static Int32 dwClientState_MapDirectory = 0x188;
        public static Int32 dwClientState_MaxPlayer = 0x388;
        public static Int32 dwClientState_PlayerInfo = 0x52C0;
        public static Int32 dwClientState_State = 0x108;
        public static Int32 dwClientState_ViewAngles = 0x4D90;
        public static Int32 dwEntityList = 0x4DA3F5C;
        public static Int32 dwForceAttack = 0x31D54B4;
        public static Int32 dwForceAttack2 = 0x31D54C0;
        public static Int32 dwForceBackward = 0x31D5508;
        public static Int32 dwForceForward = 0x31D5514;
        public static Int32 dwForceJump;
        public static Int32 dwForceLeft = 0x31D5490;
        public static Int32 dwForceRight = 0x31D5484;
        public static Int32 dwGameDir = 0x62D7F8;
        public static Int32 dwGameRulesProxy = 0x52C119C;
        public static Int32 dwGetAllClasses = 0xDB3F9C;
        public static Int32 dwGlobalVars = 0x58ECE8;
        public static Int32 dwGlowObjectManager = 0x52EC550;
        public static Int32 dwInput = 0x51F5540;
        public static Int32 dwInterfaceLinkList = 0x946B44;
        public static Int32 dwLocalPlayer;
        public static Int32 dwMouseEnable = 0xD91E70;
        public static Int32 dwMouseEnablePtr = 0xD91E40;
        public static Int32 dwPlayerResource = 0x31D3810;
        public static Int32 dwRadarBase = 0x51D8CD4;
        public static Int32 dwSensitivity = 0xD91D0C;
        public static Int32 dwSensitivityPtr = 0xD91CE0;
        public static Int32 dwSetClanTag = 0x8A1B0;
        public static Int32 dwViewMatrix = 0x4D95874;
        public static Int32 dwWeaponTable = 0x51F6000;
        public static Int32 dwWeaponTableIndex = 0x325C;
        public static Int32 dwYawPtr = 0xD91AD0;
        public static Int32 dwZoomSensitivityRatioPtr = 0xD96D70;
        public static Int32 dwbSendPackets = 0xD749A;
        public static Int32 dwppDirect3DDevice9 = 0xA7050;
        public static Int32 find_hud_element = 0x2843E320;
        public static Int32 force_update_spectator_glow = 0x3AD962;
        public static Int32 interface_engine_cvar = 0x3E9EC;
        public static Int32 is_c4_owner = 0x3BA430;
        public static Int32 m_bDormant;
        public static Int32 m_flSpawnTime = 0xA370;
        public static Int32 m_pStudioHdr = 0x294C;
        public static Int32 m_pitchClassPtr = 0x51D8F70;
        public static Int32 m_yawClassPtr = 0xD91AD0;
        public static Int32 model_ambient_min = 0x59205C;
        public static Int32 set_abs_angles = 0x1DF9C0;
        public static Int32 set_abs_origin = 0x1DF800;
    }
}