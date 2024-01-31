﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EntryStatus2Code.  ISO2002 ID# _ahkfUNp-Ed-ak6NoX_4Aeg_-1772073374.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEntryStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahkfUNp-Ed-ak6NoX_4Aeg_-1772073374")]
public partial class EntryStatus2CodeDropdownSource : EnumMetadataManager<EntryStatus2Code,IEntryStatus2CodeDropdownRow,EntryStatus2CodeDropdownRow>
{
    public EntryStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EntryStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
