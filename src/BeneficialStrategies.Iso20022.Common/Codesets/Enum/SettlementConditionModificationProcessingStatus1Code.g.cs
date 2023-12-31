﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementConditionModificationProcessingStatus1Code.  ISO2002 ID# _ZK188Np-Ed-ak6NoX_4Aeg_-1146323229.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK188Np-Ed-ak6NoX_4Aeg_-1146323229")]
[Description(@"Specifies the status of a securities settlement condition modification request.")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum SettlementConditionModificationProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZK188dp-Ed-ak6NoX_4Aeg_-1146323136")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZK188tp-Ed-ak6NoX_4Aeg_-1146323114")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementConditionModificationProcessingStatus1CodeMetadataExtensions
{
    private static readonly SettlementConditionModificationProcessingStatus1CodeDropdownSource _dropdownSource = new SettlementConditionModificationProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementConditionModificationProcessingStatus1CodeDropdownRow GetMetadata(this SettlementConditionModificationProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


