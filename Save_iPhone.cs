using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using UnityEngine;

public class Save : MonoBehaviour
{
    string path = "/MyTest.txt";

    int Var1 = 0;
    int Var2 = 0;
    int Var3 = 0;

    void Start()
    {
        // It's a special path for IOS
        if (!File.Exists(Application.persistentDataPath+path))
        {
            // Create a file to write to.
            StreamWriter sw = File.CreateText(Application.persistentDataPath+path);
            Debug.Log("create file");

        }else{

            int change = 0;

            string[] line = File.ReadAllLines(Application.persistentDataPath+path);

            //Read line by line
            foreach (string s in line)
            {                
                if (change == 0){
                    Var1 = int.Parse(s); //Parse => string to int
                }if (change == 1){
                    Var2 = int.Parse(s);
                }if (change == 2){
                    Var3 = int.Parse(s);
                }
                change++;
            }
        }
    }
    void Update()
    {
        
    }
    public void save(){

        Var1 = 1;
        Var2 = 2;
        Var3 = 3;

        if (File.Exists(Application.persistentDataPath+path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(Application.persistentDataPath+path))
            {
                //Write line by line
                sw.WriteLine(Var1);
                sw.WriteLine(Var2);
                sw.WriteLine(Var3);
            }
        }
        else{
            Debug.Log("no file");
            
        }
    }

}
