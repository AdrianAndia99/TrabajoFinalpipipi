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
    protected Transform positionPlayer;
    [SerializeField] protected float velocity;
    public Puntaje _gm;
    protected virtual void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    protected void OnDamage(float damage)
    {
        if(damage >= vida)
        {
            spriteRenderer.color = new Color(1, 0, 0, 1);
            boxCollider.enabled = false;
            Destroy(this.gameObject,0.5f);
            _gm.puntajeConstante();
            print("gaa");
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
        try
        {
            if (other.gameObject.tag == "bala")
            {
                float a = other.gameObject.GetComponent<BulletVelocity>().damage;
                this.OnDamage(a);
            }
        }
        catch (UnityException ex)
        {
        }
    }

    public void refPlayer(Transform transform)
    {
        positionPlayer = transform;
        //print("pipi");
    }
    public virtual void anotherTargetPlayer()
    {       
        if(positionPlayer.gameObject != null)
        {
            Vector2 direction = positionPlayer.position - transform.position;
            direction.Normalize();
            _rigidbody2D.velocity = direction * velocity;
        }       
    }

    protected void FixedUpdate()
    {
        anotherTargetPlayer();
    }
    public void gameManager(Puntaje gm)
    {
        this._gm = gm;
    }
}