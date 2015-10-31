﻿using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Preload
{
    public sealed class PreloadAlertSettings : SettingsBase
    {
        public PreloadAlertSettings()
        {
            Enable = true;
            Masters = true;
            Exiles = true;
            Strongboxes = true;
            FontSize = new RangeNode<int>(16, 10, 20);
            BackgroundColor = new ColorBGRA(255, 255, 255, 220);
            DefaultFontColor = new ColorBGRA(254, 192, 118, 255);
            AreaFontColor = new ColorBGRA(150, 200, 250, 255);
            HasCorruptedArea = new ColorBGRA(208, 31, 144, 255);

            MasterZana = new ColorBGRA(255, 0, 255, 255);
            MasterCatarina = new ColorBGRA(100, 255, 255, 255);
            MasterTora = new ColorBGRA(100, 255, 255, 255);
            MasterVorici = new ColorBGRA(100, 255, 255, 255);
            MasterHaku = new ColorBGRA(100, 255, 255, 255);
            MasterElreon = new ColorBGRA(100, 255, 255, 255);
            MasterVagan = new ColorBGRA(100, 255, 255, 255);
            MasterKrillson = new ColorBGRA(255, 0, 255, 255);

            ArcanistStrongbox = new ColorBGRA(255, 0, 255, 255);
            ArtisanStrongbox = new ColorBGRA(240, 240, 240, 255);
            CartographerStrongbox = new ColorBGRA(255, 0, 255, 255);
            GemcutterStrongbox = new ColorBGRA(27, 162, 155, 255);
            JewellerStrongbox = new ColorBGRA(240, 240, 240, 255);
            BlacksmithStrongbox = new ColorBGRA(240, 240, 240, 255);
            ArmourerStrongbox = new ColorBGRA(240, 240, 240, 255);
            OrnateStrongbox = new ColorBGRA(240, 240, 240, 255);
            LargeStrongbox = new ColorBGRA(240, 240, 240, 255);
            PerandusStrongbox = new ColorBGRA(175, 96, 37, 255);
            KaomStrongbox = new ColorBGRA(175, 96, 37, 255);
            MalachaiStrongbox = new ColorBGRA(175, 96, 37, 255);
            EpicStrongbox = new ColorBGRA(175, 96, 37, 255);
            SimpleStrongbox = new ColorBGRA(240, 240, 240, 255);

            OrraGreengate = new ColorBGRA(255, 155, 100, 255);
            ThenaMoga = new ColorBGRA(255, 155, 100, 255);
            AntalieNapora = new ColorBGRA(255, 155, 100, 255);
            TorrOlgosso = new ColorBGRA(255, 155, 100, 255);
            ArmiosBell = new ColorBGRA(255, 155, 100, 255);
            ZacharieDesmarais = new ColorBGRA(255, 155, 100, 255);
            MinaraAnenima = new ColorBGRA(255, 155, 100, 255);
            IgnaPhoenix = new ColorBGRA(255, 155, 100, 255);
            JonahUnchained = new ColorBGRA(255, 155, 100, 255);
            DamoiTui = new ColorBGRA(255, 155, 100, 255);
            XandroBlooddrinker = new ColorBGRA(255, 155, 100, 255);
            VickasGiantbone = new ColorBGRA(255, 155, 100, 255);
            EoinGreyfur = new ColorBGRA(255, 155, 100, 255);
            TinevinHighdove = new ColorBGRA(255, 155, 100, 255);
            MagnusStonethorn = new ColorBGRA(255, 155, 100, 255);
            IonDarkshroud = new ColorBGRA(255, 155, 100, 255);
            AshLessard = new ColorBGRA(255, 155, 100, 255);
            WilorinDemontamer = new ColorBGRA(255, 155, 100, 255);
            AugustinaSolaria = new ColorBGRA(255, 155, 100, 255);
        }

        public ToggleNode Masters { get; set; }
        public ToggleNode Exiles { get; set; }
        public ToggleNode Strongboxes { get; set; }
        public RangeNode<int> FontSize { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ColorNode DefaultFontColor { get; set; }
        public ColorNode AreaFontColor { get; set; }
        public ColorNode HasCorruptedArea { get; set; }
        public ColorNode MasterZana { get; set; }
        public ColorNode MasterCatarina { get; set; }
        public ColorNode MasterTora { get; set; }
        public ColorNode MasterVorici { get; set; }
        public ColorNode MasterHaku { get; set; }
        public ColorNode MasterElreon { get; set; }
        public ColorNode MasterVagan { get; set; }
        public ColorNode MasterKrillson { get; set; }
        public ColorNode ArcanistStrongbox { get; set; }
        public ColorNode ArtisanStrongbox { get; set; }
        public ColorNode CartographerStrongbox { get; set; }
        public ColorNode GemcutterStrongbox { get; set; }
        public ColorNode JewellerStrongbox { get; set; }
        public ColorNode BlacksmithStrongbox { get; set; }
        public ColorNode ArmourerStrongbox { get; set; }
        public ColorNode OrnateStrongbox { get; set; }
        public ColorNode LargeStrongbox { get; set; }
        public ColorNode PerandusStrongbox { get; set; }
        public ColorNode KaomStrongbox { get; set; }
        public ColorNode MalachaiStrongbox { get; set; }
        public ColorNode EpicStrongbox { get; set; }
        public ColorNode SimpleStrongbox { get; set; }
        public ColorNode OrraGreengate { get; set; }
        public ColorNode ThenaMoga { get; set; }
        public ColorNode AntalieNapora { get; set; }
        public ColorNode TorrOlgosso { get; set; }
        public ColorNode ArmiosBell { get; set; }
        public ColorNode ZacharieDesmarais { get; set; }
        public ColorNode MinaraAnenima { get; set; }
        public ColorNode IgnaPhoenix { get; set; }
        public ColorNode JonahUnchained { get; set; }
        public ColorNode DamoiTui { get; set; }
        public ColorNode XandroBlooddrinker { get; set; }
        public ColorNode VickasGiantbone { get; set; }
        public ColorNode EoinGreyfur { get; set; }
        public ColorNode TinevinHighdove { get; set; }
        public ColorNode MagnusStonethorn { get; set; }
        public ColorNode IonDarkshroud { get; set; }
        public ColorNode AshLessard { get; set; }
        public ColorNode WilorinDemontamer { get; set; }
        public ColorNode AugustinaSolaria { get; set; }
    }
}