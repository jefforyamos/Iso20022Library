﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardPaymentServiceType4Code.  ISO2002 ID# _43pE4B0mEeK5OKMB21JFBg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Main service provided during the card payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardPaymentServiceType4CodeDropdownSource"/>.
/// Implements <seealso cref="ICardPaymentServiceType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_43pE4B0mEeK5OKMB21JFBg")]
public partial class CardPaymentServiceType4CodeDropdownRow : EnumMetadataItem<CardPaymentServiceType4Code>, ICardPaymentServiceType4CodeDropdownRow
{
    /// <summary>
    /// Main service provided during the card payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardPaymentServiceType4CodeDropdownRow(CardPaymentServiceType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
