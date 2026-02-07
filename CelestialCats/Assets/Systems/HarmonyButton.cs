using UnityEngine;

public class HarmonyButton : MonoBehaviour
{
    [SerializeField] private HarmonyController harmonyController;
    [SerializeField] private double clickAmount = 1;

    public void OnClick()
    {
        if (harmonyController == null) return;
        harmonyController.AddHarmony(clickAmount);
    }
}

