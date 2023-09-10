using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomshuffle : MonoBehaviour
{
    public int[] UrutanKemunculanMusuh = {1, 2 , 3};
    public int UrutanKemunculan;

    public GameObject Posisi1;
    public GameObject Posisi2;
    public GameObject Posisi3;

    public GameObject Musuh1;
    public GameObject Musuh2;
    public GameObject Musuh3;

    private void Awake()
    {
         AcakUrutanKemunculan();
    }

    void Start(){ 
          if (UrutanKemunculanMusuh [0] == 1 && UrutanKemunculanMusuh [1] == 2 && UrutanKemunculanMusuh [2] == 3)
        {
            UrutanKemunculan = 123;
            Musuh1.transform.position = (Posisi1.transform.position);
            Musuh2.transform.position = (Posisi2.transform.position);
            Musuh3.transform.position = (Posisi2.transform.position);
        }
        else if (UrutanKemunculanMusuh [0] == 1 && UrutanKemunculanMusuh [1] == 3 && UrutanKemunculanMusuh [2] == 2)
        {
            UrutanKemunculan = 132;
            Musuh1.transform.position = (Posisi1.transform.position);
            Musuh2.transform.position = (Posisi3.transform.position);
            Musuh3.transform.position = (Posisi2.transform.position); 
        }
        else if (UrutanKemunculanMusuh [0] == 2 && UrutanKemunculanMusuh [1] == 1 && UrutanKemunculanMusuh [2] == 3)
        {
            UrutanKemunculan = 213;
            Musuh1.transform.position = (Posisi2.transform.position);
            Musuh2.transform.position = (Posisi1.transform.position);
            Musuh3.transform.position = (Posisi3.transform.position);
        }
        else if (UrutanKemunculanMusuh [0] == 2 && UrutanKemunculanMusuh [1] == 3 && UrutanKemunculanMusuh [2] == 1)
        {
            UrutanKemunculan = 231;
            Musuh1.transform.position = (Posisi2.transform.position);
            Musuh2.transform.position = (Posisi3.transform.position);
            Musuh3.transform.position = (Posisi1.transform.position);
        }
        else if (UrutanKemunculanMusuh [0] == 3 && UrutanKemunculanMusuh [1] == 1 && UrutanKemunculanMusuh [2] == 2)
        {
            UrutanKemunculan = 312;
            Musuh1.transform.position = (Posisi3.transform.position);
            Musuh2.transform.position = (Posisi1.transform.position);
            Musuh3.transform.position = (Posisi2.transform.position);
        }
        else if (UrutanKemunculanMusuh [0] == 3 && UrutanKemunculanMusuh [1] == 2 && UrutanKemunculanMusuh [2] == 1)
        {
            UrutanKemunculan = 321;
            Musuh1.transform.position = (Posisi3.transform.position);
            Musuh2.transform.position = (Posisi2.transform.position);
            Musuh3.transform.position = (Posisi1.transform.position);
        }
    }
    void Update (){
    }

    public void  AcakUrutanKemunculan()
    {
        for (int PosisiArray = 0; PosisiArray < UrutanKemunculanMusuh.Length; PosisiArray++)
        {
            int PosisiAcakan = UrutanKemunculanMusuh[PosisiArray];
            int PengacakanArray =  Random.Range(PosisiArray,UrutanKemunculanMusuh.Length);
            UrutanKemunculanMusuh [PosisiArray] = UrutanKemunculanMusuh[PengacakanArray];
             UrutanKemunculanMusuh [PengacakanArray] = PosisiAcakan;
        }
    }
}


