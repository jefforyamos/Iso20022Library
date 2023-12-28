﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FractionDispositionType11Code.  ISO2002 ID# _dafmQGSCEeKFfdK0gKYFLQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFractionDispositionType11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dafmQGSCEeKFfdK0gKYFLQ")]
public partial class FractionDispositionType11CodeDropdownSource : EnumMetadataManager<FractionDispositionType11Code,IFractionDispositionType11CodeDropdownRow,FractionDispositionType11CodeDropdownRow>
{
    public FractionDispositionType11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FractionDispositionType11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}