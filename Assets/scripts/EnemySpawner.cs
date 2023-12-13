using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy[] enemyPrefab;
    public Transform targetPlayer;
    public float tiempo;
    public Puntaje controlaPuntos;
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 5 && targetPlayer !=null)
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
        GameObject enemigo = Instantiate(enemyPrefab[randomEnemy].gameObject, positionEnemy, transform.rotation);
        enemigo.GetComponent<Enemy>().refPlayer(targetPlayer);
        enemigo.GetComponent<Enemy>().gameManager(controlaPuntos);
    }
}
