using UnityEngine;

public class Button : MonoBehaviour
{
    [Header("Reference on bullet creator")]
    [SerializeField] private BulletCreator _bulletCreator;

    public void ChooseBullet(int numberOfBullet) => _bulletCreator.SelectedBullet = numberOfBullet;
}
