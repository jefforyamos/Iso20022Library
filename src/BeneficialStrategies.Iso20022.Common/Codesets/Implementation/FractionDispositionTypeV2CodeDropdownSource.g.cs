﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FractionDispositionTypeV2Code.  ISO2002 ID# _XZUVsWR8EeKFfdK0gKYFLQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFractionDispositionTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XZUVsWR8EeKFfdK0gKYFLQ")]
public partial class FractionDispositionTypeV2CodeDropdownSource : EnumMetadataManager<FractionDispositionTypeV2Code,IFractionDispositionTypeV2CodeDropdownRow,FractionDispositionTypeV2CodeDropdownRow>
{
    public FractionDispositionTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FractionDispositionTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}