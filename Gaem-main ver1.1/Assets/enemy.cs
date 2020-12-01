using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public int maxhp = 100;
    int currenthp;




    // Start is called before the first frame update
    void Start()
    {    //fienden får max hp när du kör programmet max hp bestämmer man själv i detta fall är det en public int som gör att du kan ändra den när du vill i unity
        currenthp = maxhp;


    }

  public void takedmg(int dmg)
    {

        //skada sker när man tar bort hp från din totala hp hur mycket man tar bort deffineras i int dmg vilket ska va publick så man snabbt kan ändra när man vill i untiy

        currenthp -= dmg;


        //här ska vi lägga in en ta skada animation

        if (currenthp <= 0)
        {
            //om ditt liv är slut kallar vi på funktion "Die" 
            Die();

        }

        
    }

    public void Die()
    {

        //Debug.Log("he a dead nigga   +2exp");

        //dödsanimation

    }


}





















