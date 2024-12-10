using UnityEngine;

public class TeleportControl : Interactive
{
    public float posX;
    public float posY;
    private void Update()
    {
        ObjectInteractive(posX, posY);
    }
}
