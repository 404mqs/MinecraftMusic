using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace MinecraftMusic
{
    public class MQSPlugin : RocketPlugin<Config>
    {
        public static MQSPlugin Instance;
        protected override void Load()
        {
            Instance = this;
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been loaded! ");
            Logger.LogWarning("Dev: MQS#7816");
            Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            U.Events.OnPlayerConnected += OnPlayerConnected;
            U.Events.OnPlayerDisconnected += OnPlayerDisconnected;
            ChatManager.onChatted += onChat;

        }

        private void onChat(SteamPlayer player, EChatMode mode, ref Color chatted, ref bool isRich, string text, ref bool isVisible)
        {
            var converted = UnturnedPlayer.FromSteamPlayer(player);
            PlayerComponent getBool = converted.GetComponent<PlayerComponent>();
            if (text == "/offmusic")
            {
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
                StopCoroutine(Count(converted));
            }

            if (text == "/onmusic")
            {
                if (getBool == true)
                {
                    return;
                }
                StartCoroutine(Count(converted));
            }       
        }


        private void OnPlayerConnected(UnturnedPlayer player)
        {
            StartCoroutine(Count(player));
        }


        private void OnPlayerDisconnected(UnturnedPlayer player)
        {
            StopCoroutine(Count(player));
        }

        private IEnumerator<WaitForSeconds> Count(UnturnedPlayer player)
        {
            while (this)
            {
                Logger.Log($"Minecraft Music Started to {player.DisplayName}");
                yield return new WaitForSeconds(Configuration.Instance.TimeToStart);

                EffectManager.sendUIEffect(Configuration.Instance.Song1, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song2, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song3, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song4, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song6, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song7, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song8, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song9, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song10, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song11, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song12, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song13, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song14, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeBetweenSongs);

                EffectManager.sendUIEffect(Configuration.Instance.Song15, 4305, player.CSteamID, true);

                yield return new WaitForSeconds(Configuration.Instance.TimeToRestartPlaylist);
            }
        }

        protected override void Unload()
        {

            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            U.Events.OnPlayerConnected -= OnPlayerConnected;
            U.Events.OnPlayerDisconnected -= OnPlayerDisconnected;
            ChatManager.onChatted -= onChat;
            StopAllCoroutines();

        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "AlreadyOff", "Your Minecraft Music is already turned off."},
            { "MusicOff", "The MC Music was desactivated. Use /onmusic to reactivate it."},
            { "AlreadyOn", "Your Minecraft Music is already turned on." },
            { "MusicOn", "The MC Music was activated. Use /offmusic to desactivate it." },
        };
    }
}