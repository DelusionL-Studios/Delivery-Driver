using UnityEngine;

public class Player : MonoBehaviour
{
    //Packages to deliver should be handled by a level-specific script -- Out of scope for this game
    //Collision should be handled by its own script (different objects doing more or less damage as well) -- Out of scope

    [SerializeField] int health = 100;
    [SerializeField] int packagesToDeliver = 0;

    bool hasPackage = false;
    int packagesDelivered = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 25;    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Package>())
        {
            hasPackage = true; 
        }

        if(collision.gameObject.GetComponent<Customer>() && hasPackage)
        {
            hasPackage = false;
            packagesDelivered++;
            //CheckIfAllPackagesDelivered()
        }
    }

    //Scene management to load next level when all packages delivered.
    //Handle freezing game and forcing level restart if player health = 0
}
