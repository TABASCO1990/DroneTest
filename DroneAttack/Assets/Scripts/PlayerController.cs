using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 tagetPos = new Vector3(0,0,-14);

    private void Update()
    {
        Move();    
    }
 
    private void Move()
    {
        Transform player = transform;
        if (Input.GetMouseButton(0))
        {  
            Vector3 point;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.up, Vector3.up * player.position.y);
            float distance;
            
            if (plane.Raycast(ray, out distance))
            {
                point = ray.GetPoint(distance);
                player.position = Vector3.Lerp(player.position,
                    new Vector3(point.x, point.y, Mathf.Clamp((point.z + 0.5f)*1.2f, 0, 16)), 10 * Time.deltaTime);   
            }
            
            Vector3 offset = player.position - tagetPos;
            transform.LookAt(player.position + offset);
        }   
    }   
}
