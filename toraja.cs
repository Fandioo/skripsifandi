using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toraja : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
          Scoree.coinA += 10;
          Destroy (gameObject); 
          SceneManager.LoadScene("toraja"); 

    if(Scoree.coinA>120)  {

        SceneManager.LoadScene("GameWin"); 

    }
    }
}