﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OtherAmountType1Code.  ISO2002 ID# _0W9oEK53Eee6Q7mFsDuJBA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of other amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOtherAmountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0W9oEK53Eee6Q7mFsDuJBA")]
public partial class OtherAmountType1CodeDropdownSource : EnumMetadataManager<OtherAmountType1Code,IOtherAmountType1CodeDropdownRow,OtherAmountType1CodeDropdownRow>
{
    public OtherAmountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OtherAmountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
