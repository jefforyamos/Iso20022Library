﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestorType3Code.  ISO2002 ID# _H58RoNdkEeibyvRfU9vJ7w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestorType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_H58RoNdkEeibyvRfU9vJ7w")]
public partial class InvestorType3CodeDropdownSource : EnumMetadataManager<InvestorType3Code,IInvestorType3CodeDropdownRow,InvestorType3CodeDropdownRow>
{
    public InvestorType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestorType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
