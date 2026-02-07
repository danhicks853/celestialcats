using UnityEngine;

public class HarmonyController : MonoBehaviour
{
    [SerializeField] private double harmony = 0;
    [SerializeField] private double harmonyPerSecond = 0;

    private const string HarmonyKey = "Harmony";
    private const string LastSaveKey = "LastSaveTime";

    public double Harmony => harmony;
    public double HarmonyPerSecond => harmonyPerSecond;

    private void Awake()
    {
        Load();
    }

    private void Update()
    {
        if (harmonyPerSecond <= 0) return;
        harmony += harmonyPerSecond * Time.deltaTime;
    }

    public void AddHarmony(double amount)
    {
        harmony += amount;
    }

    public void SetHarmonyPerSecond(double amount)
    {
        harmonyPerSecond = amount;
    }

    public void Save()
    {
        PlayerPrefs.SetString(HarmonyKey, harmony.ToString());
        PlayerPrefs.SetString(LastSaveKey, System.DateTime.UtcNow.ToString("o"));
        PlayerPrefs.Save();
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey(HarmonyKey))
        {
            double.TryParse(PlayerPrefs.GetString(HarmonyKey), out harmony);
        }
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}

