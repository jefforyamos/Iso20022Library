﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardTypeCode.  ISO2002 ID# _a1-pFdp-Ed-ak6NoX_4Aeg_309816465.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of payment card.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICardTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a1-pFdp-Ed-ak6NoX_4Aeg_309816465")]
public partial class CardTypeCodeDropdownRow : EnumMetadataItem<CardTypeCode>, ICardTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of payment card.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardTypeCodeDropdownRow(CardTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}