using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    private float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() //use fixed update for physics movements
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //getting the input from the arrow keys
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        this.rigidBody.AddForce(movement * this.movementSpeed);
    }
}
