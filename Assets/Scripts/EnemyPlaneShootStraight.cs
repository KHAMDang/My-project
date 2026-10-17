using System.Data.Common;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class EnemyPlane : BaseEnemy
{
    public float fSpeed;
    public Vector3 direction = new Vector3(1f,0,0);

}
