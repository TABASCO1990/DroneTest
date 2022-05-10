using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 55f;
    private Vector3 _position;
    private Object bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z > 50)
            Destroy(gameObject);
       
    }
}
