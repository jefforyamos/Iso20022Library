﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxEfficientProductType1Code.  ISO2002 ID# _Xccy8E4MEeiQHa-q1Uephw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of tax efficient product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxEfficientProductType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Xccy8E4MEeiQHa-q1Uephw")]
public partial class TaxEfficientProductType1CodeDropdownSource : EnumMetadataManager<TaxEfficientProductType1Code,ITaxEfficientProductType1CodeDropdownRow,TaxEfficientProductType1CodeDropdownRow>
{
    public TaxEfficientProductType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxEfficientProductType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
