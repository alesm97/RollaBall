///////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Alejandro Segura Meléndez
// Curso: 2017:2018
// Fichero: Rotator.cs
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will make the points rotate
/// </summary>
public class Rotator : MonoBehaviour {
	
    /// <summary>
    /// Every single frame the object will translate with the vectors value.
    /// </summary>
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
