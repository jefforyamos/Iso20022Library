﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalCashAccountType1Code.  ISO2002 ID# _t7bogVkyEeGeoaLUQk__nA_-2034002224.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalCashAccountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t7bogVkyEeGeoaLUQk__nA_-2034002224")]
public partial class ExternalCashAccountType1CodeDropdownSource : EnumMetadataManager<ExternalCashAccountType1Code,IExternalCashAccountType1CodeDropdownRow,ExternalCashAccountType1CodeDropdownRow>
{
    public ExternalCashAccountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalCashAccountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}