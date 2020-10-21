// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

#pragma warning disable CS0618 // Type or member is obsolete
[assembly:FileIOPermission(SecurityAction.RequestMinimum)]
#pragma warning restore CS0618 // Type or member is obsolete

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions")]