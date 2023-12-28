﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardPaymentServiceType8Code.  ISO2002 ID# _CPqhwHsvEeSTS7uHCe8FPQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Main card service transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardPaymentServiceType8CodeDropdownSource"/>.
/// Implements <seealso cref="ICardPaymentServiceType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CPqhwHsvEeSTS7uHCe8FPQ")]
public partial class CardPaymentServiceType8CodeDropdownRow : EnumMetadataItem<CardPaymentServiceType8Code>, ICardPaymentServiceType8CodeDropdownRow
{
    /// <summary>
    /// Main card service transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardPaymentServiceType8CodeDropdownRow(CardPaymentServiceType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}