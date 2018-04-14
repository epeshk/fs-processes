﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fs.Processes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fs.Processes.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Only one of Arguments or ArgumentList may be used..
        /// </summary>
        internal static string ArgumentsAndArgumentsListInitialized {
            get {
                return ResourceManager.GetString("ArgumentsAndArgumentsListInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has not been redirected..
        /// </summary>
        internal static string CantGetStandardStream {
            get {
                return ResourceManager.GetString("CantGetStandardStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot mix synchronous and asynchronous operation on process stream..
        /// </summary>
        internal static string CantMixSyncAsyncOperation {
            get {
                return ResourceManager.GetString("CantMixSyncAsyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateProcessInfo.Password and CreateProcessInfo.PasswordInClearText cannot both be set. Use only one of them..
        /// </summary>
        internal static string CantSetDuplicatePassword {
            get {
                return ResourceManager.GetString("CantSetDuplicatePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateProcessInfo.Attributes and CreateProcessInfo.UserName are mutually exclusive..
        /// </summary>
        internal static string CanUseAttributesWithCreateProcessLogon {
            get {
                return ResourceManager.GetString("CanUseAttributesWithCreateProcessLogon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied key is already in use. This probably indicates a race condition with a reused handle..
        /// </summary>
        internal static string DuplicateCompletionKey {
            get {
                return ResourceManager.GetString("DuplicateCompletionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot start process because a file name has not been provided..
        /// </summary>
        internal static string FileNameMissing {
            get {
                return ResourceManager.GetString("FileNameMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HotKey property cannot be used when standard input, error or output is redirected..
        /// </summary>
        internal static string HotKeyWithRedirection {
            get {
                return ResourceManager.GetString("HotKeyWithRedirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object instance is read only..
        /// </summary>
        internal static string InstanceIsReadOnly {
            get {
                return ResourceManager.GetString("InstanceIsReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Title cannot be null, empty or consist only of whitespace when used as an AppID..
        /// </summary>
        internal static string InvalidAppIdTitle {
            get {
                return ResourceManager.GetString("InvalidAppIdTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified executable is not a valid application for this OS platform..
        /// </summary>
        internal static string InvalidApplication {
            get {
                return ResourceManager.GetString("InvalidApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Title cannot be null, empty or consist only of whitespace when used as a LinkName..
        /// </summary>
        internal static string InvalidLinkNameTitle {
            get {
                return ResourceManager.GetString("InvalidLinkNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An async read operation has already been started on the stream..
        /// </summary>
        internal static string PendingAsyncOperation {
            get {
                return ResourceManager.GetString("PendingAsyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PreventPinning cannot be used unless TitleIs is also set to TitleIs.AppID..
        /// </summary>
        internal static string PreventPinningOnlyWithAppIdTitle {
            get {
                return ResourceManager.GetString("PreventPinningOnlyWithAppIdTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process handle is closed or invalid..
        /// </summary>
        internal static string ProcessHandleClosedOrInvalid {
            get {
                return ResourceManager.GetString("ProcessHandleClosedOrInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The combination of options is not valid..
        /// </summary>
        internal static string ProcessOptionsInvalid {
            get {
                return ResourceManager.GetString("ProcessOptionsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardErrorEncoding is only supported when standard error is redirected..
        /// </summary>
        internal static string StandardErrorEncodingNotAllowed {
            get {
                return ResourceManager.GetString("StandardErrorEncodingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardInputEncoding is only supported when standard input is redirected..
        /// </summary>
        internal static string StandardInputEncodingNotAllowed {
            get {
                return ResourceManager.GetString("StandardInputEncodingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardOutputEncoding is only supported when standard output is redirected..
        /// </summary>
        internal static string StandardOutputEncodingNotAllowed {
            get {
                return ResourceManager.GetString("StandardOutputEncodingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process must exit before requested information can be determined..
        /// </summary>
        internal static string WaitTillExit {
            get {
                return ResourceManager.GetString("WaitTillExit", resourceCulture);
            }
        }
    }
}
