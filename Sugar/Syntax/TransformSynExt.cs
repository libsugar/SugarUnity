using UnityEngine;

namespace LibSugar.Unity.Syntax
{
    /// <summary>
    /// Transform Syntax Ext
    /// </summary>
    public static class TransformSynExt
    {
        #region deconstruct

        /// <summary>Deconstruct<code>var (position, rotation) = trans</code></summary>
        public static void Deconstruct(this Transform self, out Vector3 position, out Quaternion rotation)
        {
            position = self.position;
            rotation = self.rotation;
        }

        /// <summary>Deconstruct<code>var (localPosition, localRotation, localScale) = trans</code></summary>
        public static void Deconstruct(this Transform self, out Vector3 localPosition, out Quaternion localRotation, out Vector3 localScale)
        {
            localPosition = self.localPosition;
            localRotation = self.localRotation;
            localScale = self.localScale;
        }

        #endregion
    }
}
