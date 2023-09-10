using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinns : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
          Scoree.coinA += 10;
          Destroy (gameObject); 
          SceneManager.LoadScene("budaya2"); 

    if(Scoree.coinA>120)  {

        SceneManager.LoadScene("GameWin"); 

    }
    }
}