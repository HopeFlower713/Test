using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 0.7f;
    private void Start()
    {

    }
    void Update()
    {
            transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" && collider.tag == "Wall")
        {
            Destroy(this);
        }
    }
}
