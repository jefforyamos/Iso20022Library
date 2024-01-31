﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDataReading6Code.  ISO2002 ID# _z_QlkdkIEeiojJsa6FYyew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDataReading6CodeDropdownSource"/>.
/// Implements <seealso cref="ICardDataReading6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_z_QlkdkIEeiojJsa6FYyew")]
public partial class CardDataReading6CodeDropdownRow : EnumMetadataItem<CardDataReading6Code>, ICardDataReading6CodeDropdownRow
{
    /// <summary>
    /// Type of reading of the card data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDataReading6CodeDropdownRow(CardDataReading6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
