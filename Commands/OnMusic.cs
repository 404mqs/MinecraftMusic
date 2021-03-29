using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace MinecraftMusic
{
    public class OnMusic : IRocketCommand
    {

        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "onmusic";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "mm.onmusic" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var username = UnturnedPlayer.FromName(caller.DisplayName);
            PlayerComponent getBool = username.GetComponent<PlayerComponent>();

            if (getBool.ListenToMusic == true)
            {
                UnturnedChat.Say(username, MQSPlugin.Instance.Translate("AlreadyOn"));
                return;
            }

            else
            {
                getBool.ListenToMusic = true;
                UnturnedChat.Say(username, MQSPlugin.Instance.Translate("MusicOn"));
            }
        }
    }
}
