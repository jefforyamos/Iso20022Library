﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BusinessProcessTypeCode.  ISO2002 ID# __0wOw9ojEeC60axPepSq7g_-159430534.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of business process model used to carry out the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBusinessProcessTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0wOw9ojEeC60axPepSq7g_-159430534")]
public partial class BusinessProcessTypeCodeDropdownSource : EnumMetadataManager<BusinessProcessTypeCode,IBusinessProcessTypeCodeDropdownRow,BusinessProcessTypeCodeDropdownRow>
{
    public BusinessProcessTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BusinessProcessTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
