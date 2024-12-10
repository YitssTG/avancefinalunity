using UnityEngine;

public class ParedControl : MonoBehaviour
{
    public BoxCollider2D colliderEnemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Iterador")
        {
            colliderEnemy.enabled = false;
            print("Entro");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Iterador")
        {
            colliderEnemy.enabled = true;
            print("Salio");
        }
    }
}
