using UnityEngine;

namespace LibSugar.Unity.Syntax
{
    /// <summary>
    /// Quaternion Syntax Ext
    /// </summary>
    public static class QuatSynExt
    {
        #region deconstruct

        /// <summary>Deconstruct<code>var (x, y, z, w) = quat</code></summary>
        public static void Deconstruct(this Quaternion self, out float x, out float y, out float z, out float w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = quat.eulerAngles</code></summary>
        public static void Deconstruct(this Quaternion self, out float x, out float y, out float z)
        {
            var euler = self.eulerAngles;
            x = euler.x;
            y = euler.y;
            z = euler.z;
        }

        #endregion
    }
}
