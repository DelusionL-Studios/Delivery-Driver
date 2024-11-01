using TMPro;
using UnityEngine;

public class HUDisplay : MonoBehaviour
{
    [SerializeField] Canvas huDisplayCanvas;
    [SerializeField] TextMeshProUGUI packageAffordanceText;
    [SerializeField] TextMeshProUGUI packagesToDeliverText;
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] Player player;

    void Update()
    {
        playerHealthText.text = "Health: " + player.GetPlayerHealth().ToString();
        packagesToDeliverText.text = "Packages Remaining: " + player.GetPackagesToDeliver(); 
    }

    public void ActivateAffordanceText()
    {
        packageAffordanceText.gameObject.SetActive(true); 
    }

    public void DeactivateAffordanceText()
    {
        packageAffordanceText?.gameObject.SetActive(false);
    }
}
