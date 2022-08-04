using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChanger : MonoBehaviour
{
   
  
  
    public GameObject hair;
    public GameObject body;
    public Animator hair_animator;
    public Animator body_animator;
 
    public int contagem_hair = 1;
    public int contagem_body = 1;
    public int hair_number = 2;
    public int body_number = 5;
    public float timer_hair = 0;
    public float timer_body = 0;
    


    
    private void Start()
    {

        hair_animator =  hair.GetComponent<Animator>();
        body_animator  = body.GetComponent<Animator>();
 
        

    }

    private void Update()
    {
        timer_hair = hair_animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        timer_body = body_animator.GetCurrentAnimatorStateInfo(0).normalizedTime;




    }

    public void ChangeHairMinus()
    {
        contagem_hair--;
        if (contagem_hair <= 0)
        {
            contagem_hair = hair_number;
        }
    }

    public void ChangeHairMore()
    {
        contagem_hair++;
        if(contagem_hair > hair_number)
        {
            contagem_hair = 1;
        }
    }
    public void ChangeHair() 
    {
        
        if (contagem_hair == 2)
        {
            hair_animator.Play("Hair2_Idle", 0, timer_hair);
            string reset_body = contagem_body.ToString();
            body_animator.Play("Idle_" + reset_body, 0, timer_body);

        }
        if (contagem_hair == 1)
        {
            hair_animator.Play("Hair1_Idle", 0, timer_hair);
           
            string reset_body = contagem_body.ToString();
            body_animator.Play("Idle_" + reset_body, 0, timer_body);
        }


    }

    public void ChangeBodyMinus()
    {
        contagem_body--;

        if(contagem_body <= 0)
        {
            contagem_body = 5;
        }
    }

    public void ChangeBodyMore()
    {
        contagem_body++;

        if (contagem_body > 5)
        {
            contagem_body = 1;
        }
    }
    public void ChangeBody()
    {
        if (contagem_body == 1)
        {
            body_animator.Play("Idle_1", 0, timer_body);
            string reset_hair = contagem_hair.ToString();
            hair_animator.Play("Hair" + reset_hair + "_Idle", 0, timer_hair);
            
        }
        if (contagem_body == 2)
        {
            body_animator.Play("Idle_2", 0, timer_body);

            string reset_hair = contagem_hair.ToString();
            hair_animator.Play("Hair" + reset_hair + "_Idle", 0, timer_hair);

        }
        if (contagem_body == 3)
        {
            body_animator.Play("Idle_3", 0, timer_body);
            
            string reset_hair = contagem_hair.ToString();
            hair_animator.Play("Hair" + reset_hair + "_Idle", 0, timer_hair);

        }
        if (contagem_body == 4)
        {
            body_animator.Play("Idle_4", 0, timer_body);
         
            string reset_hair = contagem_hair.ToString();
            hair_animator.Play("Hair" + reset_hair + "_Idle", 0, timer_hair);

        }
        if (contagem_body == 5)
        {
            body_animator.Play("Idle_5", 0, timer_body);
        
            string reset_hair = contagem_hair.ToString();
            hair_animator.Play("Hair" + reset_hair + "_Idle", 0, timer_hair);

        }

    }
}


