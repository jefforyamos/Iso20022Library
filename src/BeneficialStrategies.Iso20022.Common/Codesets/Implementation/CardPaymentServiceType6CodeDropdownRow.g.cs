﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardPaymentServiceType6Code.  ISO2002 ID# _DgRJ8TAXEeOqioR9srQH1g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Service provided by the card payment transaction, in addition to the main service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardPaymentServiceType6CodeDropdownSource"/>.
/// Implements <seealso cref="ICardPaymentServiceType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DgRJ8TAXEeOqioR9srQH1g")]
public partial class CardPaymentServiceType6CodeDropdownRow : EnumMetadataItem<CardPaymentServiceType6Code>, ICardPaymentServiceType6CodeDropdownRow
{
    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardPaymentServiceType6CodeDropdownRow(CardPaymentServiceType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
