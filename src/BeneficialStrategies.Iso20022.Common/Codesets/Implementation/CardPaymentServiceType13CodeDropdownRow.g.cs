﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardPaymentServiceType13Code.  ISO2002 ID# __bL2gNueEeiB5uLfkg9ZJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional attribute of the service type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardPaymentServiceType13CodeDropdownSource"/>.
/// Implements <seealso cref="ICardPaymentServiceType13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__bL2gNueEeiB5uLfkg9ZJA")]
public partial class CardPaymentServiceType13CodeDropdownRow : EnumMetadataItem<CardPaymentServiceType13Code>, ICardPaymentServiceType13CodeDropdownRow
{
    /// <summary>
    /// Additional attribute of the service type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardPaymentServiceType13CodeDropdownRow(CardPaymentServiceType13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
