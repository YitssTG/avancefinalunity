using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movimientoEnemigo1 : MonoBehaviour
{
    Rigidbody2D _commponentRigidbody2d;
    SpriteRenderer _spriteRenderer;
    public float speedx;
    public float minlimit;
    public float maxlimit;
    private int direction;
    public float incrementSpeed = 2f;
    public bool playervision;
    public bool enemyActive;
    void Awake()
    {
        _commponentRigidbody2d = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (enemyActive)
        {
            direction = 1;
        }
    }
    private void FixedUpdate()
    {
        _commponentRigidbody2d.velocity = new Vector2(direction * speedx, _commponentRigidbody2d.velocity.y);
    }
    public void EnemySpeed()
    {
        _commponentRigidbody2d.velocity = new Vector2(direction * speedx, _commponentRigidbody2d.velocity.y);
    }
}
