using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocity : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float velocity1;
    public float damage;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void VelocityBullet(Vector2 velocity2)
    {
        _rigidbody2D.velocity = velocity2 * velocity1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Pared")
        {
            Destroy(this.gameObject);
        }
    }
}
