using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{

    private static LevelsManager instance ;


    private void Awake()
    {
        if(LevelsManager.instance != null)
        {
            Debug.LogError("More 1 instantiete in Programm. Abnormal programm termination ");
        }

        instance = this;
    }


    private static void print1()
    {
        print(" ****************  Prin 1 ");
    }

    private static void print3()
    {
        print(" ****************  Prin 3 ");
    }

    public static void print2()
    {
        print(" public void  ************* Prin 1 ***************");
        print3();

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
