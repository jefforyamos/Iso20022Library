﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestorType1Code.  ISO2002 ID# _haryuGliEeGaMcKyqKNRfQ_4555923.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestorType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_haryuGliEeGaMcKyqKNRfQ_4555923")]
public partial class InvestorType1CodeDropdownSource : EnumMetadataManager<InvestorType1Code,IInvestorType1CodeDropdownRow,InvestorType1CodeDropdownRow>
{
    public InvestorType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestorType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}