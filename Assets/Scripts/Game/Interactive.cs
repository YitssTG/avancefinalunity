using UnityEngine;

public abstract class Interactive : MonoBehaviour
{
    protected bool interactivePlayer;
    private GameObject postionPlayer;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactivePlayer = false;
            postionPlayer = null;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactivePlayer = true;
            postionPlayer = collision.gameObject;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactivePlayer = true;
            postionPlayer = collision.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactivePlayer = false;
            postionPlayer = null;
        }
    }
    protected void ObjectInteractive(float x, float y,KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode)&&interactivePlayer==true)
        {
            postionPlayer.transform.position = new Vector2(x, y);
        }
    }
    protected void ObjectInteractive(float x, float y)
    {
        if (interactivePlayer == true)
        {
            Debug.Log(x);
            Debug.Log(y);

            postionPlayer.transform.localPosition = new Vector2(x, y);
        }
    }
}

