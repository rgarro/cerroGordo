using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraButtons : MonoBehaviour
{
    protected bool gun_camera_is_hidden =  false;
    protected bool radar_camera_is_hidden =  false;
    protected int buttons_x_corner = 200;

    public GUISkin btnSkin;
    public Texture2D GunCamera2d;
    public Texture2D RadarIcon;
    public GameObject gun_camera;
    public GameObject radar_camera;

    void OnGUI(){
      GUI.skin = this.btnSkin;
      GUI.Box(new Rect(this.buttons_x_corner,10,100,90), "Cameras");
      if(GUI.Button(new Rect(this.buttons_x_corner+10,40,40,40), GunCamera2d))
        {
            if(this.gun_camera_is_hidden){
                this.gun_camera_is_hidden = false;
                this.gun_camera.SetActive(true);
            } else {
                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);
            }
        }
    
        if(GUI.Button(new Rect(this.buttons_x_corner+55,40,40,40), RadarIcon)) 
        {
            if(this.radar_camera_is_hidden){
                this.radar_camera_is_hidden = false;
                this.radar_camera.SetActive(true);
            } else {
                this.radar_camera_is_hidden = true;
                this.radar_camera.SetActive(false);
            }
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
