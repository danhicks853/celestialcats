using TMPro;
using UnityEngine;

public class HarmonyUI : MonoBehaviour
{
    [SerializeField] private HarmonyController harmonyController;
    [SerializeField] private TextMeshProUGUI harmonyText;
    [SerializeField] private TextMeshProUGUI perSecondText;

    private void Update()
    {
        if (harmonyController == null || harmonyText == null) return;
        harmonyText.text = $"Harmony: {harmonyController.Harmony:0.##}";

        if (perSecondText != null)
        {
            perSecondText.text = $"/sec: {harmonyController.HarmonyPerSecond:0.##}";
        }
    }
}

