using UnityEngine;

public class BaseEnemyBullet : MonoBehaviour
{
    public float speed;
    public Renderer myRenderer;
    public float angle_ban;

    public virtual void Move()
    {
        
    }

    protected virtual void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    protected virtual void Update()
    {
        if(GameManager._cGM.bPaused == true) return;

        Move();
        if(!myRenderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
