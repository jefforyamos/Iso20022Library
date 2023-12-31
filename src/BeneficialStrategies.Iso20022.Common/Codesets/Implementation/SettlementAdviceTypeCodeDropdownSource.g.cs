﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementAdviceTypeCode.  ISO2002 ID# _JpEXQHygEeGWJuGCfvwOsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of settlement advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementAdviceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JpEXQHygEeGWJuGCfvwOsQ")]
public partial class SettlementAdviceTypeCodeDropdownSource : EnumMetadataManager<SettlementAdviceTypeCode,ISettlementAdviceTypeCodeDropdownRow,SettlementAdviceTypeCodeDropdownRow>
{
    public SettlementAdviceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementAdviceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
