using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        //Follows the mosue, Transforming the position as it follows
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        
        
        //Atan get the angle between where the x and y are
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
