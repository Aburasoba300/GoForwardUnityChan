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
        if (collision.gameObject.tag == "UnityChan")
        {
            //Unity�����Ƃ̏Փˎ��ɉ�����Ȃ��悤�ɂ���
            GetComponent<AudioSource>().volume = 0;
        }

        if(collision.gameObject.tag == "Cube" || collision.gameObject.tag == "ground")
        {
            //Cube���n�ʏՓˎ��ɉ����Ȃ�悤�ɂ���
            GetComponent<AudioSource>().volume = 0.3f;
        }
    }
}
