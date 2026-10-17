using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public BaseEnemyBullet Ebullet;

    public float fMAXHP;
    public float fHitCount = 0;

    public float fFirerate;
    public float fNumBullets;
    public float fTimePerBullet;

    public float fFireTimer = 0;
    public float fBulletCount = 0;
    public float fBulletTimer = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerBullet>() != null)
        {

            fHitCount += 1f;
            Destroy(collision.gameObject);
            if(fHitCount >= fMAXHP)
            {
                Destroy(this.gameObject);
                EnemyManager._i.EnemyDie(this);
            }
        }
    }

    public void ShootBullet()
    {

        if(fFireTimer >= fFirerate)
        {
            if(fBulletCount < fNumBullets)
            {
                fBulletTimer += Time.deltaTime;
                
                if(fBulletTimer >= fTimePerBullet)
                {
                    fBulletTimer = 0;

                    float angle = 60f * fBulletCount;
                    BaseEnemyBullet bullet = Instantiate(Ebullet, this.transform.position, Quaternion.identity);
                    bullet.angle_ban = angle;
                    fBulletCount += 1f;
                }

            }
            else
            {
                fBulletCount = 0;
                fBulletTimer = 0;
                fFireTimer = 0;
            }
        }
        else
        {
            fFireTimer += Time.deltaTime;
        }
    }

    protected virtual void Update()
    {
        if(GameManager._cGM.bPaused == true) return;

        ShootBullet();
    }


}
