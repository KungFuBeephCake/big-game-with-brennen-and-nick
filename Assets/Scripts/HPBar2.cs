    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar2 : MonoBehaviour
{
    private float healthP2;
    private float lerpTimer;
    public float maxhealthP2 = 100;
    public float loseHPp2 = -2f;
    public Image frontHealthBar2;
    public Image backHealthBar2;

    // Start is called before the first frame update
    void Start()
    {
        healthP2 = maxhealthP2;
    }

    // Update is called once per frame
    void Update()
    {
        healthP2 = Mathf.Clamp(healthP2, 0, maxhealthP2);
        UpdateHealthUIP2();
        if(Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.B))
        {
            TakeDamageP2(Random.Range(-5, -10));
        }

    }
    public void UpdateHealthUIP2()
    {
        Debug.Log(healthP2);
        float fillF2 = (frontHealthBar2.fillAmount);
        float fillB2 = (backHealthBar2.fillAmount);
        float hFraction2 = (healthP2 / maxhealthP2);
        if(fillB2 > hFraction2)
        {
            frontHealthBar2.fillAmount = hFraction2;
            backHealthBar2.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete2 = lerpTimer / loseHPp2;
            percentComplete2 = percentComplete2 * percentComplete2;
            backHealthBar2.fillAmount = Mathf.Lerp(fillB2, hFraction2, percentComplete2);
        }
    }
    public void TakeDamageP2(float damage2)
    {
        healthP2 -= damage2;
        lerpTimer = 0f;

    }
}

