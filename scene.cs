using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public string namaScene;
    
    public void pindahscene()
    {
        Scene sceneIni = SceneManager.GetActiveScene ();

        if(sceneIni.name != namaScene){
            SceneManager.LoadScene ("math1");
        }
    }
}
