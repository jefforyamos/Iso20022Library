﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardholderVerificationCapability1Code.  ISO2002 ID# _TSg-dAEcEeCQm6a_G2yO_w_-949484223.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardholderVerificationCapability1CodeDropdownSource"/>.
/// Implements <seealso cref="ICardholderVerificationCapability1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSg-dAEcEeCQm6a_G2yO_w_-949484223")]
public partial class CardholderVerificationCapability1CodeDropdownRow : EnumMetadataItem<CardholderVerificationCapability1Code>, ICardholderVerificationCapability1CodeDropdownRow
{
    /// <summary>
    /// Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardholderVerificationCapability1CodeDropdownRow(CardholderVerificationCapability1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}