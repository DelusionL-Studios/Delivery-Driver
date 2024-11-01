using UnityEngine;

public class Customer : MonoBehaviour
{
    //ps
    //as

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);    
    }
}
