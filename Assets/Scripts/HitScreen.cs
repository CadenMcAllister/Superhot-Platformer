using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitScreen : MonoBehaviour
{
public GameObject m_GotHitScreen;

private void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.tag == "cube"){
        gotHurt();
    }}

    // Update is called once per frame
    void Update(){
    
        if(m_GotHitScreen != null){
            if (m_GotHitScreen.GetComponent<Image>().color.a > 0){
                var color = m_GotHitScreen.GetComponent<Image>().color;
                color.a -= 0.01f;
                m_GotHitScreen.GetComponent<Image>().color = color;
            }
    
    }
    }

void gotHurt(){
var color = m_GotHitScreen.GetComponent<Image>().color;
    color.a = 0.8f;
    m_GotHitScreen.GetComponent<Image>().color = color;
}

}