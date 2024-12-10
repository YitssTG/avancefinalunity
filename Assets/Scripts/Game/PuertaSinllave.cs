using UnityEngine;

public class PuertaSinllave : Interactive
{
    public float x;
    public float y;
    public KeyCode keyCode;
    private void Update()
    {
        ObjectInteractive(x, y,keyCode);
    }
}
