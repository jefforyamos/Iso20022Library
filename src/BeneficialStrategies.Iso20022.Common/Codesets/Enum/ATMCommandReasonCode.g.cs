﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCommandReasonCode.  ISO2002 ID# _s2j4EItGEeSxlKlAGYErFg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for sending or requesting a maintenance command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s2j4EItGEeSxlKlAGYErFg")]
[Description(@"Reason for sending or requesting a maintenance command.")]
public enum ATMCommandReasonCode
{
    /// <summary>
    /// Request the status of or action from the ATM to perform a diagnostic.
    /// Encoded/decoded by serializers as "DIAG".
    /// </summary>
    [EnumMember(Value = "DIAG")]
    [IsoId("_vsp7cItGEeSxlKlAGYErFg")]
    [Description(@"Request the status of or action from the ATM to perform a diagnostic.")]
    Diagnostic,
    
    /// <summary>
    /// Supervise the ATM.
    /// Encoded/decoded by serializers as "MONI".
    /// </summary>
    [EnumMember(Value = "MONI")]
    [IsoId("_yRyxsItGEeSxlKlAGYErFg")]
    [Description(@"Supervise the ATM.")]
    Monitoring,
    
    /// <summary>
    /// Security error.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_02Aa4ItGEeSxlKlAGYErFg")]
    [Description(@"Security error.")]
    SecurityError,
    
    /// <summary>
    /// Desynchronisation of dialogue between entities.
    /// Encoded/decoded by serializers as "SYNC".
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_3S6iMItGEeSxlKlAGYErFg")]
    [Description(@"Desynchronisation of dialogue between entities.")]
    Synchronisation,
    
    /// <summary>
    /// Update the ATM.
    /// Encoded/decoded by serializers as "UPDT".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_5ZxhAItGEeSxlKlAGYErFg")]
    [Description(@"Update the ATM.")]
    Update,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMCommandReasonCodeMetadataExtensions
{
    private static readonly ATMCommandReasonCodeDropdownSource _dropdownSource = new ATMCommandReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMCommandReasonCodeDropdownRow GetMetadata(this ATMCommandReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

