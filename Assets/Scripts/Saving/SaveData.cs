namespace Saving
{
    public class SaveData
    {
        // general
        public int Time { get; set; }
        public bool IsCurtainsOpened { get; set; }
        // pantry switch
        public int PantrySwitchUpCount { get; set; }
        public int PantrySwitchDownCount { get; set; }
        // items states
        public ItemState KeyState { get; set; }
        public ItemState LowBatteryState { get; set; }
        public ItemState HammerState { get; set; }

        public static SaveData GetDefault()
        {
            return new SaveData()
            {
                Time = -1,
                IsCurtainsOpened = false,
                PantrySwitchUpCount = 1,
                PantrySwitchDownCount = 4,
                KeyState = ItemState.OnPlace,
                LowBatteryState = ItemState.OnPlace,
                HammerState = ItemState.OnPlace,
            };
        }
    }
}