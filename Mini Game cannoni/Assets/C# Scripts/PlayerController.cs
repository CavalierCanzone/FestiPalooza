using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 move;
   

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] invisibleWalls = GameObject.FindGameObjectsWithTag("InvisibleWall");

    foreach (GameObject wall in invisibleWalls)
    {
        Collider wallCollider = wall.GetComponent<Collider>();
        if (wallCollider != null)
        {
            Physics.IgnoreCollision(GetComponent<Collider>(), wallCollider, false);
        }
    }
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    public void  movePlayer()
    {
        Vector3 movement = new Vector3(move.x,0f, move.y);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    
}
