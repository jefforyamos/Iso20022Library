﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementStatusCode.  ISO2002 ID# _ZMe7udp-Ed-ak6NoX_4Aeg_1523779610.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMe7udp-Ed-ak6NoX_4Aeg_1523779610")]
[Description(@"Specifies the status of the settlement of a trade in a central matching and settlement system.")]
public enum SettlementStatusCode
{
    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as "AAUT".
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_ZMoFoNp-Ed-ak6NoX_4Aeg_1554255343")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation,
    
    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as "ASTL".
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_ZMoFodp-Ed-ak6NoX_4Aeg_1608742231")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement,
    
    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as "STCR".
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_ZMoFotp-Ed-ak6NoX_4Aeg_1691859101")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated,
    
    /// <summary>
    /// Settlement is rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_ZMoFo9p-Ed-ak6NoX_4Aeg_1793447312")]
    [Description(@"Settlement is rejected.")]
    Rejected,
    
    /// <summary>
    /// Settlement is split.
    /// Encoded/decoded by serializers as "SPLT".
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_ZMoFpNp-Ed-ak6NoX_4Aeg_2007706027")]
    [Description(@"Settlement is split.")]
    Split,
    
    /// <summary>
    /// Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.
    /// Encoded/decoded by serializers as "PSTL".
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_ZMoFpdp-Ed-ak6NoX_4Aeg_2040029261")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PartiallySettled,
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as "STLD".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_ZMoFptp-Ed-ak6NoX_4Aeg_2053880097")]
    [Description(@"Settlement is complete.")]
    Settled,
    
    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as "ACCF".
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_ZMoFp9p-Ed-ak6NoX_4Aeg_2067732102")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation,
    
    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as "ARCF".
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_ZMoFqNp-Ed-ak6NoX_4Aeg_-1741459880")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation,
    
    /// <summary>
    /// Instruction is matched.
    /// Encoded/decoded by serializers as "MTCH".
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_HudkwAFzEeutW5-TpeYJhA")]
    [Description(@"Instruction is matched.")]
    Matched,
    
    /// <summary>
    /// Instruction is unmatched.
    /// Encoded/decoded by serializers as "NMAT".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_c6-l0AFzEeutW5-TpeYJhA")]
    [Description(@"Instruction is unmatched.")]
    Unmatched,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementStatusCodeMetadataExtensions
{
    private static readonly SettlementStatusCodeDropdownSource _dropdownSource = new SettlementStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementStatusCodeDropdownRow GetMetadata(this SettlementStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


