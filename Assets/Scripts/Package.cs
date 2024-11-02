using UnityEngine;

public class Package : MonoBehaviour
{
    //[SerializeField] ParticleSystem
    //[SerializeField] AudioSource

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + " triggered me.");        
    }
}
