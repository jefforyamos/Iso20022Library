﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementStatus1Code.  ISO2002 ID# _ZMVKttp-Ed-ak6NoX_4Aeg_-1382213179.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMVKttp-Ed-ak6NoX_4Aeg_-1382213179")]
[Description(@"Specifies the status of the settlement of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(SettlementStatusCode))]
public enum SettlementStatus1Code
{
    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as "AwaitingAuthorisation".
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_ZMe7sNp-Ed-ak6NoX_4Aeg_-1312946614")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation,
    
    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as "AcceptedForSettlement".
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_ZMe7sdp-Ed-ak6NoX_4Aeg_-1312946613")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement,
    
    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as "SettlementTransactionCreated".
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_ZMe7stp-Ed-ak6NoX_4Aeg_-1312946596")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated,
    
    /// <summary>
    /// Settlement is rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_ZMe7s9p-Ed-ak6NoX_4Aeg_-1312946579")]
    [Description(@"Settlement is rejected.")]
    Rejected,
    
    /// <summary>
    /// Settlement is split.
    /// Encoded/decoded by serializers as "Split".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_ZMe7tNp-Ed-ak6NoX_4Aeg_-1312946553")]
    [Description(@"Settlement is split.")]
    Split,
    
    /// <summary>
    /// Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.
    /// Encoded/decoded by serializers as "PartiallySettled".
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_ZMe7tdp-Ed-ak6NoX_4Aeg_-1312946552")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PartiallySettled,
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_ZMe7ttp-Ed-ak6NoX_4Aeg_-1312946535")]
    [Description(@"Settlement is complete.")]
    Settled,
    
    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as "AwaitingCreationConfirmation".
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_ZMe7t9p-Ed-ak6NoX_4Aeg_-1312946518")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation,
    
    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as "AwaitingRescindConfirmation".
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_ZMe7uNp-Ed-ak6NoX_4Aeg_-1312946500")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementStatus1CodeMetadataExtensions
{
    private static readonly SettlementStatus1CodeDropdownSource _dropdownSource = new SettlementStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementStatus1CodeDropdownRow GetMetadata(this SettlementStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


