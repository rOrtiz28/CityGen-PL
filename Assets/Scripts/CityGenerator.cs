using UnityEngine;
using System.Collections;

public class CityGenerator : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    public GameObject house1;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public GameObject person1;
    public GameObject person2;
    public GameObject person3;
    public GameObject person4;

    public GameObject plane1;
   


    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
       
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\*UsersAdress*\Python_PL\UserInput.txt");

            foreach (string line in lines)
            {
                var temp = line;
                // Use a tab to indent each line of the file.
                print("\t" + line);
    
                string[] split = line.Split(' ');

                string coor1 = split[1];
                string coor2 = split[2];
                string coor3 = split[3];
                float coor_1 = float.Parse(coor1);
                float coor_2 = float.Parse(coor2);
                float coor_3 = float.Parse(coor3);

                if (split[0].Equals("car"))
                {
                    if(split[4].Equals("1"))
                    {
                        Instantiate(car1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("2"))
                    {
                        Instantiate(car2, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("3"))
                    {
                        Instantiate(car3, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("4"))
                    {
                        Instantiate(car4, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else{
                        Instantiate(car1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);

                    }
                    
                    
                }
                else if (split[0].Equals("house"))
                {
                    if(split[4].Equals("1"))
                    {
                        Instantiate(house1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("2"))
                    {
                        Instantiate(house2, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("3"))
                    {
                        Instantiate(house3, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("4"))
                    {
                        Instantiate(house4, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else{
                        Instantiate(house1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);

                    }
                    
                    
                }
                else if (split[0].Equals("item"))
                {
                    if(split[4].Equals("1"))
                    {
                        Instantiate(item1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("2"))
                    {
                        Instantiate(item2, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("3"))
                    {
                        Instantiate(item3, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("4"))
                    {
                        Instantiate(item4, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else{
                        Instantiate(item1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);

                    }
                    
                    
                }
                else if (split[0].Equals("person"))
                {
                    if(split[4].Equals("1"))
                    {
                        Instantiate(person1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("2"))
                    {
                        Instantiate(person2, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("3"))
                    {
                        Instantiate(person3, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else if(split[4].Equals("4"))
                    {
                        Instantiate(person4, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                    else{
                        Instantiate(person1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);

                    }
                    
                    
                }
                else if (split[0].Equals("plane"))
                {
                    if(split[4].Equals("1"))
                    {
                        Instantiate(plane1, new Vector3(coor_1, coor_2, coor_3), Quaternion.identity);
                    }
                }
            }
            
 
        }
       
    }
}