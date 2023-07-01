﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetStudioGUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AssetStudioGUI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon _as {
            get {
                object obj = ResourceManager.GetObject("_as", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 140
        ///
        ///in vec3 normal;
        ///
        ///out vec4 outputColor;
        ///
        ///void main()
        ///{
        ///	vec3 unitNormal = normalize(normal);
        ///	float nDotProduct = clamp(dot(unitNormal, vec3(0.707, 0, 0.707)), 0, 1);
        ///	vec2 ContributionWeightsSqrt = vec2(0.5, 0.5f) + vec2(0.5f, -0.5f) * unitNormal.y;
        ///	vec2 ContributionWeights = ContributionWeightsSqrt * ContributionWeightsSqrt;
        ///
        ///	vec3 color = nDotProduct * vec3(1, 0.957, 0.839) / 3.14159;
        ///	color += vec3(0.779, 0.716, 0.453) * ContributionWeights.y;
        ///	color += vec3(0.368, 0.477, 0. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string fs {
            get {
                return ResourceManager.GetString("fs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 140
        ///
        ///out vec4 outputColor;
        ///
        ///void main()
        ///{
        ///	outputColor = vec4(0, 0, 0, 1);
        ///}.
        /// </summary>
        internal static string fsBlack {
            get {
                return ResourceManager.GetString("fsBlack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 140
        ///
        ///out vec4 outputColor;
        ///in vec4 color;
        ///
        ///void main()
        ///{
        ///	outputColor = color;
        ///}.
        /// </summary>
        internal static string fsColor {
            get {
                return ResourceManager.GetString("fsColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap preview {
            get {
                object obj = ResourceManager.GetObject("preview", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 140
        ///
        ///in vec3 vertexPosition;
        ///in vec3 normalDirection;
        ///in vec4 vertexColor;
        ///uniform mat4 modelMatrix;
        ///uniform mat4 viewMatrix;
        ///uniform mat4 projMatrix;
        ///
        ///out vec3 normal;
        ///out vec4 color;
        ///
        ///void main()
        ///{
        ///	gl_Position = projMatrix * viewMatrix * modelMatrix * vec4(vertexPosition, 1.0);
        ///	normal = normalDirection;
        ///	color = vertexColor; 
        ///}.
        /// </summary>
        internal static string vs {
            get {
                return ResourceManager.GetString("vs", resourceCulture);
            }
        }
    }
}
