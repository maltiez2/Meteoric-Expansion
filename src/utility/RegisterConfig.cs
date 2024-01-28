using ConfigLib;
using ImGuiNET;
using MeteoricExpansion.Systems;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace MeteoricExpansion.Utility
{
    class RegisterConfig : ModSystem
    {
        ModConfig config = new();

        private static ICoreServerAPI serverApi = null;

        public override void StartPre(ICoreAPI api)
        {
            base.StartPre(api);

            config.ReadConfig(api);
            api.ModLoader.GetModSystem<ConfigLibModSystem>().RegisterCustomConfig("meteoricexpansion", Edit);
        }
        public override void StartServerSide(ICoreServerAPI api)
        {
            serverApi = api;
        }
        public override void Dispose()
        {
            base.Dispose();

            config = null;
        }

        private void Edit(string id, ControlButtons buttons)
        {
            if (serverApi == null)
            {
                ImGui.Text("Editing settings only available in single player");
                return;
            }

            if (buttons.Save) config.SaveAndApply(serverApi);

            ImGui.SeparatorText("Actions");
            if (ImGui.Button($"Spawn meteor##{id}"))
            {
                serverApi.ModLoader.GetModSystem<MeteorSpawner>().TestSpawn();
            }
            ImGui.SameLine();
            if (ImGui.Button($"Spawn shower##{id}"))
            {
                serverApi.ModLoader.GetModSystem<ShowerSpawner>().TestSpawn();
            }
            ImGui.SameLine();
            if (ImGui.Button($"Apply settings##{id}"))
            {
                config.Apply(serverApi);
            }

            ImGui.SameLine();
            config.Edit(id);
        }
    }
}
