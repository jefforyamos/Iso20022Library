﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CopyDuplicateCode.  ISO2002 ID# _bCWRJ9p-Ed-ak6NoX_4Aeg_-1110982463.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICopyDuplicateCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCWRJ9p-Ed-ak6NoX_4Aeg_-1110982463")]
public partial class CopyDuplicateCodeDropdownSource : EnumMetadataManager<CopyDuplicateCode,ICopyDuplicateCodeDropdownRow,CopyDuplicateCodeDropdownRow>
{
    public CopyDuplicateCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CopyDuplicateCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
