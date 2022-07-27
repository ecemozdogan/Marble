using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightButtonScript : MonoBehaviour
{
    public bool rightButtonHold = false;

    public void Hold()
    {
        rightButtonHold = true;
    }

    public void notHold()
    {
        rightButtonHold = false;
    }

}
