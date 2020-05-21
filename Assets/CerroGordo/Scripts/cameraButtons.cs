using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *         .-------------------.
 *        /--"--.------.------/|
 *        |Kodak|__Ll__| [==] ||
 *        |     | .--. | """" ||
 *        |     |( () )|      ||
 *   jgs  |     | `--' |      |/
 *        `-----'------'------'
 *
 *------------------------------------------------
 * Karla Hernandez selfied next to an ICBM ...
 *
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class cameraButtons : MonoBehaviour
{
    protected bool gun_camera_is_hidden =  true;
    protected bool radar_camera_is_hidden =  true;
    protected bool rearview_camera_is_hidden = true;
    protected bool main_camera_is_hidden = false;
    protected bool sound_is_on = true;
    protected int buttons_x_corner = 200;

    public GUISkin btnSkin;
    public Texture2D GunCamera2d;
    public Texture2D RadarIcon;
    public Texture2D RearViewIcon;
    public Texture2D MainCameraIcon;
    public Texture2D SoundIcon;
    public GameObject gun_camera;
    public GameObject radar_camera;
    public GameObject main_camera;
    public GameObject rearview_camera;
    public AudioSource audioData;

    void Start()
    {
        this.audioData = GetComponent<AudioSource>();
        this.audioData.Play(0);
        this.gun_camera.SetActive(false);
        this.radar_camera.SetActive(false);
        this.rearview_camera.SetActive(false);
    }

    void OnGUI(){
      GUI.skin = this.btnSkin;
      GUI.Box(new Rect(this.buttons_x_corner,10,265,90), "Cameras");
      if(GUI.Button(new Rect(this.buttons_x_corner+10,40,40,40), GunCamera2d))
        {
            if(this.gun_camera_is_hidden){
                this.gun_camera_is_hidden = false;
                this.gun_camera.SetActive(true);

                this.main_camera_is_hidden = true;
                this.main_camera.SetActive(false);
                this.radar_camera_is_hidden = true;
                this.radar_camera.SetActive(false);
                this.rearview_camera_is_hidden = true;
                this.rearview_camera.SetActive(false);
            } else {
                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);
                this.main_camera.SetActive(true);
            }
        }
    
        if(GUI.Button(new Rect(this.buttons_x_corner+55,40,40,40), RadarIcon)) 
        {
            if(this.radar_camera_is_hidden){
                this.radar_camera_is_hidden = false;
                this.radar_camera.SetActive(true);

                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);

                this.main_camera_is_hidden = true;
                this.main_camera.SetActive(false);
                this.rearview_camera_is_hidden = true;
                this.rearview_camera.SetActive(false);
            } else {
                this.radar_camera_is_hidden = true;
                this.radar_camera.SetActive(false);
                this.main_camera.SetActive(true);
            }
        }

        if(GUI.Button(new Rect(this.buttons_x_corner+105,40,40,40), RearViewIcon)) 
        {
            if(this.rearview_camera_is_hidden){
                this.rearview_camera_is_hidden = false;
                this.rearview_camera.SetActive(true);

                this.radar_camera_is_hidden = true;
                this.radar_camera.SetActive(false);

                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);

                this.main_camera_is_hidden = true;
                this.main_camera.SetActive(false);
               
            } else {
                this.rearview_camera_is_hidden = true;
                this.rearview_camera.SetActive(false);
                this.main_camera.SetActive(true);
            }
        }

        if(GUI.Button(new Rect(this.buttons_x_corner+155,40,40,40), MainCameraIcon)) 
        {
            
                this.main_camera_is_hidden = false;
                this.main_camera.SetActive(true);

                this.rearview_camera_is_hidden = true;
                this.rearview_camera.SetActive(false);

                this.radar_camera_is_hidden = true;
                this.radar_camera.SetActive(false);

                this.gun_camera_is_hidden = true;
                this.gun_camera.SetActive(false);


            
        }

        if(GUI.Button(new Rect(this.buttons_x_corner+200,40,40,40), SoundIcon)) 
        {
               //Debug.Log("sound click ...");
               if(this.sound_is_on){
                this.audioData.Pause();
                this.sound_is_on = false;
            } else {
                this.audioData.UnPause();
                this.sound_is_on = true;
            }
        }		
  	}

    // Update is called once per frame
    void Update()
    {
            
    }
}
