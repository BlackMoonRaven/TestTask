using DG.Tweening;
using UnityEngine;

public class RicoshetBullet : Bullet
{
    private GameObject[] _enemies;

    private void Awake()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    protected override void OnHit()
    {
        Transform target = _enemies[Random.Range(0, 3)].transform;
        transform.DOMove(new Vector3(target.position.x, 5, target.position.z), 1f);
    }
}
