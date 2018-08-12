using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour {

    public float jeda = 0.8f; // nilai jeda untuk sampah yang akan muncul
    float timer; // digunakan untuk menyimpan waktu
    public GameObject[] objeckSampah; // digunakan untuk menyimpan object sampah yang ditampilkan

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame, dijalankan terus menerus sesuai dengan prosesor yang dimiliki
	void Update () { 

        timer += Time.deltaTime;
        if (timer > jeda) { //untuk memproses berdasarkan waktu jeda yang telah ditentukan      

            int random = Random.Range(0, objeckSampah.Length); //menentukan index object sampah secara acak yang kan dimunculkan
           // Debug.Log(objeckSampah.Length);

            Instantiate(objeckSampah[random], transform.position, transform.rotation);
           // Instantiate<objeckSampah>(objeckSampah[random], transform.position, transform.rotation);
            timer = 0;

        }

	}   
}
