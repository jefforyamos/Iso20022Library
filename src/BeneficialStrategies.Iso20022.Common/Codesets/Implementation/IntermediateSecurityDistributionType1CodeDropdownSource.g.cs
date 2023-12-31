﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IntermediateSecurityDistributionType1Code.  ISO2002 ID# _aZ-Ch9p-Ed-ak6NoX_4Aeg_1639683801.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIntermediateSecurityDistributionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aZ-Ch9p-Ed-ak6NoX_4Aeg_1639683801")]
public partial class IntermediateSecurityDistributionType1CodeDropdownSource : EnumMetadataManager<IntermediateSecurityDistributionType1Code,IIntermediateSecurityDistributionType1CodeDropdownRow,IntermediateSecurityDistributionType1CodeDropdownRow>
{
    public IntermediateSecurityDistributionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IntermediateSecurityDistributionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
