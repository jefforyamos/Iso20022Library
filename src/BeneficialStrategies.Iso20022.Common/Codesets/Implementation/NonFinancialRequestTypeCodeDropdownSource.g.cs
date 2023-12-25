﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonFinancialRequestTypeCode.  ISO2002 ID# _HCEBsC_qEeugIJ3Gvoevmg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonFinancialRequestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HCEBsC_qEeugIJ3Gvoevmg")]
public partial class NonFinancialRequestTypeCodeDropdownSource : EnumMetadataManager<NonFinancialRequestTypeCode,INonFinancialRequestTypeCodeDropdownRow,NonFinancialRequestTypeCodeDropdownRow>
{
    public NonFinancialRequestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonFinancialRequestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
