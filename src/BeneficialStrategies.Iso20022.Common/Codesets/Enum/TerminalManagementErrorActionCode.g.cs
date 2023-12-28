﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementErrorActionCode.  ISO2002 ID# _KUq-gH1DEeCF8NjrBemJWQ_-187828262.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action to perform in case of error during the action in progress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-gH1DEeCF8NjrBemJWQ_-187828262")]
[Description(@"Action to perform in case of error during the action in progress.")]
public enum TerminalManagementErrorActionCode
{
    /// <summary>
    /// Ignore the error.
    /// Encoded/decoded by serializers as "IGNR".
    /// </summary>
    [EnumMember(Value = "IGNR")]
    [IsoId("_KUq-gX1DEeCF8NjrBemJWQ_-2103855543")]
    [Description(@"Ignore the error.")]
    IgnoreError,
    
    /// <summary>
    /// Send a status report immediately.
    /// Encoded/decoded by serializers as "SDSR".
    /// </summary>
    [EnumMember(Value = "SDSR")]
    [IsoId("_KUq-gn1DEeCF8NjrBemJWQ_-1811897805")]
    [Description(@"Send a status report immediately.")]
    SendStatusReport,
    
    /// <summary>
    /// Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report.
    /// Encoded/decoded by serializers as "STOP".
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_sO83IL4pEeKkGaJ0UrThyA_-2021748576")]
    [Description(@"Stop the current sequence of terminal management actions without any action, and do not notice the error with a status report.")]
    StopSequence,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementErrorActionCodeMetadataExtensions
{
    private static readonly TerminalManagementErrorActionCodeDropdownSource _dropdownSource = new TerminalManagementErrorActionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementErrorActionCodeDropdownRow GetMetadata(this TerminalManagementErrorActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


