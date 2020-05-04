

using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 1f;
    private Vector3 initPos;
    public float count = 0;
    public AudioClip targetS;

    AudioSource audioS;

    private void Start()
    {
        initPos = transform.localPosition;
        audioS = GetComponent<AudioSource>();
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
        audioS.PlayOneShot(targetS);
        count++;
        Debug.Log(count);
    }
}
