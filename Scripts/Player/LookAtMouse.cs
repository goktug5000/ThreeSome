using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public Camera m_camera;
    void Start()
    {
        m_camera = Camera.main; ;  // Don't keep calling Camera.main
    }

    void Update()
    {
        var dir = Input.mousePosition - m_camera.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle -= 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.down);
    }

    
}
