using Attributes;
using Towers.Configuration.Events;
using UnityEngine;

namespace Towers.Configuration.UI
{
    /// <summary>
    /// A UI controller for configuring a tower.
    /// </summary>
    public class TowerConfiguratorUIController : MonoBehaviour
    {
        [SerializeField] private TowerConfigurationGameEvent onConfigureTower;

        [Header("Shooting UI")]
        [SerializeField, Expandable] private TowerVariables shootingType;
        [SerializeField] private ShootingConfiguratorUIController shootingUI;

        [Header("Bombing UI")] 
        [SerializeField, Expandable] private TowerVariables bombingType;
        [SerializeField] private BombingConfiguratorUIController bombingUI;

        private void OnEnable()
        {
            onConfigureTower?.AddListener(ActivateConfiguratorUI);
        }

        private void OnDisable()
        {
            onConfigureTower?.RemoveListener(ActivateConfiguratorUI);
        }

        private void ActivateConfiguratorUI(TowerConfigurator towerConfigurator)
        {
            if (towerConfigurator.TowerVariables == shootingType)
            {
                shootingUI.ActiveTower = towerConfigurator;
                shootingUI.gameObject.SetActive(true);
            }
            else if (towerConfigurator.TowerVariables == bombingType)
            {
                bombingUI.ActiveTower = towerConfigurator;
                bombingUI.gameObject.SetActive(true);
            }
        }
    }
}