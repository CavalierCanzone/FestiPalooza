using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            Time.timeScale = 0f;
        }
    }

    public void TakeDamage(int d)
     {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life == 0)
            {
                dead = true;
            }
        }


     }
}
