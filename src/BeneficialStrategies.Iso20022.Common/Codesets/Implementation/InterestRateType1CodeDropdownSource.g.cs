﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestRateType1Code.  ISO2002 ID# _xwTEsLtKEeSmENFdxjMqzQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of interest rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestRateType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xwTEsLtKEeSmENFdxjMqzQ")]
public partial class InterestRateType1CodeDropdownSource : EnumMetadataManager<InterestRateType1Code,IInterestRateType1CodeDropdownRow,InterestRateType1CodeDropdownRow>
{
    public InterestRateType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestRateType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}