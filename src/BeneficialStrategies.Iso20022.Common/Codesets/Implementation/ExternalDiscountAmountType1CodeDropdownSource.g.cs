﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDiscountAmountType1Code.  ISO2002 ID# _t7boglkyEeGeoaLUQk__nA_611729510.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDiscountAmountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t7boglkyEeGeoaLUQk__nA_611729510")]
public partial class ExternalDiscountAmountType1CodeDropdownSource : EnumMetadataManager<ExternalDiscountAmountType1Code,IExternalDiscountAmountType1CodeDropdownRow,ExternalDiscountAmountType1CodeDropdownRow>
{
    public ExternalDiscountAmountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDiscountAmountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
