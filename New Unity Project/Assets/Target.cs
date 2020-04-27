
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 1f;
    private Vector3 initPos;

    private void Start()
    {
        initPos = transform.localPosition;
    }

    private void Update()
    {
        transform.position = initPos + new Vector3(0, Mathf.Sin(Time.time), 0);
    }

    public void takeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
