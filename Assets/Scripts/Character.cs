using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
    public string name;
    public int exp = 0;

    public Character(){
        name = "Not assigned";
        Reset();
    }
    public Character(string name){
        this.name = name;
    }
    public virtual void PrintStatsInfo(){
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }
    
    private void Reset(){
        this.name = "Not Assigned";
        this.exp = 0;
    }
}

public class Paladin: Character{
    
    public Paladin(string name): base(name){
       
    }

    public override void PrintStatsInfo(){
        Debug.LogFormat("Hail {0}!", name);
    }

/*  //Fix Composition chapter 5 to fix this
    public override void PrintStatsInfo(){
        Debug.LogFormat("Hail {0} - take up your {1}!", name,weapon.name);
    }
*/
    /*
    //public Weapon;        //FIX THIS IN COMPOSITION Chapter 5

    public Paladin(string name, Weapon weapon): base(name){
        this.weapon = weapon;
    }
    
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", name);
    }
    */

}
