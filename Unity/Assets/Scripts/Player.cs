using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody pl;
    void Start()
    {
        pl = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        //define float moveY = Input.GetAxis ("");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        pl.position = pl.position + 0.2f  * movement;
    }
}
