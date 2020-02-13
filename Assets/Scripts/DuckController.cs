using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{

    public float speed;

    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, vert) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}

