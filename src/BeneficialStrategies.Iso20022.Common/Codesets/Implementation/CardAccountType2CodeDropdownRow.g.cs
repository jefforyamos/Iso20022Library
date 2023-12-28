﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardAccountType2Code.  ISO2002 ID# _xA5FIGkFEeS7zPBpvm732w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cardholder account used for the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardAccountType2CodeDropdownSource"/>.
/// Implements <seealso cref="ICardAccountType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xA5FIGkFEeS7zPBpvm732w")]
public partial class CardAccountType2CodeDropdownRow : EnumMetadataItem<CardAccountType2Code>, ICardAccountType2CodeDropdownRow
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardAccountType2CodeDropdownRow(CardAccountType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}