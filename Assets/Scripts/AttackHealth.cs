using UnityEngine;

public class AttackHealth : MonoBehaviour
{
    private int health = 150;
    public static int range = 20;
    public Bullet bullet;
    public GameObject gameOver;
    private void Start()
    {
        gameOver.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity); //метод для создания копий из скрипта

        }
        if (health <= 0)
        {

            gameOver.SetActive(true);

        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "EnemyBullet")
        {
            health = health - Enemy.range;
        }
    }
}
