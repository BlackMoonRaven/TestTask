using System.Collections;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected void OnCollisionEnter(Collision collision)
    {
        OnHit();
        StartCoroutine(DestroyBullet());
    }

    protected abstract void OnHit();

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
