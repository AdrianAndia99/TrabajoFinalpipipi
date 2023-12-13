using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamecontrolXD : MonoBehaviour
{
    
    public void Perder() 
    {
        SceneManager.LoadScene("PantallaPerdiste");
    }
}
