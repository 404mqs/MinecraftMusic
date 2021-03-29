using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace MinecraftMusic
{
    public class OffMusic : IRocketCommand
    {

        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "offmusic";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "mm.offmusic" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var username = UnturnedPlayer.FromName(caller.DisplayName);
            PlayerComponent getBool = username.GetComponent<PlayerComponent>();

            if (getBool.ListenToMusic == false)
            {
                UnturnedChat.Say(username, MQSPlugin.Instance.Translate("AlreadyOff"));
                return;
            }

            else                
            { 
                    getBool.ListenToMusic = false;
                    EffectManager.askEffectClearByID(3805, username.CSteamID);
                    EffectManager.askEffectClearByID(3806, username.CSteamID);
                    EffectManager.askEffectClearByID(3807, username.CSteamID);
                    EffectManager.askEffectClearByID(3808, username.CSteamID);
                    EffectManager.askEffectClearByID(3809, username.CSteamID);
                    EffectManager.askEffectClearByID(3810, username.CSteamID);
                    EffectManager.askEffectClearByID(3811, username.CSteamID);
                    EffectManager.askEffectClearByID(3812, username.CSteamID);
                    EffectManager.askEffectClearByID(3813, username.CSteamID);
                    EffectManager.askEffectClearByID(3814, username.CSteamID);
                    EffectManager.askEffectClearByID(3815, username.CSteamID);
                    EffectManager.askEffectClearByID(3816, username.CSteamID);
                    EffectManager.askEffectClearByID(3817, username.CSteamID);
                    EffectManager.askEffectClearByID(3818, username.CSteamID);
                    EffectManager.askEffectClearByID(3819, username.CSteamID);
                    EffectManager.askEffectClearByID(3820, username.CSteamID);
                UnturnedChat.Say(username, MQSPlugin.Instance.Translate("MusicOff"));
            }
        }
    }
}

