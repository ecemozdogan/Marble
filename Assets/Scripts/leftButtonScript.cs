using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftButtonScript : MonoBehaviour
{
    public bool leftButtonHold = false;

    public void Hold()
    {
        leftButtonHold = true;
    }

    public void notHold()
    {
        leftButtonHold = false;
    }

}
