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

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.TryGetComponent<HeartSystem>(out HeartSystem HeartSystemComponent))
        {
            HeartSystemComponent.TakeDamage(1);
            
        }

        Destroy(gameObject);

    }
    
}
