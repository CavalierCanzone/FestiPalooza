using UnityEngine;

public class DontDestroyThisGO : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
