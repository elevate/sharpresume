// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Just3Ws.SharpResume")]
[assembly: AssemblyDescription("#ResumeDocument ResumeDocument and CV API")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Just3Ws, Inc.")]
[assembly: AssemblyProduct("Just3Ws.SharpResume.dll")]
[assembly: AssemblyCopyright("© 2009, Just3Ws, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("02bc2f0e-d0c0-4f59-bf1a-d1a4e38d76d5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("0.0.0.0")]
[assembly: AssemblyFileVersion("0.0.0.0")]
[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en-US")]

//ms-help: //MS.VSCC.v80/MS.MSDN.v80/MS.NETDEVFX.v20.en/cpref11/html/T_System_Security_AllowPartiallyTrustedCallersAttribute.htm

[assembly: AllowPartiallyTrustedCallers]

//TODO: Determine correct CAS settings for #Resume library.
////Permission to execute and nothing else.

[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution = true)]
[assembly: PermissionSet(SecurityAction.RequestOptional, Name = "Nothing")]
////We need to be able to write to the file system.
//[assembly : FileIOPermission( SecurityAction.RequestMinimum, Unrestricted = true )]