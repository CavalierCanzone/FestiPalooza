using UnityEngine;

public class DontDestroyOnLoadThisGO : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
