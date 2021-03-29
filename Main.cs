using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace MinecraftMusic
{
    public class MQSPlugin : RocketPlugin<Config>
    {
        public static MQSPlugin Instance;

        public List<UnturnedPlayer> playersFlying = new List<UnturnedPlayer>();


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
        }

        private void OnPlayerConnected(UnturnedPlayer player)
        {
            PlayerComponent getBool = player.GetComponent<PlayerComponent>();
            if (getBool.ListenToMusic == true)
            {

                StartCoroutine(Count());

                IEnumerator<WaitForSeconds> Count()
                {
                    while (true)
                    {
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
            }
            else
            {
                return;
            }
        }

        private void OnPlayerDisconnected(UnturnedPlayer player)
        {
            
        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            U.Events.OnPlayerConnected -= OnPlayerConnected;
            U.Events.OnPlayerDisconnected -= OnPlayerDisconnected;
        }
    }
}