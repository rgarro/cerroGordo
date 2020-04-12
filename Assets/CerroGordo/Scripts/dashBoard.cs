using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashBoard : MonoBehaviour
{
    private Rect windowRect = new Rect(20,20,120,50);

    void OnGUI(){
      windowRect = GUI.Window(0,windowRect,WindowFunction,"Instuctions");
    }

    void WindowFunction(int windowID){
      //place instructions here ...
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
