using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class PanelControl : MonoBehaviour
{
    bool isIn = false;
    private static List<int> code = new List<int>();
    static int  valueToCheck = 9872;
        bool todosIguales = code.Count > 0 && code.TrueForAll(n => n == valueToCheck);    
        void Update(){
        
Debug.Log(todosIguales);

if(todosIguales)Debug.Log("WiiiiiIIiIiiII");
    }


    public void controlPressed(int state){


switch(state){
    case 1:
    
        code.Add(state);
        break;

    case 2: 
    
        code.Add(state);
        break;
    case 3:
        
        code.Add(state);
    break;
    
    case 4:
        
        code.Add(state);
    break;
    case 5:
    
        code.Add(state);
    break;
    case 6:
        
        code.Add(state);
    break;
    case 7:
        
        code.Add(state);
    break;
    case 8:
        
        code.Add(state);
    break;
    case 9:
    
        code.Add(state);
    break;
    
    
        }

}

void OnTriggerEnter(Collider other)
{

if(other.name == "Player")
{
isIn = true;

}
}
void OnTriggerExit(Collider other){

    
if(other.name == "Player")
{
isIn = false;

}
}
}
