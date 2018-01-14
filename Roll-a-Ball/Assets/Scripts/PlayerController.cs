///////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Alejandro Segura Meléndez
// Curso: 2017:2018
// Fichero: PlayerController.cs
//////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    /// <summary>
    /// Speed which will multiply the movement force.
    /// </summary>
    public float speed;
    /// <summary>
    /// References to the UI texts.
    /// </summary>
    public Text countText;
    public Text winText;

    /// <summary>
    /// Reference to the rigidbody and the count of points.
    /// </summary>
    private Rigidbody rb;
    private int count;

    

    /// <summary>
    /// Asign the rigidbody, set the points to 0, update the UI count text and 'erase' the win text.
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    /// <summary>
    /// Get the horizontal and vertical inputs force, make the vector of movement and apply it to the player.
    /// </summary>
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    /// <summary>
    /// If the player hits a Pick up tagged object, it will be destroy, the points will increase and the UI text will be updated.
    /// </summary>
    /// <param name="other">Reference to the collider of the hitted object</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    /// <summary>
    /// Update of the UI texts of the count and if the player picks the 12 points, show the winner text.
    /// </summary>
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
