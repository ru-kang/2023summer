using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private Score score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Enemy"){
            score.addScore();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag=="Wall"){
            Destroy(this.gameObject);
        }
    }
}
