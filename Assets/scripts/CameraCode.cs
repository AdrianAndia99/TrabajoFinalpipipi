using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    public GameObject _personaje;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(_personaje.transform.position.x, _personaje.transform.position.y,-10);
         
    }
}
