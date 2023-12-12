using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, objetivo.position, velocidad);      
    }
    public void FollowPlayer(Transform playerPosition)
    {
        objetivo = playerPosition;
    }

}
