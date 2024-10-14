using System.Collections;
using UnityEngine;

public class ExplosiveBullet : Bullet
{
    [SerializeField] private ParticleSystem _particleSystem;

    protected override void OnHit()
    {
        gameObject.GetComponent<SphereCollider>().radius = 13f;
        StartCoroutine(Explosive());
    }

    private IEnumerator Explosive()
    {
        GameObject effect = Instantiate(_particleSystem.gameObject, transform.position, Quaternion.identity);
        effect.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.3f);
        Destroy(effect);
    }
}
