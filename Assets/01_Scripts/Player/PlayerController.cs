using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    [Tooltip("Velocidad de movimiento del jugador")]
    public float speed = 5f;

    private void Update()
    {
        Move();
        Debug.Log("Movement system active");

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction key pressed");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reset key pressed");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Inventory key pressed");
        }
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}