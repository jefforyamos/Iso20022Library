﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDataWriting1Code.  ISO2002 ID# _0hem4UepEee9r7QjOdsbFw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card  writing capabilities of the terminal performing the transaction. 
///  ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDataWriting1CodeDropdownSource"/>.
/// Implements <seealso cref="ICardDataWriting1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0hem4UepEee9r7QjOdsbFw")]
public partial class CardDataWriting1CodeDropdownRow : EnumMetadataItem<CardDataWriting1Code>, ICardDataWriting1CodeDropdownRow
{
    /// <summary>
    /// Card  writing capabilities of the terminal performing the transaction. 
    ///  ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDataWriting1CodeDropdownRow(CardDataWriting1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
