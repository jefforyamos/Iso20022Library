﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettleStyleCode.  ISO2002 ID# _ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when the option contract settles.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettleStyleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218")]
public partial class SettleStyleCodeDropdownSource : EnumMetadataManager<SettleStyleCode,ISettleStyleCodeDropdownRow,SettleStyleCodeDropdownRow>
{
    public SettleStyleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettleStyleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
