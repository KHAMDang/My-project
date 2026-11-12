using System.Reflection.Emit;
using UnityEngine;

public class PlayerPlane : MonoBehaviour
{
    public
    float speed = 10f;
    float rotatespeed = 720f;
    private float fFirerate = 0.5f;
    private float fShootTimer = 0;
    private float fHitCount = 0;
    public float fMAXHP = 5;

    public PlayerBullet bullet;

    void Move()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, verticalAxis);

        this.transform.position += direction*(speed*Time.deltaTime);


        if(direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotatespeed * Time.deltaTime);
        }
        else
        {
            speed = 10f;
        }

    }

    void ShootBullet()
    {
        fShootTimer += Time.deltaTime;
        if(Input.GetKey(KeyCode.Space))
        {
            if(fShootTimer >= fFirerate)
            {
                Instantiate(bullet, this.transform.position, Quaternion.identity);
                fShootTimer = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<BaseEnemyBullet>() != null)
        {

            fHitCount += 1f;
            Destroy(collision.gameObject);
            if(fHitCount >= fMAXHP)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Start()
    {
    }

    void Update()
    {

        Move();
        ShootBullet();

    }
}
