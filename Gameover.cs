using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
          Scoree.coinA += 0;
          Destroy (gameObject);
        SceneManager.LoadScene("gameover"); 
    }
}