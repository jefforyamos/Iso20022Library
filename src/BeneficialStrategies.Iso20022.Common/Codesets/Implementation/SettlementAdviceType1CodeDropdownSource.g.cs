﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementAdviceType1Code.  ISO2002 ID# _CEe5kHyiEeGWJuGCfvwOsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of settlement advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementAdviceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CEe5kHyiEeGWJuGCfvwOsQ")]
public partial class SettlementAdviceType1CodeDropdownSource : EnumMetadataManager<SettlementAdviceType1Code,ISettlementAdviceType1CodeDropdownRow,SettlementAdviceType1CodeDropdownRow>
{
    public SettlementAdviceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementAdviceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
