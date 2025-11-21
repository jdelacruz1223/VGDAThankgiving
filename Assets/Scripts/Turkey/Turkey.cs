using UnityEngine;

public class Turkey : MonoBehaviour
{
    [SerializeField] float health;

    public void ShootTurkey(float damage = 0)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
