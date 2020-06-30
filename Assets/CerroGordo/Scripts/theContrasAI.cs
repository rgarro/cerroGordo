using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *          .----.                                                  .'.
 *      |  /   '                                                 |  '
 *        |  |    '                                                '  :
 *        |334916  '             .-~~~-.               .-~-.        \ |
 *        |  |      '          .\\   .//'._+_________.'.'  /_________\|
 *        |  |___ ...'.__..--~~ .\\__//_.-     . . .' .'  /      :  |  `.
 *       |.-"  .'  /                          . .' .'   /.      :_.|__.'
 *      <    .'___/                           .' .'    /|.      : .'|\
 *       ~~--..                             .' .'     /_|.      : | | \
 * JRO     /_.' ~~--..__             .----.'_.'      /. . . . . . | |  |
 *                     ~~--.._______'.__.'  .'      /____________.' :  /
 *                              .'   .''.._'______.'                '-'
 *                              '---'
 *   ==== LOVE IS ON THE AIR -- TheContrasAI ===== 
 *   Ronald Reagan Wanted me to do this. Marge Simpson is a Crocodile ...
 *
 *@autor Rolando <rgarro@gmail.com>
 */
public class theContrasAI : MonoBehaviour
{
    public GameObject mm23Cannon;
    public GameObject k114Shturm;
    private GameObject opposingEnemy;//monobehavior wont need delegates to find stuff

    private float depressionAngle;
    private float sideAngle;
    public float ammoEffectiveDistance;
    public float rocketEffectiveDistance;
    private float distanceFromBTR;
    public int mm23CannonDamping;
    private float nextFire = 0;
    public float fireRate = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        this.setOpposingEnemy();
    }

    private void setOpposingEnemy()
    {
        this.opposingEnemy = GameObject.FindWithTag("theBTR");
    }

    void mm23CannonPointsAtBTR()
    {
        //Vector3.lookAt
        //Vector3.RotateTowards
        var lookPos = this.opposingEnemy.transform.position - this.transform.position;
         //lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        this.mm23Cannon.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * this.mm23CannonDamping); 
    }

    void m23CannonShootsRays(){
        Debug.Log("shooting here......");
        RaycastHit hit;
        if(Physics.Raycast(this.transform.position,this.transform.forward,out hit,this.ammoEffectiveDistance)){
            //where to go from here
            Debug.Log("bombs away ......");
        }
    }
    float getDistanceFromBTR()
    {
        float distance;
        //Vector3.Distance(this.transform.position,opposingEnemy.transform.position) is for pussies ...
        //D(P1, P2) = √(x2 − x1)power2 + (y2 − y1)power2 + (z2 − z1)power2.
        float x2 = this.opposingEnemy.transform.position.x;
        float x1 = this.transform.position.x;
        float y2 = this.opposingEnemy.transform.position.y;
        float y1 = this.transform.position.y;
        float z2 = this.opposingEnemy.transform.position.z;
        float z1 = this.transform.position.z;
        //Baldor algebra is a communist book ...
        distance = Mathf.Sqrt(Mathf.Pow((x2-x1),2) + Mathf.Pow((y2-y1),2) + Mathf.Pow((z2-z1),2));
        return distance;
    }

    // Update is called once per frame
    void Update()
    {
        this.distanceFromBTR = this.getDistanceFromBTR();
        if(this.distanceFromBTR < this.ammoEffectiveDistance){
            this.mm23CannonPointsAtBTR();
            if(Time.time > this.nextFire){
                this.nextFire = Time.time + this.fireRate;
                this.m23CannonShootsRays();
            }
        }
    }
}
