using UnityEngine;

public class Inventario : MonoBehaviour
{
    public string[] llaves = new string[10];
    public string[] Llaves { get { return llaves; }set { llaves = value; } }
    private int quantity;
    public void Add(string llave)
    {
        llaves[quantity] = llave;
        ++quantity;
    }
}
