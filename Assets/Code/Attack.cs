using UnityEngine;


namespace Code
{
    public class Attack : MonoBehaviour
    {
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
}
    
