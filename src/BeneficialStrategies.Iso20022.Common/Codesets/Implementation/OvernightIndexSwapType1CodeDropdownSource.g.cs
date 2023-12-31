﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OvernightIndexSwapType1Code.  ISO2002 ID# _K7_KQLu9EeSXxOgurgHGgw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of overnight index swap transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOvernightIndexSwapType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K7_KQLu9EeSXxOgurgHGgw")]
public partial class OvernightIndexSwapType1CodeDropdownSource : EnumMetadataManager<OvernightIndexSwapType1Code,IOvernightIndexSwapType1CodeDropdownRow,OvernightIndexSwapType1CodeDropdownRow>
{
    public OvernightIndexSwapType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OvernightIndexSwapType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
