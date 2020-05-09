using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashBoard : MonoBehaviour
{
    private Rect windowRect = new Rect(10,65,170,150);

    void OnGUI(){
      windowRect = GUI.Window(0,windowRect,WindowFunction,"Instuctions");
    }

    void WindowFunction(int windowID){
      //place instructions here ...
      GUI.Label(new Rect(25,25,150,150),"Drive: Arrow Keys \n\nTurn Turret: F, G\n\nElevation: up R down T\n\nShoot: spacebar");
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
