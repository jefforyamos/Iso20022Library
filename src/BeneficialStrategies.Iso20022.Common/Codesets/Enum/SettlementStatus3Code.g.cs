﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementStatus3Code.  ISO2002 ID# _GbRzsAF1EeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GbRzsAF1EeutW5-TpeYJhA")]
[Description(@"Specifies the status of the settlement of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(SettlementStatusCode))]
public enum SettlementStatus3Code
{
    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as "AcceptedForSettlement".
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_IFf50QF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement,
    
    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as "AwaitingAuthorisation".
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_IKQeAQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation,
    
    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as "AwaitingCreationConfirmation".
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_IOk9UQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation,
    
    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as "AwaitingRescindConfirmation".
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_IScJoQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation,
    
    /// <summary>
    /// Instruction is matched.
    /// Encoded/decoded by serializers as "Matched".
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_IWwo8QF1EeutW5-TpeYJhA")]
    [Description(@"Instruction is matched.")]
    Matched,
    
    /// <summary>
    /// Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.
    /// Encoded/decoded by serializers as "PartiallySettled".
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_IaxmQQF1EeutW5-TpeYJhA")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PartiallySettled,
    
    /// <summary>
    /// Settlement is rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_IfPPgQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is rejected.")]
    Rejected,
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_IjQM0QF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is complete.")]
    Settled,
    
    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as "SettlementTransactionCreated".
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_InRKIQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated,
    
    /// <summary>
    /// Settlement is split.
    /// Encoded/decoded by serializers as "Split".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_IruzYQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is split.")]
    Split,
    
    /// <summary>
    /// Instruction is unmatched.
    /// Encoded/decoded by serializers as "Unmatched".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Ix1bYQF1EeutW5-TpeYJhA")]
    [Description(@"Instruction is unmatched.")]
    Unmatched,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementStatus3CodeMetadataExtensions
{
    private static readonly SettlementStatus3CodeDropdownSource _dropdownSource = new SettlementStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementStatus3CodeDropdownRow GetMetadata(this SettlementStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


