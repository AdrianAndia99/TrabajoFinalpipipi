using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGigant : Enemy
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.gameObject.CompareTag("Player"))
        {
            transform.localScale = transform.localScale + new Vector3(1f, 1f, 0f);
        }
    }
    public override void anotherTargetPlayer()
    {
        base.anotherTargetPlayer();
    }
}
