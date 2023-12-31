﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardAccountType3Code.  ISO2002 ID# _OJP9cY0kEeWzoK7sd7oTyw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cardholder account used for the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardAccountType3CodeDropdownSource"/>.
/// Implements <seealso cref="ICardAccountType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OJP9cY0kEeWzoK7sd7oTyw")]
public partial class CardAccountType3CodeDropdownRow : EnumMetadataItem<CardAccountType3Code>, ICardAccountType3CodeDropdownRow
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardAccountType3CodeDropdownRow(CardAccountType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
