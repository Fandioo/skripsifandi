using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class materi : MonoBehaviour
{
    public void scene(string scene)
    {
        Application.LoadLevel (scene);
    }
}
