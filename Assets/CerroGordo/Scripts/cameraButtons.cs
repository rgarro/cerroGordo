using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraButtons : MonoBehaviour
{
    protected bool gun_camera_is_hidden =  false;
    protected int buttons_x_corner = 200;

    public GUISkin btnSkin;

    public Texture2D GunCamera2d;
    public Texture2D RadarIcon;

    void OnGUI(){
      GUI.skin = this.btnSkin;
      GUI.Box(new Rect(this.buttons_x_corner,10,100,90), "Cameras");
      if(GUI.Button(new Rect(this.buttons_x_corner+10,40,40,40), GunCamera2d))
        {
            Debug.Log("add component here 111");
        }
    
        if(GUI.Button(new Rect(this.buttons_x_corner+55,40,40,40), RadarIcon)) 
        {
            Debug.Log("add component here 222");
        }	
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
