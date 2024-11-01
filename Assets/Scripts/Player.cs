using UnityEngine;

public class Player : MonoBehaviour
{
    //Packages to deliver should be handled by a level-specific script -- Out of scope for this game
    //Collision should be handled by its own script (different objects doing more or less damage as well) -- Out of scope

    [SerializeField] int health = 100;
    [SerializeField] int packagesToDeliver = 0;

    [SerializeField] DeathHandler deathHandler;
    [SerializeField] HUDisplay huDisplay;

    bool hasPackage = false;
    int packagesDelivered = 0;

    Driver driver;

    void Awake()
    {
        driver = GetComponent<Driver>();       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 25;    
        driver.SetBoosting(false);
        
        if(health <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Package>() && !hasPackage)
        {
            hasPackage = true;
            huDisplay.ActivateAffordanceText();
            //PlayPickupSFX()
        }

        if (collision.gameObject.GetComponent<Customer>() && hasPackage)
        {
            hasPackage = false;
            huDisplay.DeactivateAffordanceText();
            packagesDelivered++;
            Debug.Log("Success!");
            //PlayDeliverySFX/VFX()
            //CheckIfAllPackagesDelivered()
        }
        
        if (collision.gameObject.GetComponent<Boost>())
        {
            driver.SetBoosting(true);
        }
    }

    public int GetPlayerHealth()
    {
        return health;
    }

    public int GetPackagesToDeliver()
    {
        return packagesToDeliver - packagesDelivered;
    }

    void Die()
    {
        deathHandler.HandlePlayerDeath();
    }
}
