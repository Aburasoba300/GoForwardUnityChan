using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Cube" || collision.gameObject.tag == "ground")
        {
            //CubeÇ©ínñ è’ìÀéûÇ…âπÇ™Ç»ÇÈÇÊÇ§Ç…Ç∑ÇÈ
            GetComponent<AudioSource>().Play();
        }
    }
}
