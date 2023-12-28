﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardDataWriting1Code.  ISO2002 ID# _0hem4UepEee9r7QjOdsbFw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card  writing capabilities of the terminal performing the transaction. 
///  ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardDataWriting1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0hem4UepEee9r7QjOdsbFw")]
public partial class CardDataWriting1CodeDropdownSource : EnumMetadataManager<CardDataWriting1Code,ICardDataWriting1CodeDropdownRow,CardDataWriting1CodeDropdownRow>
{
    public CardDataWriting1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardDataWriting1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
