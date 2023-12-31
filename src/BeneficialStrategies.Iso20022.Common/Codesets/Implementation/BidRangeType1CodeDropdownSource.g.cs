﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BidRangeType1Code.  ISO2002 ID# _EsjOkO3NEeqc-LCjwLsUVg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of acceptable bid range values.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBidRangeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EsjOkO3NEeqc-LCjwLsUVg")]
public partial class BidRangeType1CodeDropdownSource : EnumMetadataManager<BidRangeType1Code,IBidRangeType1CodeDropdownRow,BidRangeType1CodeDropdownRow>
{
    public BidRangeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BidRangeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
