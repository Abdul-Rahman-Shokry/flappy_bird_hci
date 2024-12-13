using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            direction = Vector3.up * strength;
        }

        if (Input.touchCount > 0) 
        {
            
        }
    }
}
