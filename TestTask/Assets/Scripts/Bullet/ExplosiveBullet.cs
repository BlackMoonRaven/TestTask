using UnityEngine;

public class ExplosiveBullet : Bullet
{
    protected override void OnHit() => gameObject.GetComponent<SphereCollider>().radius = 13f;
}
