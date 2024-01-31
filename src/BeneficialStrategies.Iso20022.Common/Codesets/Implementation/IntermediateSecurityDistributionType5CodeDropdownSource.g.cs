﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IntermediateSecurityDistributionType5Code.  ISO2002 ID# _-q_4AQCcEeGiE5oKUBl5wQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIntermediateSecurityDistributionType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-q_4AQCcEeGiE5oKUBl5wQ")]
public partial class IntermediateSecurityDistributionType5CodeDropdownSource : EnumMetadataManager<IntermediateSecurityDistributionType5Code,IIntermediateSecurityDistributionType5CodeDropdownRow,IntermediateSecurityDistributionType5CodeDropdownRow>
{
    public IntermediateSecurityDistributionType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IntermediateSecurityDistributionType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
