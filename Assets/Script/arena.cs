using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arena : MonoBehaviour
{
    string tombol;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(name: "a")){
            tombol = "A pake GetKey(\"a\")";
            Debug.Log(message: tombol);
            plane.gameObject.transform.Rotate(eulers: new Vector3(x:0, y:0, z:0.5f));
        }
        if(Input.GetKey(name: "d")){
            tombol = "D pake GetKey(\"d\")";
            Debug.Log(message: tombol);
            plane.gameObject.transform.Rotate(eulers: new Vector3(x:0, y:0, z:-0.5f));
        }
        if(Input.GetKey(name: "s")){
            tombol = "S pake GetKey(\"s\")";
            Debug.Log(message: tombol);
            plane.gameObject.transform.Rotate(eulers: new Vector3(x:-0.5f, y:0, z:0));
        }
        if(Input.GetKey(name: "w")){
            tombol = "W pake GetKey(\"w\")";
            Debug.Log(message: tombol);
            plane.gameObject.transform.Rotate(eulers: new Vector3(x:0.5f, y:0, z:0));
        }
    }
}
