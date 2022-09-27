using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collections : MonoBehaviour
{
    public int score = 0;
    public GameObject desc;
    // Start is called before the first frame update
    void Start(){
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Milk"){
            score = score + 1;
            desc.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "End"){
            SceneManager.LoadScene("End Scene");
        }
    }
}
