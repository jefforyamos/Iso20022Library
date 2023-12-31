﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardServiceTypeCode.  ISO2002 ID# _l0Ao8Hu8EeSLmfFG0DG7zQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of administrative service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardServiceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICardServiceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_l0Ao8Hu8EeSLmfFG0DG7zQ")]
public partial class CardServiceTypeCodeDropdownRow : EnumMetadataItem<CardServiceTypeCode>, ICardServiceTypeCodeDropdownRow
{
    /// <summary>
    /// Type of administrative service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardServiceTypeCodeDropdownRow(CardServiceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
