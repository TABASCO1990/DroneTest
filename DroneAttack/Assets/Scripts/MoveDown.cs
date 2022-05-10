using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 1f;
    private float stopPos = -108f;
    public static bool stopMove;
    void Update()
    {
        MoveGroud();
    }

    private void MoveGroud()
    {
        if (transform.position.z > stopPos)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else
        {
            stopMove = true;
        }
    }
}
