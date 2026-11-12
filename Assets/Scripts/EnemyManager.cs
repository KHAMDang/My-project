using System.Collections.Generic;
using UnityEngine;

public class EnemyManager: MonoBehaviour
{
    public static EnemyManager _i;
    public List<BaseEnemy> enemyPrefabs;

    public List<BaseEnemy> enemyActives;

    public void Awake()
    {
        _i = this;
    }

    public void EnemyDie(BaseEnemy enemyJustDied)
    {
        this.enemyActives.Remove(enemyJustDied);
        if(enemyActives.Count <=0)
        {
            Debug.Log("Win Game");
            GameManager._cGM.StopGame();
        }        
    }

    void Start()
    {
    
        enemyActives = new List<BaseEnemy>();

        //tạo enemy 0 hàng trên cùng
        for(int i = 0; i < 3; i++)
        {
            BaseEnemy enemyPrefab = enemyPrefabs[0];

            BaseEnemy newEnemy = Instantiate(enemyPrefab, this.transform.position, Quaternion.identity);

            newEnemy.transform.position =  new Vector3(-2+i*2, 3, 0);

            enemyActives.Add(newEnemy);
        }

        //tạo enemy 1 hàng dưới
        for (int i = 0; i < 2; i++)
        {
            BaseEnemy enemyPrefab = enemyPrefabs[1];

            BaseEnemy newEnemy = Instantiate(
                enemyPrefab,
                transform.position,
                Quaternion.identity
            );

            newEnemy.transform.position = new Vector3(-1 + i * 2, 2, 0);

            enemyActives.Add(newEnemy);
        }

    }

    

}
