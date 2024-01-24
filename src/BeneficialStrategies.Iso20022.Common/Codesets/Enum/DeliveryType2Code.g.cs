﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryType2Code.  ISO2002 ID# __1ywktojEeC60axPepSq7g_-1223322819.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1ywktojEeC60axPepSq7g_-1223322819")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[DerivedFrom(typeof(DeliveryTypeV2Code))]
public enum DeliveryType2Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as "APMT".
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("__1ywk9ojEeC60axPepSq7g_-1012044378")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment = DeliveryTypeV2Code.AgainstPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as "FREE".
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("__1ywlNojEeC60axPepSq7g_-5169852")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free = DeliveryTypeV2Code.Free, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as "TRIP".
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("__1ywldojEeC60axPepSq7g_-423703442")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty = DeliveryTypeV2Code.Triparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account ("held in custody") by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as "HOIC".
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("__18hkNojEeC60axPepSq7g_1043445321")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody = DeliveryTypeV2Code.HoldInCustody, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryType2CodeMetadataExtensions
{
    private static readonly DeliveryType2CodeDropdownSource _dropdownSource = new DeliveryType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryType2CodeDropdownRow GetMetadata(this DeliveryType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


