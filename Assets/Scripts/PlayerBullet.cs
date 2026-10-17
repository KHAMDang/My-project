using System.Numerics;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    public Renderer myRenderer;

    void Move()
    {
        UnityEngine.Vector3 direction = new UnityEngine.Vector3(0,1f,0);
        this.transform.position += direction*(speed*Time.deltaTime);
    }


    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        Move();
        if(!myRenderer.isVisible)
        {
            Destroy(gameObject);
        }


    }
}
