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
    void disparoEnemigo()
    {
        if (attactkTruFal.positionPlayer != null)
        {
            GameObject temp = Instantiate(dizparoEnemigo,transform.position,transform.rotation);
            temp.tag = this.gameObject.tag;
            Vector2 direction = positionPlayer.position - transform.position;
            direction.Normalize();
            temp.GetComponent<BulletVelocity>().VelocityBullet(direction);
        }
    }
    public override void anotherTargetPlayer()
    {
        base.anotherTargetPlayer();
    }
}
