﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryTypeV2Code.  ISO2002 ID# _ltUEcNomEeCWg-hsBVGrDA_-989246574.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ltUEcNomEeCWg-hsBVGrDA_-989246574")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[Derivations(typeof(DeliveryType2Code))]
// External derivations that should be provided by the proper interface are: 
public enum DeliveryTypeV2Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as "APMT".
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("_ltUEcdomEeCWg-hsBVGrDA_-1103085640")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment,
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as "FREE".
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_ltUEctomEeCWg-hsBVGrDA_-1808200255")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free,
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as "TRIP".
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_ltUEc9omEeCWg-hsBVGrDA_1311576016")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty,
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account ("held in custody") by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as "HOIC".
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_ltd1cNomEeCWg-hsBVGrDA_-1338123845")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryTypeV2CodeMetadataExtensions
{
    private static readonly DeliveryTypeV2CodeDropdownSource _dropdownSource = new DeliveryTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryTypeV2CodeDropdownRow GetMetadata(this DeliveryTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


