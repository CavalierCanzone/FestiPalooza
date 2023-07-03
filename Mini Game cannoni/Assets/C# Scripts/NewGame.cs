using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("CannonGame");
    }

    public void Dead()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
