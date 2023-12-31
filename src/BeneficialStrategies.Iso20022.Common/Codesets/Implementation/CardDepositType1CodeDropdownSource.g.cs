﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardDepositType1Code.  ISO2002 ID# _355HIC7TEemIy6A-26wnAg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of deposit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardDepositType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_355HIC7TEemIy6A-26wnAg")]
public partial class CardDepositType1CodeDropdownSource : EnumMetadataManager<CardDepositType1Code,ICardDepositType1CodeDropdownRow,CardDepositType1CodeDropdownRow>
{
    public CardDepositType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardDepositType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
