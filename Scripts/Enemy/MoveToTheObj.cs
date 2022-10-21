using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTheObj : MonoBehaviour
{
    private GameObject TheObject;
    public float Speed;
    private Vector3 dist;
    // Start is called before the first frame update
    void Start()
    {
        TheObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //dist = Vector3.Distance(this.gameObject.transform.position, TheObject.transform.position);
        //Debug.Log(Vector3.Distance(this.gameObject.transform.position, TheObject.transform.position));
    }
}
