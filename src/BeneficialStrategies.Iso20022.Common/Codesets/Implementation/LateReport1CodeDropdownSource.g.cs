﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LateReport1Code.  ISO2002 ID# _adsE6Np-Ed-ak6NoX_4Aeg_-1914008169.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a transaction report is late.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILateReport1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adsE6Np-Ed-ak6NoX_4Aeg_-1914008169")]
public partial class LateReport1CodeDropdownSource : EnumMetadataManager<LateReport1Code,ILateReport1CodeDropdownRow,LateReport1CodeDropdownRow>
{
    public LateReport1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LateReport1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
