using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");
    }
}
