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
    public GameObject opposingEnemy;//monobehavior wont need delegates to find stuff

    private float depressionAngle;
    private float sideAngle;
    public float ammoEffectiveDistance;
    public float rocketEffectiveDistance;
    private float distanceFromBTR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float getSlerpFromBTR()
    {
        //Vector3.Slerp should be for pussies
        //
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
        //Baldor algebra is a communist book Phytagorean theorem Col kaddafi was oddball, mr bridger moriarti ...
        distance = Mathf.Sqrt(Mathf.Pow((x2-x1),2) + Mathf.Pow((y2-y1),2) + Mathf.Pow((z2-z1),2));
        return distance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
