﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalAccountIdentification1Code.  ISO2002 ID# _amL5ktp-Ed-ak6NoX_4Aeg_-2079691647.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalAccountIdentification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amL5ktp-Ed-ak6NoX_4Aeg_-2079691647")]
public partial class ExternalAccountIdentification1CodeDropdownSource : EnumMetadataManager<ExternalAccountIdentification1Code,IExternalAccountIdentification1CodeDropdownRow,ExternalAccountIdentification1CodeDropdownRow>
{
    public ExternalAccountIdentification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalAccountIdentification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}