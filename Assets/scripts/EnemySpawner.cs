using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject [] enemyPrefab;
    public Transform targetPlayer;
    public float tiempo;
    void Start()
    {
        
    }
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 5)
        {
            CreateEnemy();
            tiempo = 0;
        }        
    }
    void CreateEnemy()
    {
        int x = Random.Range(0, 10);
        int y = Random.Range(0, 4);
        int randomEnemy = Random.Range(0, enemyPrefab.Length);
        Vector2 positionEnemy = new Vector2(x,y);
        GameObject enemigo = Instantiate(enemyPrefab[randomEnemy], positionEnemy, transform.rotation);
        enemigo.GetComponent<EnemyControler>().FollowPlayer(targetPlayer);
    }
}
