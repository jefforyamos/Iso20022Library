﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardPaymentServiceType3Code.  ISO2002 ID# _TSz5ZgEcEeCQm6a_G2yO_w_-878282467.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional attributes of the service provided by the card payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardPaymentServiceType3CodeDropdownSource"/>.
/// Implements <seealso cref="ICardPaymentServiceType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSz5ZgEcEeCQm6a_G2yO_w_-878282467")]
public partial class CardPaymentServiceType3CodeDropdownRow : EnumMetadataItem<CardPaymentServiceType3Code>, ICardPaymentServiceType3CodeDropdownRow
{
    /// <summary>
    /// Additional attributes of the service provided by the card payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardPaymentServiceType3CodeDropdownRow(CardPaymentServiceType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}