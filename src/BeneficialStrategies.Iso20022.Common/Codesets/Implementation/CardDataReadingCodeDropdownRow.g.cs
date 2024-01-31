﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDataReadingCode.  ISO2002 ID# _TWF24QEcEeCQm6a_G2yO_w_-992719908.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDataReadingCodeDropdownSource"/>.
/// Implements <seealso cref="ICardDataReadingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWF24QEcEeCQm6a_G2yO_w_-992719908")]
public partial class CardDataReadingCodeDropdownRow : EnumMetadataItem<CardDataReadingCode>, ICardDataReadingCodeDropdownRow
{
    /// <summary>
    /// Type of reading of the card data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDataReadingCodeDropdownRow(CardDataReadingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
