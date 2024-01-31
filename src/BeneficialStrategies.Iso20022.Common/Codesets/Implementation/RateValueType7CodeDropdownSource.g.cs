﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RateValueType7Code.  ISO2002 ID# _jWIcIeGYEd-1Ktb5rVaajw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRateValueType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jWIcIeGYEd-1Ktb5rVaajw")]
public partial class RateValueType7CodeDropdownSource : EnumMetadataManager<RateValueType7Code,IRateValueType7CodeDropdownRow,RateValueType7CodeDropdownRow>
{
    public RateValueType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RateValueType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
