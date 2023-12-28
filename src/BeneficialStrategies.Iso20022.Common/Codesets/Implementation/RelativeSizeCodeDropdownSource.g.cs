﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RelativeSizeCode.  ISO2002 ID# _ZsOLstp-Ed-ak6NoX_4Aeg_336258693.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// A type of quantity of financial instrument expressed in a relative size.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRelativeSizeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZsOLstp-Ed-ak6NoX_4Aeg_336258693")]
public partial class RelativeSizeCodeDropdownSource : EnumMetadataManager<RelativeSizeCode,IRelativeSizeCodeDropdownRow,RelativeSizeCodeDropdownRow>
{
    public RelativeSizeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RelativeSizeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}