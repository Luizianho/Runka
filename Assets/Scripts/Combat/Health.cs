using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
       [SerializeField] float HP = 100f;

       bool isDead = false;
       public bool IsDead()
       {
           return isDead;
       }

       public void TakeDamage(float damage)
       {
           HP = Mathf.Max(HP - damage, 0);
           if (HP == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}