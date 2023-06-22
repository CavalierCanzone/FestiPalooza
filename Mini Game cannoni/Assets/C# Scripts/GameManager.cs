using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int randomNumber = 0;
    bool level1 = false;
    bool level2 = false;
    bool level3 = false;
    bool level4 = false;
    bool level5 = false;
    bool level6 = false;
    bool level7 = false;
    bool level8 = false;
    bool level9 = false;
    bool level10 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      //Level 1
      if (!level1 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 1)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 7;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 7;
        

        level1 = true;
      }  

      //Level 2
      if (!level2 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 3)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 7;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 7;

        level2 = true;
      }

      //Level 3
      if (!level3 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 5)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;

        level3 = true;
      }

      //Level 4
      if (!level4 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 7)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;

        level4 = true;
      }
      
      //Level 5
      if (!level5 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 9)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 6;

        level5 = true;
      }
      
      //Level 6
      if (!level6 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 11)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;

        level6 = true;
      }

      //Level 7
      if (!level7 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 13)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;

        level7 = true;
      }

      //Level 8
      if (!level8 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 15)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 5;

        level8 = true;
      }

      //Level 9
      if (!level9 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 17)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 4;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 4;

        level9 = true;
      }

      //level 10
      if (!level10 && GameObject.Find("Player").GetComponent<CoinCollection>().Coin == 19)
      {
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingSpeed /= 1.3f;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 4;
        randomNumber = Random.Range(1, 7);

        GameObject.Find("Gun" + randomNumber).GetComponent<Gun>().shootingChance = 4;

        level10 = true;
      }

    }
}
