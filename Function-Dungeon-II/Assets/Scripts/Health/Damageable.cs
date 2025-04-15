using UnityEngine;
using UnityEngine.Events;

namespace Health
{
    /// <summary>
    /// Represents an object that can take damage.
    /// </summary>
    public class Damageable : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private float startHealth;
        [SerializeField] private bool enableNegativeHealth;
        
        [Header("Events")]
        [SerializeField] private UnityEvent onDeathEvent = new();
        [SerializeField] private UnityEvent onDamageEvent = new();
        
        private float _currentHealth;
        
        private void Awake()
        {
            _currentHealth = startHealth;
        }
        
        /// <summary>
        /// The health of the object.
        /// </summary>
        public float Health
        {
            get => _currentHealth;
            set
            {
                if (!enabled)
                    return;
                
                if (!enableNegativeHealth && value <= 0)
                {
                    onDeathEvent.Invoke();
                    
                    _currentHealth = 0;
                }
                else
                {
                    onDamageEvent.Invoke();
                    
                    _currentHealth = value;
                }
            }
        }

        public void DamageObject(float damage)
        {
            Health -= damage;
        }
        
        /// <summary>
        /// Whether negative health is enabled.
        /// </summary>
        public bool NegativeHealthEnabled => enableNegativeHealth;
        
        /// <summary>
        /// Adds a listener to the onDamageEvent.
        /// </summary>
        /// <param name="action"> The function to add </param>
        public void SubscribeToDamageEvent(UnityAction action)
        {
            onDamageEvent.AddListener(action);
        }
        
        /// <summary>
        /// Adds a listener to the onDeathEvent.
        /// </summary>
        /// <param name="action"> The function to add </param>
        public void SubscribeToDeathEvent(UnityAction action)
        {
            onDeathEvent.AddListener(action);
        }
        
        /// <summary>
        /// Removes a listener from the onDamageEvent.
        /// </summary>
        /// <param name="action"> The function to remove </param>
        public void UnsubscribeFromDamageEvent(UnityAction action)
        {
            onDamageEvent.RemoveListener(action);
        }
        
        /// <summary>
        /// Removes a listener from the onDeathEvent.
        /// </summary>
        /// <param name="action"> The function to remove </param>
        public void UnsubscribeFromDeathEvent(UnityAction action)
        {
            onDeathEvent.RemoveListener(action);
        }
    }
}