using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.TryGetComponent<HeartSystem>(out HeartSystem HeartSystemComponent))
        {
            HeartSystemComponent.TakeDamage(1);
        }

        Destroy(gameObject); 
    }
    
}
