﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason6Code.  ISO2002 ID# _a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason6Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as "CANI".
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a1F4Qdp-Ed-ak6NoX_4Aeg_1095310605")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as "CANO".
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a1F4Qtp-Ed-ak6NoX_4Aeg_1161803601")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.")]
    CancelledByOther = CancelledStatusReasonV2Code.CancelledByOther, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as "CANS".
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a1F4Q9p-Ed-ak6NoX_4Aeg_1193205425")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as "CSUB".
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a1F4RNp-Ed-ak6NoX_4Aeg_1225528362")]
    [Description(@"Instruction has been cancelled by the agent due to an event deadline extension.")]
    CancelledByAgent = CancelledStatusReasonV2Code.CancelledByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a1F4Rdp-Ed-ak6NoX_4Aeg_1272087253")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason6CodeMetadataExtensions
{
    private static readonly CancelledStatusReason6CodeDropdownSource _dropdownSource = new CancelledStatusReason6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason6CodeDropdownRow GetMetadata(this CancelledStatusReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


