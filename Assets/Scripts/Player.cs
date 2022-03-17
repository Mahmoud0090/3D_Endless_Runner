using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float dodgeSpeed;

    public float maxXPos;

    float xInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        transform.Translate(xInput * dodgeSpeed * Time.deltaTime, 0, 0);

        float limitedX = Mathf.Clamp(transform.position.x, -maxXPos, maxXPos);

        transform.position = new Vector3(limitedX, transform.position.y, transform.position.z);
    }
}
