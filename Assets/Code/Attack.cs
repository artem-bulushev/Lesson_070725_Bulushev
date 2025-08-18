using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnValidate()
    {
        ResultDamage();
    }

    public string BaseDamage;
    public string Multiplier;
    public string Damage;

    private void ResultDamage()
    {
        double doubleBaseDamage = double.Parse(BaseDamage);
        double doubleMultiplier = double.Parse(Multiplier);
        Damage = (doubleBaseDamage * doubleMultiplier).ToString();
        Debug.LogWarning(message: $"Player {Damage:##.##} damage");
    }
}
