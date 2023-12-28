﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CheckType1Code.  ISO2002 ID# _fyQcYNtbEeipuvJHTHIw9A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of bank check.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICheckType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fyQcYNtbEeipuvJHTHIw9A")]
public partial class CheckType1CodeDropdownSource : EnumMetadataManager<CheckType1Code,ICheckType1CodeDropdownRow,CheckType1CodeDropdownRow>
{
    public CheckType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CheckType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}