﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementErrorAction1Code.  ISO2002 ID# _KUh0ln1DEeCF8NjrBemJWQ_467213474.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action to perform in case of error during the action in progress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUh0ln1DEeCF8NjrBemJWQ_467213474")]
[Description(@"Action to perform in case of error during the action in progress.")]
[DerivedFrom(typeof(TerminalManagementErrorActionCode))]
public enum TerminalManagementErrorAction1Code
{
    /// <summary>
    /// Ignore the error.
    /// Encoded/decoded by serializers as "IGNR".
    /// </summary>
    [EnumMember(Value = "IGNR")]
    [IsoId("_KUh0l31DEeCF8NjrBemJWQ_-1839509664")]
    [Description(@"Ignore the error.")]
    IgnoreError = TerminalManagementErrorActionCode.IgnoreError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send a status report immediately.
    /// Encoded/decoded by serializers as "SDSR".
    /// </summary>
    [EnumMember(Value = "SDSR")]
    [IsoId("_KUh0mH1DEeCF8NjrBemJWQ_-1174724220")]
    [Description(@"Send a status report immediately.")]
    SendStatusReport = TerminalManagementErrorActionCode.SendStatusReport, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementErrorAction1CodeMetadataExtensions
{
    private static readonly TerminalManagementErrorAction1CodeDropdownSource _dropdownSource = new TerminalManagementErrorAction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementErrorAction1CodeDropdownRow GetMetadata(this TerminalManagementErrorAction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


