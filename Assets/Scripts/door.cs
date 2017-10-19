using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door : MonoBehaviour {
    public int LevelToLoad;
    //public Text text;
 //  private void hi;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("a"))
        {
         SceneManager.LoadScene("Scene3");
        } 
    }
}
