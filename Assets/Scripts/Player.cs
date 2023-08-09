using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Score score;

    private void Start(){
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
}
