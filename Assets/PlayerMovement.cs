using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float jumpSpeed = 5f;

    private void Update()
    {
        PlayerMOvement();
    }

    void PlayerMOvement()
    {
        float forward = Input.GetAxis("Horizontal");
        float sidewise = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(forward, 0, sidewise) * speed * Time.deltaTime;
        transform.Translate(playerMovement , Space.Self);
    }

    void Jump()
    {

    }
}
