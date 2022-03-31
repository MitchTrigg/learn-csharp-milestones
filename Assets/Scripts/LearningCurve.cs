using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;




    public int[] arr1= {0,10,20};
    public bool HasDungeonKey = true;

    public bool PureOfHeart = true;
    public bool HasSecretIncanctation = false;
    public string RareItem = "Relic Stone";


    string CharacterAction = "Attack";


    private int CurrentAge = 30;
    public int AddedAge = 1;
    public float Pi = 3.14f;
    public string FirstName = "Mitchell";
    public bool IsTall = true;
    public int CurrentGold = 32;
    int PlayerLives = 3;

    //This is a single line comment

    /*This is a multi line
    comment */



    // Start is called before the first frame update
    void Start()
    {      
        //DirectionLight = GameObject.Find("Directional Light");
        GameObject.Find("Directional Light").GetComponent<Transform>();
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);


        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);
        
        Paladin knight = new Paladin("Sir Arthur");
        knight.PrintStatsInfo();


        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        
        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Sir Krane the Brave";
        hero2.PrintStatsInfo();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        HealthStatus();


        Dictionary<string, int> ItemInventory = new Dictionary<string,int>(){
            { "Potion", 5},{ "Antidote", 7 }, {"Aspirin", 1}
        };
        Debug.LogFormat("Items: {0}", ItemInventory.Count);

        foreach(KeyValuePair<string, int> kvp in ItemInventory){
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }

        List<string> QuestPartyMembers = new List<string>(){"Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

        for(int i=0;i<QuestPartyMembers.Count; i++){
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }

        foreach(string partyMember in QuestPartyMembers){
            Debug.LogFormat("{0} - Here!", partyMember);
        }

        Debug.Log(arr1[1]);
        PrintCharacterAction();
        Thievery();
        if(HasDungeonKey){
            Debug.Log("You possess the sacred key - enter.");
        }
        else{
            Debug.Log("You have not proved yourself yet.");
        }

        OpenTreasureChamber();


        ComputeAge();
        Debug.Log($"A string can have variable like {FirstName} inserted directly!");
        Debug.Log("A string" + "+" + "Another string");

        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));
    }

    public void HealthStatus(){
        while(PlayerLives > 0){
            Debug.Log("Still alive!");
            PlayerLives --;
        }
        Debug.Log("Player KO'd...");
    }


    public void PrintCharacterAction(){
        switch(CharacterAction){
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
            Debug.Log("To arms!");
            break;
        }
    }


    public void OpenTreasureChamber(){
        if(PureOfHeart && RareItem == "Relic Stone"){
            if(!HasSecretIncanctation){
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else{
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else{
            Debug.Log("Come back when you have what it takes.");
        }
    }
    

    public void Thievery(){
            if(CurrentGold>50){
                Debug.Log("You're rollin in it!");
            }
            else if (CurrentGold<15){
                Debug.Log("Not much there to steal...");
            }
            else{
                Debug.Log("Looks like your purse is in the sweet spot.");
            }
        }
    
    public int GenerateCharacter(string name, int level){
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }

    /// 
    void ComputeAge(){
        Debug.Log(CurrentAge + AddedAge);
        Debug.LogFormat(FirstName);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
