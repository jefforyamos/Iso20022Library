﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionInstructionProcessingStatus1Code.  ISO2002 ID# _bKZZ5Np-Ed-ak6NoX_4Aeg_-572672162.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKZZ5Np-Ed-ak6NoX_4Aeg_-572672162")]
[Description(@"Specifies the status of a corporate action instruction.")]
[DerivedFrom(typeof(CorporateActionInstructionProcessingStatusCode))]
public enum CorporateActionInstructionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKZZ5dp-Ed-ak6NoX_4Aeg_-1187289407")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = CorporateActionInstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as "DFLA".
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_bKZZ5tp-Ed-ak6NoX_4Aeg_-426524254")]
    [Description(@"Default action is taken.")]
    DefaultAction = CorporateActionInstructionProcessingStatusCode.DefaultAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKZZ59p-Ed-ak6NoX_4Aeg_27563015")]
    [Description(@"Instruction has been acknowledged/accepted for further processing. In other words, this means that the instruction has been received, is processable and has been validated for further processing.")]
    Accepted = CorporateActionInstructionProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction's processing is pending.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bKZZ6Np-Ed-ak6NoX_4Aeg_1494711778")]
    [Description(@"Instruction's processing is pending.")]
    Pending = CorporateActionInstructionProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been rejected for further processing due to system reasons.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKZZ6dp-Ed-ak6NoX_4Aeg_1858486184")]
    [Description(@"Instruction has been rejected for further processing due to system reasons.")]
    Rejected = CorporateActionInstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as "STIN".
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_bKjK4Np-Ed-ak6NoX_4Aeg_-1982393843")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = CorporateActionInstructionProcessingStatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionInstructionProcessingStatus1CodeMetadataExtensions
{
    private static readonly CorporateActionInstructionProcessingStatus1CodeDropdownSource _dropdownSource = new CorporateActionInstructionProcessingStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionInstructionProcessingStatus1CodeDropdownRow GetMetadata(this CorporateActionInstructionProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


