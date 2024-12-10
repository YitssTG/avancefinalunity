using UnityEngine;

public class PuertaConllave : MonoBehaviour
{
    public string llave;
    public NewScene scena;
    private bool active;
    public static bool operator ==(PuertaConllave puertaConllave, Inventario inventario)
    {
        for (int i = 0; i < inventario.Llaves.Length; i++)
        {
            if (puertaConllave.llave == inventario.Llaves[i])
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator !=(PuertaConllave puertaConllave, Inventario inventario)
    {
        for (int i = 0; i < inventario.Llaves.Length; i++)
        {
            if (puertaConllave.llave != inventario.Llaves[i])
            {
                return false;
            }
        }
        return true;
    }
    private void Update()
    {
        if (active==true&&Input.GetKeyDown(KeyCode.E))
        {
            scena.CambiarScena("Game 1");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active = this == collision.gameObject.GetComponent<Inventario>();
            Debug.Log(active);
        }
    }
}
