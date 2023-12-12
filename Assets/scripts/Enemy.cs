using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float vida;
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    [SerializeField] protected SpriteRenderer spriteRenderer;
    [SerializeField] protected AudioSource _audio;
    [SerializeField] protected BoxCollider2D boxCollider;
    protected virtual void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    protected void OnDamage(float damage)
    {
        if(vida <= 0)
        {
            spriteRenderer.color = new Color(1, 0, 0, 1);
            boxCollider.enabled = false;
            Destroy(this.gameObject,0.5f);
        }
        else
        {
            vida = vida - damage;
            spriteRenderer.color = new Color(1,0,0,1);
            Invoke("ChangeColor",0.5f);
        }
    }
    protected void ChangeColor()
    {
        spriteRenderer.color = new Color(1,1,1,1);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            float a = other.gameObject.GetComponent<BulletVelocity>().damage;
            this.OnDamage(a);
        }
    }
}