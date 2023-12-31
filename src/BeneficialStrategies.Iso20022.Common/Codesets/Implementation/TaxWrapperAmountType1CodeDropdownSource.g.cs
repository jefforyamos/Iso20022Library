﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxWrapperAmountType1Code.  ISO2002 ID# _Cjj9AF25EeiFXdiLi_Nf4A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxWrapperAmountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Cjj9AF25EeiFXdiLi_Nf4A")]
public partial class TaxWrapperAmountType1CodeDropdownSource : EnumMetadataManager<TaxWrapperAmountType1Code,ITaxWrapperAmountType1CodeDropdownRow,TaxWrapperAmountType1CodeDropdownRow>
{
    public TaxWrapperAmountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxWrapperAmountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
