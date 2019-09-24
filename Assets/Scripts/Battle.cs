using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [Header("Player's Characters")]
    public Character playerDrone;
    public Character playerHuman;
    public Character playerAnimal;
    public Character playerSecondDrone;
    public Character playerSecondAnimal;

    [Header("Enemy's Characters")]
    public Character enemyDrone;
    public Character enemyHuman;
    public Character enemyAnimal;
    public Character enemySecondDrone;
    public Character enemySecondAnimal;
    
    void Start()
    {
        List<Character> players = new List<Character>();
        players.Add(playerDrone);
        players.Add(playerHuman);
        players.Add(playerAnimal);
        players.Add(playerSecondDrone);
        players.Add(playerSecondAnimal);

        List<Character> enemys = new List<Character>();
        players.Add(enemyDrone);
        players.Add(enemyHuman);
        players.Add(enemyAnimal);
        players.Add(enemySecondDrone);
        players.Add(enemySecondAnimal);
        
    }

    void AddCharacter(Character character)
    {
        if (character == playerHuman)
        {
        character.hp = 200;
        character.power = 15;
        }
        else
        {
          character.hp = 100;  
          character.power = 10;
        }
        
        character.lvl = 1;        
        character.isActive = true;
        character.gameObject.SetActive(true);

    }

    void AddHp(Character character)
    {
        character.hp += 100;
        

        if (character == playerHuman)
        {
            if(character.hp > 400) character.hp = 400;

             if(character.hp > 200 && character.hp < 300)
             {
                 character.lvl = 2;
                 character.power = 25;
             } else if (character.hp < 200 )
             {
                 character.lvl = 1;
                 character.power = 20;
             }else if (character.hp > 300 && character.hp < 400 )
             {
                 character.lvl = 3;
                 character.power = 30;
             }
        } 
        else
        {
            if(character.hp > 300) character.hp = 300;

             if(character.hp > 100 && character.hp < 200)
             {
                 character.lvl = 2;
                 character.power = 15;
             } else if (character.hp < 100 )
             {
                 character.lvl = 1;
                 character.power = 10;
             }else if (character.hp > 200 && character.hp < 300 )
             {
                 character.lvl = 3;
                 character.power = 20;
             }
        }
    }

    public void GetTurn(int typeTurn, int first, int second, int three)
    {
        // typeTurn
        // 0 - characters
        // 1 - defend
        // 2 - attack

        switch (typeTurn)
        {
            case 0:
            //characters
            // 0 - drone
            // 1 - human
            // 2 - animal

            Character myCharacter1 = new Character();

            switch (first)
            {
                case 0:
                myCharacter1 = playerDrone;
                break;

                case 1:
                myCharacter1 = playerHuman;
                break;

                case 2:
                myCharacter1 = playerAnimal;
                break;
            }

            Character myCharacter2 = new Character();

            switch (second)
            {
                case 0:
                myCharacter2 = playerDrone;
                break;

                case 1:
                myCharacter2 = playerHuman;
                break;

                case 2:
                myCharacter2 = playerAnimal;
                break;
            }

             Character myCharacter3 = new Character();

            switch (three)
            {
                case 0:
                myCharacter3 = playerDrone;
                break;

                case 1:
                myCharacter3 = playerHuman;
                break;

                case 2:
                myCharacter3 = playerAnimal;
                break;
            }



                  if(!myCharacter1.isActive)
                  {
                      AddCharacter(myCharacter1);
                  } 
                  else
                  {
                      AddHp(myCharacter1);                      
                  }

                  if(!myCharacter2.isActive)
                  {
                      AddCharacter(myCharacter2);
                  } 
                  else
                  {
                      AddHp(myCharacter2);                      
                  }

                  if(!myCharacter3.isActive)
                  {
                      AddCharacter(myCharacter3);
                  } 
                  else
                  {
                      AddHp(myCharacter3);                      
                  }
                



            break;

            case 1:
            //
            break;

            case 2:
            //
            break;

            default:
            //
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
