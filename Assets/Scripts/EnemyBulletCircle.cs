using UnityEngine;

public class EnemyBulletCircle : BaseEnemyBullet
{

    public override void Move()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, angle_ban);

        Vector3 direction = new Vector3(
            x: Mathf.Sin(angle_ban * Mathf.Deg2Rad),
            y: Mathf.Cos(angle_ban * Mathf.Deg2Rad), 
            0
        );

        this.transform.position += direction * Time.deltaTime * speed;
    }


}
