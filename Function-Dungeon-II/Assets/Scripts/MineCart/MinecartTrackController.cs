using System.Collections.Generic;
using System.Linq;
using Events;
using Events.GameEvents;
using Events.GameEvents.Typed;
using MaterialSystem;
using ObjectMovement;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

namespace MineCart
{
    public class MineCartRailController : MonoBehaviour
    {
        [Header("Settings")] [SerializeField] private float trackPlacementCompletionX;
        [SerializeField] private float minimalTrackPlacementDistance = 1f;
        
        [Header("Events")] [SerializeField] private MineCartTrackGameEvent onTrackPlaced;
        [SerializeField] private GameEvent onTrackConfirmPlacement;
        [SerializeField] private FloatEvent changeSlope = new();
        [SerializeField] private FloatEvent changeHeight = new();
        [SerializeField] private UnityEvent trackCompleted = new();
        
        [Header("References")] [SerializeField]
        private MineCartTrack firstTrack;
        
        [SerializeField] private MineCartTrack lastTrack;
        
        private List<MineCartTrack> _minecartTracks = new List<MineCartTrack>();
        private Dictionary<Vector2, int> _connectionPoints = new Dictionary<Vector2, int>();
        private MineCartTrack _currentTrack;
        
        private void Start()
        {
            InitializeFirstTrack();
        }
        
        private void InitializeFirstTrack()
        {
            firstTrack.UpdateConnectionPoints();
            _connectionPoints.Add(firstTrack.RightConnectionPoint, 1);
            _connectionPoints.Add(firstTrack.LeftConnectionPoint, 2);
            
            lastTrack.UpdateConnectionPoints();
            _connectionPoints.Add(lastTrack.LeftConnectionPoint, 1);
            _connectionPoints.Add(lastTrack.RightConnectionPoint, 2);
        }
        
        private void OnEnable()
        {
            onTrackPlaced.AddListener(ChangeCurrentTrack);
            onTrackConfirmPlacement.AddListener(ConfirmTrackPlacement);
        }
        
        private void OnDisable()
        {
            onTrackPlaced.RemoveListener(ChangeCurrentTrack);
            onTrackConfirmPlacement.RemoveListener(ConfirmTrackPlacement);
        }
        
        private void ChangeCurrentTrack(MineCartTrack track)
        {
            RemoveCurrentTrack();
            _currentTrack = track;
            SubscribeToTrackEvents();
            _minecartTracks.Add(_currentTrack);
        }
        
        private void SubscribeToTrackEvents()
        {
            changeHeight.AddListener(_currentTrack.GetComponent<LerpedVector2Translation>().MoveYByInput);
            changeSlope.AddListener(_currentTrack.GetComponent<ObjectSlopeAngleController>().Rotate);
        }
        
        private void UnsubscribeFromTrackEvents()
        {
            changeSlope.RemoveAllListeners();
            changeHeight.RemoveAllListeners();
        }
        
        private void ConfirmTrackPlacement()
        {
            if (_currentTrack == null)
                return;
            
            _currentTrack.UpdateConnectionPoints();
            
            if (!IsTrackConnectingProperly())
            {
                DestroyCurrentTrack();
                return;
            }
            
            AddTrackToConnectionPoints();
            
            if (AreAllTracksConnected())
            {
                OnTrackCompleted();
            }
            
            RemoveCurrentTrack();
        }
        
        private bool IsTrackConnectingProperly()
        {
            var leftSide = _currentTrack.LeftConnectionPoint;
            var rightSide = _currentTrack.RightConnectionPoint;

            // Check if one of points exists
            var left = _connectionPoints.ContainsKey(leftSide);
            var right = _connectionPoints.ContainsKey(rightSide);
            
            if (!left && !right)
                return false;
            
            // Check if any of the connection points exist more than once
            if (left && _connectionPoints[leftSide] > 1)
                return false;
            
            if (right && _connectionPoints[rightSide] > 1)
                return false;
            
            return true;
        }
        
        private void AddTrackToConnectionPoints()
        {
            UpdateConnectionPoint(_currentTrack.LeftConnectionPoint);
            
            if (_currentTrack.gameObject.transform.position.x < trackPlacementCompletionX)
            {
                UpdateConnectionPoint(_currentTrack.RightConnectionPoint);
            }
        }
        
        private void UpdateConnectionPoint(Vector2 point)
        {
            if (!_connectionPoints.TryAdd(point, 1))
                _connectionPoints[point]++;
        }
        
        private bool AreAllTracksConnected()
        {
            // All connection points should be used exactly twice (once for each track connecting at that point)
            return _connectionPoints.Values.All(point => point == 2);
        }
        
        public void OnTrackCompleted()
        {
            Debug.Log("All tracks connected");
            
            trackCompleted.Invoke();
        }
        
        private void RemoveCurrentTrack()
        {
            if (_currentTrack == null)
                return;
            
            UnsubscribeFromTrackEvents();
            _currentTrack = null;
        }
        
        private void DestroyCurrentTrack()
        {
            if (_currentTrack == null)
                return;
            
            _connectionPoints.Remove(_currentTrack.LeftConnectionPoint);
            
            
            Destroy(_currentTrack.gameObject);
            _currentTrack = null;
        }
        
        /// <summary>
        /// Gets called whenever the slope changes of the track
        /// </summary>
        /// <param name="angle">The angle of the change</param>
        public void OnChangeSlope(float angle)
        {
            changeSlope.Invoke(angle);
        }
        
        /// <summary>
        /// Gets called whenever the height changes of the track
        /// </summary>
        /// <param name="height">The height of the change</param>
        public void OnChangeHeight(float height)
        {
            changeHeight.Invoke(height);
        }
        
        //draw gizmos to show the connection points
        private void OnDrawGizmos()
        {
            foreach (var connectionPoint in _connectionPoints)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawSphere(connectionPoint.Key, 0.1f);
            }
            
            if (_currentTrack != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawSphere(_currentTrack.LeftConnectionPoint, 0.1f);
                Gizmos.DrawSphere(_currentTrack.RightConnectionPoint, 0.1f);
            }
        }
    }
}
