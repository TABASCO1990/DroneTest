using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

public class PlayerController : MonoBehaviour
{
    
    
    private void Update()
    {
        Move();
    }

    

    private void Move()
    {
        
       
        
        Transform drag = transform;
        if (Input.GetMouseButton(0))
        {
           
            
            Vector3 point;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.up, Vector3.up * transform.position.y);
            float distance;
            
            if (plane.Raycast(ray, out distance))
            {
                point = ray.GetPoint(distance);
                drag.position = Vector3.Lerp(transform.position,
                    new Vector3(point.x, point.y, Mathf.Clamp((point.z + 0.5f)*1.2f, 0, 16f)), 10 * Time.deltaTime);
               
               
            }
            

        }
        Vector3 screen = Camera.main.WorldToScreenPoint(drag.position);
        Ray ray1 = Camera.main.ScreenPointToRay(screen);
        RaycastHit hit;
        Physics.Raycast(ray1, out hit, Mathf.Infinity, 1 << 8);
        Vector3 world = hit.point;
        Debug.DrawLine(transform.position,world,Color.blue);
        
        Vector3 dir = (hit.point - world);
        Debug.DrawLine(world,dir,Color.green);
        //print(dir);


        
        

       float BA_Rad = Mathf.Atan2 (dir.y - world.y, dir.x - world.x);
       print("first = "+BA_Rad);
       float BC_Rad = Mathf.Atan2 (drag.position.y - world.y, drag.position.x - world.x);
       print("second = "+BC_Rad);
       float CA_Ang = (BA_Rad - BC_Rad ) / Mathf.PI * 180;
       print("final = "+CA_Ang);

       transform.localEulerAngles   = new Vector3(0,CA_Ang,0);
    }
    
    
}
