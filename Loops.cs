using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    
    void Start()
    {

        int[] numbers = new int[10];
        /*
        numbers[0] = 4;
        numbers[1] = 40;
        numbers[2] = 1;
        numbers[3] = 67;
        numbers[4] = 23;
        numbers[5] = 33;
        numbers[6] = 1;
        numbers[7] = 77;
        numbers[8] = 57;
        numbers[9] = 3;
        */
        int Biggestnumber = int.MinValue; //numbers[0];
        int Smallestnumber = int.MaxValue; //numbers[0];

        int count = 0;
        int Arraycount = 0;
        while (Arraycount < numbers.Length)
        {
            numbers[Arraycount] = Random.Range(0, 101);
            Arraycount++;
        }
        for(; Arraycount <numbers.Length;)
        {

        }
        while (count < numbers.Length)
        {
            
            if (numbers[count] > Biggestnumber)
            {
                Biggestnumber = numbers[count];
               
            }
            if (numbers[count] < Smallestnumber)
            {
                Smallestnumber = numbers[count];
            }
            count++;
        }
        Debug.Log("Biggest number is " + Biggestnumber);
        Debug.Log("smallest number is " + Smallestnumber);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
