using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField]
    private float hp;
    [SerializeField]
    private UIManager ui_manager;
    private Renderer renderer;
    private Color origin_color;
    private float max_hp;

    private void Start()
    {
        max_hp = hp;
        renderer = GetComponent<Renderer>();
        origin_color = renderer.material.color;
    }
    public void Damage(int damage)
    {
        LoseHp(damage);
        StartCoroutine(EffectDamaged());
        CheckDeath();
    }

    void LoseHp(int damage)
    {
        hp -= damage;
        ui_manager.UpdateHp(hp / max_hp);
    }

    private void CheckDeath()
    {
        if (hp > 0) return;

        Debug.Log("Death");
    }

    IEnumerator EffectDamaged()
    {
        for (int i = 0; i < 2; i++)
        {
            renderer.material.color = Color.white;
            yield return new WaitForSeconds(0.05f);
            renderer.material.color = origin_color;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
