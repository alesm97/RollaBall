///////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Alejandro Segura Meléndez
// Curso: 2017:2018
// Fichero: CameraController.cs
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will follow the player
/// </summary>
public class CameraController : MonoBehaviour {

    /// <summary>
    /// reference to the player
    /// </summary>
    public GameObject player;

    /// <summary>
    /// reference to the camera position vector
    /// </summary>
    private Vector3 offset;

    /// <summary>
    /// In the beginning we will save the vectorial distance between the camera and the player
    /// </summary>
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    /// <summary>
    /// In every single frame, update the cameras position to kept the vectorial distance
    /// </summary>
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
