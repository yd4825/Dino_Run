using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float Level(int score)
    {
        int defaultSpeed = -6;
        int increSpeed = (score * -1) / 100;

        if (increSpeed < -4)
            increSpeed = -4;

        return defaultSpeed + increSpeed;
    }
}
