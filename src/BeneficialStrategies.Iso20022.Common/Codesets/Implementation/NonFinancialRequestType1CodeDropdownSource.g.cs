﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonFinancialRequestType1Code.  ISO2002 ID# _a6o5MC_rEeugIJ3Gvoevmg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonFinancialRequestType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a6o5MC_rEeugIJ3Gvoevmg")]
public partial class NonFinancialRequestType1CodeDropdownSource : EnumMetadataManager<NonFinancialRequestType1Code,INonFinancialRequestType1CodeDropdownRow,NonFinancialRequestType1CodeDropdownRow>
{
    public NonFinancialRequestType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonFinancialRequestType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
