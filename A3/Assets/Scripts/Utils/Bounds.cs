﻿using System;
using UnityEngine;

namespace PlanetaryEscape.Utils
{
    /// <summary>
    /// 2D rectangular boundaries limiter
    /// </summary>
    [Serializable]
    public struct Bounds
    {
        #region Fields
        //Inspector fields
        [SerializeField, Header("X axis bounds")]
        private float xMin;
        [SerializeField]
        private float xMax;
        [SerializeField, Header("Y axis bounds")]
        private float yMin;
        [SerializeField]
        private float yMax;
        #endregion

        #region Methods
        /// <summary>
        /// Clamps the given Vector3 inside this bounds object
        /// </summary>
        /// <param name="v">Vector3 to clamp</param>
        /// <returns>Clamped vector</returns>
        public Vector3 BoundVector(Vector3 v) => new Vector3(Mathf.Clamp(v.x, this.xMin, this.xMax), Mathf.Clamp(v.y, this.yMin, this.yMax));
        #endregion
    }
}
