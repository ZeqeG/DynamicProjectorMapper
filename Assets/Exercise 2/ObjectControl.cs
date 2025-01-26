using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ObjectControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject player;

    public float playerSpeed = 1.0f;
    public float playerRotationSpeed = 1.0f;



    public void goForward()
    {
        player.transform.Translate(0, 0, (playerSpeed * Time.deltaTime) * 10);
    }

    public void goBackward()
    {
        player.transform.Translate(0, 0, (playerSpeed * Time.deltaTime) * -10);
    }

    public void goLeft() {
        player.transform.Translate((playerSpeed * Time.deltaTime) * -10, 0, 0);
    }
    public void goRight() {
        player.transform.Translate((playerSpeed * Time.deltaTime) * 10, 0, 0);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float dt = Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = 15f;
            playerRotationSpeed = 55f;

        }
        else
        {
            playerSpeed = 5f;
            playerRotationSpeed = 15f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(playerSpeed * dt, 0, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate((playerSpeed * dt) * -1, 0, 0);

        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0, 0, (playerSpeed * dt) * -1);

        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0, 0, playerSpeed * dt);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(0, (playerRotationSpeed * dt), 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(0, (-1 * playerRotationSpeed) * dt, 0);

        }



    }
}
