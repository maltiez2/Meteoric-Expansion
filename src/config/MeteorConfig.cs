using ImGuiNET;

namespace MeteoricExpansion
{
    class MeteoricExpansionConfig
    {
        public string FallingMeteorConfigOptions = "The Following Options Affect Falling Meteors";
        public bool DisableFallingMeteors = false;
        public bool Destructive = false;
        public bool ClaimsProtected = true;
        public double FallingMeteorSize = 2;
        public int FallingMeteorSizeVariance = 3;
        public int MinimumMeteorHorizontalSpeed = 25;
        public int MaximumMeteorHorizontalSpeed = 60;
        public int MinimumMeteorVerticalSpeed = 20;
        public int MaximumMeteorVerticalSpeed = 45;
        public int MinimumMinutesBetweenMeteorSpawns = 10;
        public int MaximumMinutesBetweenMeteorSpawns = 30;
        public int MinimumSpawnDistanceInChunks = 1;
        public int MaximumSpawnDistanceInChunks = 6;
        public int MinimumMeteorLifespanInSeconds = 3;
        public int MaximumMeteorLifespanInSeconds = 10;
        public int MinimumCraterSmoulderTimeInMinutes = 2;
        public int MaximumCraterSmoulderTimeInMinutes = 10;
        public double CraterSizeMultiplier = 1.75;

        public string ShowerConfigOptions = "The Following Options Affect Meteor Showers";
        public bool DisableShowers = false;
        public int MinimumShowerHorizontalSpeed = 80;
        public int MaximumShowerHorizontalSpeed = 120;
        public int MinimumShowerVerticalSpeed = 0;
        public int MaximumShowerVerticalSpeed = 0;
        public int MinimumMinutesBetweenShowers = 5;
        public int MaximumMinutesBetweenShowers = 45;
        public int MinimumShowerSpawnDistanceInChunks = 0;
        public int MaximumShowerSpawnDistanceInChunks = 6;
        public int MinimumShowerDurationInMinutes = 2;
        public int MaximumShowerDurationInMinutes = 5;
        public int MaxMeteorsPerShower = 100;

        public MeteoricExpansionConfig()
        {

        }
        public MeteoricExpansionConfig(MeteoricExpansionConfig previousConfig)
        {
            SetFrom(previousConfig);
        }

        private void SetFrom(MeteoricExpansionConfig previousConfig)
        {
            //-- The following options affect falling meteors --//
            DisableFallingMeteors = previousConfig.DisableFallingMeteors;
            Destructive = previousConfig.Destructive;
            ClaimsProtected = previousConfig.ClaimsProtected;
            FallingMeteorSize = previousConfig.FallingMeteorSize;
            FallingMeteorSizeVariance = previousConfig.FallingMeteorSizeVariance;
            MinimumMeteorHorizontalSpeed = previousConfig.MinimumMeteorHorizontalSpeed;
            MaximumMeteorHorizontalSpeed = previousConfig.MaximumMeteorHorizontalSpeed;
            MinimumMeteorVerticalSpeed = previousConfig.MinimumMeteorVerticalSpeed;
            MaximumMeteorVerticalSpeed = previousConfig.MaximumMeteorVerticalSpeed;
            MinimumMinutesBetweenMeteorSpawns = previousConfig.MinimumMinutesBetweenMeteorSpawns;
            MaximumMinutesBetweenMeteorSpawns = previousConfig.MaximumMinutesBetweenMeteorSpawns;
            MinimumSpawnDistanceInChunks = previousConfig.MinimumSpawnDistanceInChunks;
            MaximumSpawnDistanceInChunks = previousConfig.MaximumSpawnDistanceInChunks;
            MinimumMeteorLifespanInSeconds = previousConfig.MinimumMeteorLifespanInSeconds;
            MaximumMeteorLifespanInSeconds = previousConfig.MaximumMeteorLifespanInSeconds;
            MinimumCraterSmoulderTimeInMinutes = previousConfig.MinimumCraterSmoulderTimeInMinutes;
            MaximumCraterSmoulderTimeInMinutes = previousConfig.MaximumCraterSmoulderTimeInMinutes;
            CraterSizeMultiplier = previousConfig.CraterSizeMultiplier;

            //-- The following options affect meteor showers --//
            DisableShowers = previousConfig.DisableShowers;
            MinimumMinutesBetweenShowers = previousConfig.MinimumMinutesBetweenShowers;
            MaximumMinutesBetweenShowers = previousConfig.MaximumMinutesBetweenShowers;
            MinimumShowerHorizontalSpeed = previousConfig.MinimumShowerHorizontalSpeed;
            MaximumShowerHorizontalSpeed = previousConfig.MaximumShowerHorizontalSpeed;
            MinimumShowerVerticalSpeed = previousConfig.MinimumShowerVerticalSpeed;
            MaximumShowerVerticalSpeed = previousConfig.MaximumShowerVerticalSpeed;
            MinimumShowerSpawnDistanceInChunks = previousConfig.MinimumShowerSpawnDistanceInChunks;
            MaximumShowerSpawnDistanceInChunks = previousConfig.MaximumShowerSpawnDistanceInChunks;
            MinimumShowerDurationInMinutes = previousConfig.MinimumShowerDurationInMinutes;
            MaximumShowerDurationInMinutes = previousConfig.MaximumShowerDurationInMinutes;
            MaxMeteorsPerShower = previousConfig.MaxMeteorsPerShower;
        }

