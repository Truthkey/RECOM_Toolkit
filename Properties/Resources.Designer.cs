﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RECOM_Toolkit.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RECOM_Toolkit.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to RECOM_Toolkit license file, should be with any part of the binary and/or source.
        ///Anyone that do not respect this LICENSE file, and do not give me full credit 
        ///in a way the user needs or is greatly advised to check this file then 
        ///you might have problems. You have been warned.
        ///
        ///Copyright (c) 2015  GovanifY
        ///All rights reserved.
        ///
        ///Redistribution and use in source and binary forms, with or without
        ///modification, are permitted provided that the following conditions
        ///are met:
        ///1. Redistributions of source  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LICENSE {
            get {
                return ResourceManager.GetString("LICENSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This tool is able to extract and modify the iso of the game Kingdom Hearts Re: Chain of Memories
        ///
        ///This tool can launch more than one patch and mix them instead to have to apply them one by one.
        ///Simply drag &apos;n drop all patches you need to apply to the toolkit or, with the 
        ///windows cmd, execute the command(in the directory of RECOM_Toolkit): RECOM_Toolkit patch1.kh2patch patch2.kh2patch
        ///
        ///You can change the name of the iso to modify simply by drag and dropping him to the software or to use the command: &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Readme {
            get {
                return ResourceManager.GetString("Readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] RECOM {
            get {
                object obj = ResourceManager.GetObject("RECOM", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
