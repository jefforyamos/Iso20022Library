﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GovernanceProcessTypeCode.  ISO2002 ID# _EFRD0ID5Eeiw-daIkkmMqQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of governance process.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGovernanceProcessTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EFRD0ID5Eeiw-daIkkmMqQ")]
public partial class GovernanceProcessTypeCodeDropdownSource : EnumMetadataManager<GovernanceProcessTypeCode,IGovernanceProcessTypeCodeDropdownRow,GovernanceProcessTypeCodeDropdownRow>
{
    public GovernanceProcessTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GovernanceProcessTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
