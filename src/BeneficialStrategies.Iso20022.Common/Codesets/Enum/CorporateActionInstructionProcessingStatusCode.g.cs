﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionInstructionProcessingStatusCode.  ISO2002 ID# _bKjK4dp-Ed-ak6NoX_4Aeg_-1308410939.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKjK4dp-Ed-ak6NoX_4Aeg_-1308410939")]
[Description(@"Specifies the status of a corporate action instruction.")]
[Derivations(typeof(CorporateActionInstructionProcessingStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionInstructionProcessingStatusCode
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKjK4tp-Ed-ak6NoX_4Aeg_86891368")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as "DFLA".
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_bKjK49p-Ed-ak6NoX_4Aeg_1478052223")]
    [Description(@"Default action is taken.")]
    DefaultAction,
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKjK5Np-Ed-ak6NoX_4Aeg_1586320101")]
    [Description(@"Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.")]
    Accepted,
    
    /// <summary>
    /// Instruction's processing is pending.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bKjK5dp-Ed-ak6NoX_4Aeg_271390723")]
    [Description(@"Instruction's processing is pending.")]
    Pending,
    
    /// <summary>
    /// Instruction has been rejected for further processing due to system reasons.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKjK5tp-Ed-ak6NoX_4Aeg_363574550")]
    [Description(@"Instruction has been rejected for further processing due to system reasons.")]
    Rejected,
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as "STIN".
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_bKsU0Np-Ed-ak6NoX_4Aeg_-721845566")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionInstructionProcessingStatusCodeMetadataExtensions
{
    private static readonly CorporateActionInstructionProcessingStatusCodeDropdownSource _dropdownSource = new CorporateActionInstructionProcessingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionInstructionProcessingStatusCodeDropdownRow GetMetadata(this CorporateActionInstructionProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


