using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 5f, ForceMode.VelocityChange);
        }
    }
}
