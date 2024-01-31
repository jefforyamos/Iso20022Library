﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EntryCode.  ISO2002 ID# _ahQ9WNp-Ed-ak6NoX_4Aeg_-1271465048.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an entry in a report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEntryCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahQ9WNp-Ed-ak6NoX_4Aeg_-1271465048")]
public partial class EntryCodeDropdownSource : EnumMetadataManager<EntryCode,IEntryCodeDropdownRow,EntryCodeDropdownRow>
{
    public EntryCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EntryCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
