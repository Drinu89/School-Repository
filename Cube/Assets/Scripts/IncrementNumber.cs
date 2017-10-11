using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementNumber : MonoBehaviour {

    int num = 1;


    void looping() {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Value Added By 1");
            num = num + 1;
            print(num);
        }

        else
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Value Decrement By 1");
                num = num - 1;
                print(num);
            }
            else
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    print("Value Decrement By 10");
                    num = num - 10;
                    print(num);
                }
                else
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        print("Value Added By 10");
                        num = num + 10;
                        print(num);
                    }
                    else
                        if (num <= 0)
                        {
                            UnityEditor.EditorApplication.isPlaying = false;
                            print("This is the minimum number");
                        }
                        else
                            if (num >= 100)
                            {
                                UnityEditor.EditorApplication.isPlaying = false;
                                print("This is the maximum number");
                            }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        looping();
	}
}
