﻿using static UnityEditor.Tools;
using UnityEngine;

namespace Game.InputLogic
{
    internal abstract class BaseInputView : MonoBehaviour
    {
        public void Init(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, float speed)
        {
            _leftMove = leftMove;
            _rightMove = rightMove;
            _speed = speed;
        }


        protected float _speed;
        private SubscriptionProperty<float> _leftMove;
        private SubscriptionProperty<float> _rightMove;

        protected virtual void OnLeftMove(float value)
        {
            _leftMove.Value = value;
        }

        protected virtual void OnRightMove(float value)
        {
            _rightMove.Value = value;
        }
    }
}
