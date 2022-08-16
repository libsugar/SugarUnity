using System;
using UnityEngine;

namespace LibSugar.Unity
{
    /// <summary>
    /// Transform Ext
    /// </summary>
    public static class TransformExt
    {
        /// <summary>select by <c>f</c> <code>{ position } => { f(position) }</code></summary>
        public static T SelectPosition<T>(this T self, Func<Vector3, Vector3> f) where T : Component
        {
            if (self is Transform t) t.position = f(t.position);
            else self.transform.SelectPosition(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ localPosition } => { f(localPosition) }</code></summary>
        public static T SelectLocalPosition<T>(this T self, Func<Vector3, Vector3> f) where T : Component
        {
            if (self is Transform t) t.localPosition = f(t.localPosition);
            else self.transform.SelectLocalPosition(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ eulerAngles } => { f(eulerAngles) }</code></summary>
        public static T SelectEulerAngles<T>(this T self, Func<Vector3, Vector3> f) where T : Component
        {
            if (self is Transform t) t.eulerAngles = f(t.eulerAngles);
            else self.transform.SelectEulerAngles(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ localEulerAngles } => { f(localEulerAngles) }</code></summary>
        public static T SelectLocalEulerAngles<T>(this T self, Func<Vector3, Vector3> f) where T : Component
        {
            if (self is Transform t) t.localEulerAngles = f(t.localEulerAngles);
            else self.transform.SelectLocalEulerAngles(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ rotation } => { f(rotation) }</code></summary>
        public static T SelectRotation<T>(this T self, Func<Quaternion, Quaternion> f) where T : Component
        {
            if (self is Transform t) t.rotation = f(t.rotation);
            else self.transform.SelectRotation(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ localRotation } => { f(localRotation) }</code></summary>
        public static T SelectLocalRotation<T>(this T self, Func<Quaternion, Quaternion> f) where T : Component
        {
            if (self is Transform t) t.localRotation = f(t.localRotation);
            else self.transform.SelectLocalRotation(f);
            return self;
        }

        /// <summary>select by <c>f</c> <code>{ localScale } => { f(localScale) }</code></summary>
        public static T SelectLocalScale<T>(this T self, Func<Vector3, Vector3> f) where T : Component
        {
            if (self is Transform t) t.localScale = f(t.localScale);
            else self.transform.SelectLocalScale(f);
            return self;
        }
    }
}
