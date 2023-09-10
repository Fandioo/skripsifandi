using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ambilitem : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
          Scoree.coinA += 10;
          Destroy (gameObject); 
          SceneManager.LoadScene("makassar"); 

    if(Scoree.coinA>40)  {

        SceneManager.LoadScene("GameWin"); 

    }
    }
}