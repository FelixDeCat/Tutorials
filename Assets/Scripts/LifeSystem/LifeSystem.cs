using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeSystem : MonoBehaviour
{
    int life = 0;
    int lifemax = 100;

    public Image fillbar;

    private void Start()
    {
        life = lifemax;
        Refresh();
    }

    public void TakeDamage(int dmg)
    {
        life -= dmg;
        if (life <= 0)
        {
            life = 0;
        }
        else
        {
            //recibio daño
        }
        Refresh();
    }
    public void Heal(int heal)
    {
        life += heal;
        if (life > lifemax) life = lifemax;
        Refresh();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamage(5);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Heal(5);
        }
    }

    void Refresh()
    {
        fillbar.fillAmount = (float)life / lifemax;
    }
}
