﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalTaxAmountTypeCode.  ISO2002 ID# _4wFuwIMlEeeBDNMiErKunw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalTaxAmountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4wFuwIMlEeeBDNMiErKunw")]
public partial class ExternalTaxAmountTypeCodeDropdownSource : EnumMetadataManager<ExternalTaxAmountTypeCode,IExternalTaxAmountTypeCodeDropdownRow,ExternalTaxAmountTypeCodeDropdownRow>
{
    public ExternalTaxAmountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalTaxAmountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
