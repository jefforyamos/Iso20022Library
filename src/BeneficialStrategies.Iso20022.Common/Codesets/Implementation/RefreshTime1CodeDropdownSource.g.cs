﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RefreshTime1Code.  ISO2002 ID# _Zaydddp-Ed-ak6NoX_4Aeg_761872038.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines when to refresh.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRefreshTime1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zaydddp-Ed-ak6NoX_4Aeg_761872038")]
public partial class RefreshTime1CodeDropdownSource : EnumMetadataManager<RefreshTime1Code,IRefreshTime1CodeDropdownRow,RefreshTime1CodeDropdownRow>
{
    public RefreshTime1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RefreshTime1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
