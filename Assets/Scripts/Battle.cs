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

    void AddCharacter(Character character, int hp, int power, int lvl)
    {
        character.hp = hp;
        character.lvl = lvl;
        character.power = power;
        character.isActive = true;
        character.gameObject.SetActive(true);

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



                   if (first != second && first != three)
                   {
                      if(myCharacter1.isActive)
                      {
                          myCharacter1.hp += 100;
                      } 
                      else
                      {
                          AddCharacter(myCharacter1,100,5,1);
                      }

                      ////////////////////////////////
                      if(myCharacter2.isActive)
                      {
                          myCharacter2.hp += 100;
                      } 
                      else
                      {
                          AddCharacter(myCharacter2,100,5,1);
                      }
                      /////////////////////////////////
                      if(myCharacter3.isActive)
                      {
                          myCharacter3.hp += 100;
                      } 
                      else
                      {
                          AddCharacter(myCharacter3,100,5,1);
                      }

                      ///////////
                      ///////////
                      ///////////


                      






                   }
                   else if (first == second && first == three)
                   {
                       
                          AddCharacter(myCharacter1,300,15,3);                      
                   }



                   else if (first != second && first == three)
                   {
                       
                           


                       if(myCharacter1.isActive)
                      {
                          myCharacter1.hp += 200;
                      } 
                      else
                      {
                          AddCharacter(myCharacter1,200,5,2);
                      } 


                      if(myCharacter2.isActive)
                      {
                          
                          myCharacter2.hp += 100;   
                      }    
                      else
                      {
                          AddCharacter(myCharacter2,100,15,1); 
                      }                
                   }
                   else if(second == three && first != second)
                      {
                          if(myCharacter2.isActive)
                      {                          
                        myCharacter2.hp += 200;
                      } 
                      else
                      {
                          AddCharacter(myCharacter2,200,5,2);
                      }


                        if(myCharacter1.isActive)
                      {
                          myCharacter1.hp += 100;
                      } 
                      else
                      {
                          AddCharacter(myCharacter1,100,5,1);
                      }

                      }

                      else if(first == second && second != three)
                      {

                          if(myCharacter1.isActive)
                      {
                          myCharacter1.hp += 200;
                      } 
                      else
                      {
                          AddCharacter(myCharacter1,200,5,2);
                      }


                      if(myCharacter3.isActive)
                      {
                          myCharacter3.hp += 100;
                      } 
                      else
                      {
                          AddCharacter(myCharacter3,100,5,1);
                      }

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
