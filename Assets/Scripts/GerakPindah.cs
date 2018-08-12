using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float speed = 3f;
    public Sprite[] sprites;  

	// Use this for initialization
	void Start () {
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
