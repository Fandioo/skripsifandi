using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coinn : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
          Scoree.coinA += 10;
          Destroy (gameObject); 
          SceneManager.LoadScene("bugis"); 

    if(Scoree.coinA>40)  {

        SceneManager.LoadScene("GameWin"); 

    }
    }
}