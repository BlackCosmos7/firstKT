using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float speed, jump;
    bool isGround;
    Rigidbody2D rb;
    Vector2 move;

    public GameObject Bullet;
    public Transform BulletPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float dH = Input.GetAxis("Horizontal");
        move.Set(speed * dH, rb.velocity.y);
    }

    


}
