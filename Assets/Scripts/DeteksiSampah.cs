using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //kaya import menambahkan library unity engine ui

public class DeteksiSampah : MonoBehaviour {

    public string nameTag; //Digunakan untuk menyimpan string namaTag yang nanti akan digunakan untuk filter gameobject apa saja yang akan di proses.
    public AudioClip audioBenar;  //Digunakan untuk menyimpan resources audio yang nanti diperoleh dari file audio yang terdapat di Panel Project.
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah; // Digunakan untuk control audio baik itu untuk play, loop, pause dan stop.
    public Text textscore; //Digunakan untuk menampilkan score yang telah didapat dan pastikan sudah menambah library using UnityEngine.UI;
  //  GameObject[] gos;
    // Use this for initialization 
    void Start () { //Digunakan untuk mendeklarasikan audio pada Control Audio supaya dapat dimodifikasi.
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;


      //  gos = GameObject.FindGameObjectsWithTag("Organik");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //  Debug.Log(collision);
        //   Debug.Log(gos[0]);
        //   if (collision.tag.Equals(GameObject.FindGameObjectsWithTag("Organik")) || collision.tag.Equals(GameObject.FindGameObjectsWithTag("NonOrganik")))
        if (collision.tag.Equals(nameTag))
        {
           
            Data.score += 25;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else {

            Data.score -= 25;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();

        }

    }


    // Update is called once per frame
    void Update () {
		
	}
}
