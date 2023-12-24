﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalOrganisationIdentificationCode.  ISO2002 ID# __E7E8IKYEeeCI5iKR7LsYQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalOrganisationIdentificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__E7E8IKYEeeCI5iKR7LsYQ")]
public partial class ExternalOrganisationIdentificationCodeDropdownSource : EnumMetadataManager<ExternalOrganisationIdentificationCode,IExternalOrganisationIdentificationCodeDropdownRow,ExternalOrganisationIdentificationCodeDropdownRow>
{
    public ExternalOrganisationIdentificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalOrganisationIdentificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
