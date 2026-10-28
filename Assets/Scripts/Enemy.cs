using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemies;
    public int health;
    public static int range;
    public GameObject[] wayPoints;
    bool isEnemy;
    public string[] enemyName = {"Basic", "Strong", "Weak", "Speed"};


    void Start()
    {
         if (enemyName == "Basic")
        {
            health = 150;
            range = 25;
        }
        if (enemyName == "Strong")
        {
            health = 300;
            range = 50;
        }
        if (enemyName == "")
        {
            health = 150;
            range = 25;
        }
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "bullet")
        {
            health = health - AttackHealth.range;
        }
    }
}
