using System;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 1f;
    private float stopPosition = -108f;
    public static bool isMove = true;
    void Update()
    {
        MoveGroud();
    }

    private void MoveGroud()
    {
        if (isMove)
        {
            if (transform.position.z > stopPosition)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            else
            {
                isMove = false;
            }
        }
    }
}
