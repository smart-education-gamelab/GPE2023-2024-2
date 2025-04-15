using LineControllers;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crafter
{
    /// <summary>
    /// This class is responsible for displaying the formula of a line.
    /// </summary>
    public class LineFormulaDisplay : MonoBehaviour
    {
        private const string FormulaText = "Y = {0}x + {1}";
        private const float ZPosition = -0.5f;
        
        [SerializeField] private LineRenderer lineToFollow;
        [SerializeField] private LinearGraphLine linearGraphLine;
        [SerializeField] private int indexOfPointToFollow = 2;
        
        private Transform _line;
        private TextMeshPro _formulaText;
        private float _a;
        private float _b;
        private float _yPositionOffset;
        
        private void Awake()
        {
            _formulaText = GetComponent<TextMeshPro>();
        }
        
        private void Start()
        {
            _line = lineToFollow.transform;
            _a = linearGraphLine.A;
            _b = _line.position.y;
            
            UpdateFormulaDisplay();
        }
        
        public void UpdateFormulaDisplay()
        {
            _formulaText.text = string.Format(FormulaText, _a, _b);
            _yPositionOffset = transform.parent.position.y;
            
            transform.position = new Vector3
            {
                x = lineToFollow.GetPosition(indexOfPointToFollow).x,
                y = lineToFollow.GetPosition(indexOfPointToFollow).y + _yPositionOffset,
                z = ZPosition
            };
        }
    }
}