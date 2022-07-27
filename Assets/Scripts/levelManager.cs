using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject player;

    public bool lev1 = true;
    public bool lev2 = false;
    public bool lev3 = false;

    public float target_pos = 600;
 
    void FixedUpdate()
    {
        float cur_pos = player.transform.position.z;
        
            if(cur_pos >= target_pos)
            {
                if (lev1)
                {
                    level1.transform.position = new Vector3(level1.transform.position.x, level1.transform.position.y, level1.transform.position.z + 600);
                    lev1 = false;
                    lev2 = true;
                    lev3 = false;
                }
                else if (lev2)
                {
                    level2.transform.position = new Vector3(level2.transform.position.x, level2.transform.position.y, level2.transform.position.z + 600);
                    lev1 = false;
                    lev2 = false;
                    lev3 = true;
                }
                else if (lev3)
                {
                    level3.transform.position = new Vector3(level3.transform.position.x, level3.transform.position.y, level3.transform.position.z + 600);
                    lev1 = true;
                    lev2 = false;
                    lev3 = false;
            }
                target_pos = target_pos + 200;
            }
        
    }
}
