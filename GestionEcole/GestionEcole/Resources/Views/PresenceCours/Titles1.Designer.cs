﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEcole.Resources.Views.PresenceCours {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Titles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Titles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GestionEcole.Resources.Views.PresenceCours.Titles", typeof(Titles).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have already been assigned to this class, choose another one.
        /// </summary>
        public static string ErrorMessageCoursInvalid {
            get {
                return ResourceManager.GetString("ErrorMessageCoursInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Course Schedule.
        /// </summary>
        public static string PartialLabel {
            get {
                return ResourceManager.GetString("PartialLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Presence  .
        /// </summary>
        public static string PresenceCours {
            get {
                return ResourceManager.GetString("PresenceCours", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Student.
        /// </summary>
        public static string Student {
            get {
                return ResourceManager.GetString("Student", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attendence to Class.
        /// </summary>
        public static string TitleEdit {
            get {
                return ResourceManager.GetString("TitleEdit", resourceCulture);
            }
        }
    }
}
