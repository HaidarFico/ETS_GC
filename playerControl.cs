using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControl : MonoBehaviour
{

    public float speed;
    private Vector2 move;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void MovePlayer()
    {
        Vector3 movement = new Vector3(-move.x, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    // Start is called before the first frame update
    void Start()
    {
        MovePlayer();   
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();   
    }
}
