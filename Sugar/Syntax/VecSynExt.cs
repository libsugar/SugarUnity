using System;
using UnityEngine;

namespace LibSugar.Unity.Syntax
{
    /// <summary>
    /// Vector Syntax Ext
    /// </summary>
    public static class VecSynExt
    {
        #region deconstruct

        /// <summary>Deconstruct<code>var (x, y) = vec2</code></summary>
        public static void Deconstruct(this Vector2 self, out float x, out float y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = vec3</code></summary>
        public static void Deconstruct(this Vector3 self, out float x, out float y, out float z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = vec4</code></summary>
        public static void Deconstruct(this Vector4 self, out float x, out float y, out float z, out float w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = vec2</code></summary>
        public static void Deconstruct(this Vector2Int self, out int x, out int y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = vec3</code></summary>
        public static void Deconstruct(this Vector3Int self, out int x, out int y, out int z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        #endregion
    }
}
