﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EntryStatus4Code.  ISO2002 ID# _ahkfVtp-Ed-ak6NoX_4Aeg_-117852605.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEntryStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahkfVtp-Ed-ak6NoX_4Aeg_-117852605")]
public partial class EntryStatus4CodeDropdownSource : EnumMetadataManager<EntryStatus4Code,IEntryStatus4CodeDropdownRow,EntryStatus4CodeDropdownRow>
{
    public EntryStatus4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EntryStatus4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
