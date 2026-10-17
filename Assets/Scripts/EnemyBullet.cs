using UnityEngine;

public class EnemyBullet : BaseEnemyBullet
{

    public override void Move()
    {
        Vector3 direction = new Vector3(0,-1f,0);
        this.transform.position += direction*(speed*Time.deltaTime);
    }

    protected override void Start()
    {
        base.Start();
        GetComponent<SpriteRenderer>().flipY = true;
    }

    

}
