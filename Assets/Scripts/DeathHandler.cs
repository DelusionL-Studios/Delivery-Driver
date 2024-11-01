using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas playerDeathMenu;

    public void HandlePlayerDeath()
    {
        Time.timeScale = 0f;

        playerDeathMenu.gameObject.SetActive(true);
    }
}
