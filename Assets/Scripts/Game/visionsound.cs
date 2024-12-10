using UnityEngine;

public class visionsound : MonoBehaviour
{
    public float detectionRadius = 5f;
    private AudioSource audioSource;

    public enemyController enemyController;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void IncrementVelocity(enemyController enemy)
    {
        enemy.speedx *= 2;
    }
    private void DisminuirVelocity(enemyController enemy)
    {
        enemy.speedx /= 2;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IncrementVelocity(enemyController);
            audioSource.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DisminuirVelocity(enemyController);
            audioSource.Stop();
        }
    }
}