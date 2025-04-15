using UI.GraphDrawer;
using UnityEngine;
using UnityEngine.Events;

namespace Towers.Configuration.UI
{
    /// <summary>
    /// A UI controller for configuring a tower.
    /// </summary>
    public abstract class TypedTowerUIController : MonoBehaviour
    {
        [Header("Grid")]
        [SerializeField] protected FunctionGraphDrawerController gridDrawer;
        [SerializeField] protected Transform gridOrigin;
        
        [Header("Events")]
        [SerializeField] protected UnityEvent onTowerConfigured = new();
        
        private TowerConfigurator _activeTower;

        /// <summary>
        /// The active tower being configured.
        /// </summary>
        internal TowerConfigurator ActiveTower
        {
            get => _activeTower;
            set
            {
                _activeTower = value;
                
                gridOrigin.position = _activeTower.transform.position;
                gridDrawer.gameObject.SetActive(true);
            }
        }
        
        public abstract void OnConfirmButtonClicked();
    }
}