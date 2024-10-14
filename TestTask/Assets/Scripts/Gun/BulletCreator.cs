using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    [Header("References on bullets")]
    [SerializeField] private List<GameObject> _bulletPrefabs = new();
    [Space]
    [Header("Bullet`s speed")]
    [SerializeField] private float _bulletVelocity = 200f;

    public int SelectedBullet { get; set; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shot());
        }
    }

    private IEnumerator Shot()
    {
        yield return new WaitForSeconds(1);
        GameObject newBullet = Instantiate(_bulletPrefabs[SelectedBullet], transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
    }
}