        public void Edit(string id)
        {
            if (ImGui.Button($"Reset all settings##{id}")) SetFrom(new());

            ImGui.SeparatorText("Settings");

            ImGui.PushItemWidth(200);
            
            ImGui.Text("The Following Options Affect Falling Meteors");
            
            ImGui.Checkbox($"Disable falling meteors##{id}", ref DisableFallingMeteors);
            ImGui.Checkbox($"Destructive##{id}", ref Destructive);
            DrawHint("Destructive determines whether meteor strikes damage the world. If set to true, meteorites will cause craters, destroy structures, toss inventory contents across the ground, etc");
            
            ImGui.Checkbox($"Claims protected##{id}", ref ClaimsProtected);
            DrawHint("If claims have been set for your base, then setting this to true will protect any blocks within the claim from being destroyed. This works for traders, too");
            
            ImGui.InputDouble($"FallingMeteorSize##{id}", ref FallingMeteorSize);
            ImGui.DragIntRange2($"MeteorHorizontalSpeed##{id}", ref MinimumMeteorHorizontalSpeed, ref MaximumMeteorHorizontalSpeed);
            ImGui.DragIntRange2($"MeteorVerticalSpeed##{id}", ref MinimumMeteorVerticalSpeed, ref MaximumMeteorVerticalSpeed);
            ImGui.DragIntRange2($"MinutesBetweenMeteorSpawns##{id}", ref MinimumMinutesBetweenMeteorSpawns, ref MaximumMinutesBetweenMeteorSpawns);
            DrawHint("Amount of time, in minutes, between meteor spawns. Timer restarts at the start of each game session or when the server has been restarted.");

            ImGui.DragIntRange2($"SpawnDistanceInChunks##{id}", ref MinimumSpawnDistanceInChunks, ref MaximumSpawnDistanceInChunks);
            DrawHint("Determines the range that a meteor will spawn from the player. Y distance is always worldheight - 10");

            ImGui.DragIntRange2($"MeteorLifespanInSeconds##{id}", ref MinimumMeteorLifespanInSeconds, ref MaximumMeteorLifespanInSeconds);
            DrawHint("Determines the amount of time, in seconds, that a meteor can live before exploding.");

            ImGui.DragIntRange2($"CraterSmoulderTimeInMinutes##{id}", ref MinimumCraterSmoulderTimeInMinutes, ref MaximumCraterSmoulderTimeInMinutes);

            DrawHint("A smouldering rock will only cool if it has existed after this number of minutes");
            DrawHint("A smouldering rock will cool before it has existed for this amount of minutes");
            
            ImGui.InputDouble($"CraterSizeMultiplier##{id}", ref CraterSizeMultiplier);
            
            
            ImGui.NewLine();
            ImGui.Text("The Following Options Affect Meteor Showers");

            ImGui.DragIntRange2($"ShowerHorizontalSpeed##{id}", ref MinimumShowerHorizontalSpeed, ref MaximumShowerHorizontalSpeed);
            ImGui.DragIntRange2($"ShowerVerticalSpeed##{id}", ref MinimumShowerVerticalSpeed, ref MaximumShowerVerticalSpeed);
            ImGui.DragIntRange2($"MinutesBetweenShowers##{id}", ref MinimumMinutesBetweenShowers, ref MaximumMinutesBetweenShowers);
            ImGui.DragIntRange2($"ShowerSpawnDistanceInChunks##{id}", ref MinimumShowerSpawnDistanceInChunks, ref MaximumShowerSpawnDistanceInChunks);
            ImGui.DragIntRange2($"ShowerDurationInMinutes##{id}", ref MinimumShowerDurationInMinutes, ref MaximumShowerDurationInMinutes);

            ImGui.DragInt($"MaxMeteorsPerShower##{id}", ref MaxMeteorsPerShower);

            ImGui.PopItemWidth();
        }

        private static void DrawHint(string hint)
        {
            if (hint == null) return;

            ImGui.SameLine();
            ImGui.TextDisabled("(?)");
            if (ImGui.BeginItemTooltip())
            {
                ImGui.PushTextWrapPos(ImGui.GetFontSize() * 35f);
                ImGui.TextUnformatted(hint);
                ImGui.PopTextWrapPos();

                ImGui.EndTooltip();
            }
        }
    }
}
