using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float speed;
    private float horizontal;
    private float vertical;
    public GameObject _bala;
    public Transform _guardabala;
    private Vector2 direccionbala;
    public GamecontrolXD gameController;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        direccionbala = new Vector2(0,1);
    }

    void Update()
    {
        if(horizontal == 1 || horizontal == -1)
        {
            direccionbala = new Vector2(horizontal, 0);

        }else if(vertical ==1 || vertical == -1)
        {
            direccionbala = new Vector2(0, vertical);
        }
        if (horizontal == 0)
        {
            vertical = Input.GetAxisRaw("Vertical");
        }
        if(vertical == 0)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject gameObjectBala = Instantiate(_bala, transform.position, transform.rotation, _guardabala);
            gameObjectBala.tag = this.gameObject.tag;
            gameObjectBala.GetComponent<BulletVelocity>().VelocityBullet(direccionbala);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
            gameController.Perder();
        }
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
