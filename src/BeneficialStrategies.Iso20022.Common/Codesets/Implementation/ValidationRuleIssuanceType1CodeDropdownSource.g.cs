﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleIssuanceType1Code.  ISO2002 ID# _rW7kBCBqEeugLNJneiyzbA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleIssuanceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rW7kBCBqEeugLNJneiyzbA")]
public partial class ValidationRuleIssuanceType1CodeDropdownSource : EnumMetadataManager<ValidationRuleIssuanceType1Code,IValidationRuleIssuanceType1CodeDropdownRow,ValidationRuleIssuanceType1CodeDropdownRow>
{
    public ValidationRuleIssuanceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleIssuanceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
