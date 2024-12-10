using UnityEngine;

public class Tarjeta : MonoBehaviour
{
    public string llave;
    public GameObject panel;
    Inventario inventario;
    private void Update()
    {
        if (inventario!=null &&Input.GetKeyDown(KeyCode.E))
        {
            inventario.Add(llave);
            panel.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inventario= collision.gameObject.GetComponent<Inventario>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inventario = null;
        }
    }
}
