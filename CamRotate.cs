using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 turn;
    public float sensitivity = .5f;

    // Update is called once per frame
    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

    }
}
