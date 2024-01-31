﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CalculationBasis1Code.  ISO2002 ID# _VjbKVtp-Ed-ak6NoX_4Aeg_-1887209997.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation basis.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICalculationBasis1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VjbKVtp-Ed-ak6NoX_4Aeg_-1887209997")]
public partial class CalculationBasis1CodeDropdownSource : EnumMetadataManager<CalculationBasis1Code,ICalculationBasis1CodeDropdownRow,CalculationBasis1CodeDropdownRow>
{
    public CalculationBasis1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CalculationBasis1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
