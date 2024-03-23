using Progress.Enums;
using UnityEngine;

namespace Progress
{
    public class ProgressController : MonoBehaviour
    {
        public static ProgressController Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance == this)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);

            // PlayerPrefs.GetFloat("PosY")
            // PlayerPrefs.SetFloat("AngX", CurrentPlayerPosition.eulerAngles.x); 
            // PlayerPrefs.HasKey("PosX")
        }
        
        public SaveData GetSaveData()
        {
            return new SaveData()
            {
                Time = PlayerPrefs.GetInt("Time"),
                IsCurtainsOpened = PlayerPrefs.GetInt("IsCurtainsOpened") == 1,
                PantrySwitchUpCount = PlayerPrefs.GetInt("PantrySwitchUpCount"),
                PantrySwitchDownCount = PlayerPrefs.GetInt("PantrySwitchDownCount"),
                KeyState = (ItemState)PlayerPrefs.GetInt("KeyState"),
                LowBatteryState = (ItemState)PlayerPrefs.GetInt("LowBatteryState"),
                HammerState = (ItemState)PlayerPrefs.GetInt("HammerState"),
            };
        }

        private void Save(SaveData data)
        {
            PlayerPrefs.SetInt("Time", data.Time);
            PlayerPrefs.SetInt("IsCurtainsOpened", data.IsCurtainsOpened ? 1 : 0);
            PlayerPrefs.SetInt("PantrySwitchUpCount", data.PantrySwitchUpCount);
            PlayerPrefs.SetInt("PantrySwitchDownCount", data.PantrySwitchDownCount);
            PlayerPrefs.SetInt("KeyState", (int)data.KeyState);
            PlayerPrefs.SetInt("LowBatteryState", (int)data.LowBatteryState);
            PlayerPrefs.SetInt("HammerState", (int)data.HammerState);
        }
    }
}