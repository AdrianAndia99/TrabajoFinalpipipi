using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacker : Enemy
{
    public GameObject dizparoEnemigo;
    public AttackTruFal attactkTruFal;

    private void Update()
    {
        if(attactkTruFal.siono == true)
        {
            disparoEnemigo();
        }
    }
    public void disparoEnemigo()
    {
        if (attactkTruFal.positionPlayer != null)
        {
            GameObject temp = Instantiate(dizparoEnemigo,transform.position,transform.rotation);
            temp.tag = this.gameObject.tag;
           // Vector2 direction = 
            temp.GetComponent<BulletVelocity>().VelocityBullet(attactkTruFal.positionPlayer.transform.position);
        }
        
    }
}
