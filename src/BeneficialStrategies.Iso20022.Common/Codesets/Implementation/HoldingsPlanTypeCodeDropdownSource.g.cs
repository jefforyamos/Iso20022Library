﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for HoldingsPlanTypeCode.  ISO2002 ID# _1TJzwwnwEeGRcv5_yGDZOA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IHoldingsPlanTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1TJzwwnwEeGRcv5_yGDZOA")]
public partial class HoldingsPlanTypeCodeDropdownSource : EnumMetadataManager<HoldingsPlanTypeCode,IHoldingsPlanTypeCodeDropdownRow,HoldingsPlanTypeCodeDropdownRow>
{
    public HoldingsPlanTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new HoldingsPlanTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}