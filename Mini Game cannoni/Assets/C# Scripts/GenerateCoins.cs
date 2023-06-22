using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoins : MonoBehaviour
{
    public GameObject coin;
    public float angle;
    public float distance;
    public int coinsCount;
    Vector3 center = new Vector3(0f, 1f, 0f);
    float radius = 10f;
    

    void Start()
    {
        StartCoroutine(CoinDrop()); 
    }

    IEnumerator CoinDrop()
    {
        while (coinsCount < 10)
        {
            angle = Random.Range(0f, 2f * Mathf.PI);
            distance = Mathf.Sqrt(Random.Range(0f, 1f)) * radius;
            float x = center.x + distance * Mathf.Cos(angle);
            float z = center.z + distance * Mathf.Sin(angle);
            Instantiate(coin, new Vector3(x, 1f, z), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            coinsCount += 1;
        }
    }

   
}
