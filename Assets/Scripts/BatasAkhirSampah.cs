using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour {

     void OnTriggerEnter2D(Collider2D collision) //method dijalankan ketika masuk kedalam trigger
    {
        Destroy(collision.gameObject); // menghancurkan / menghapus game object yang masuk ke area
        SceneManager.LoadScene("gameover", LoadSceneMode.Single);

    }
}
