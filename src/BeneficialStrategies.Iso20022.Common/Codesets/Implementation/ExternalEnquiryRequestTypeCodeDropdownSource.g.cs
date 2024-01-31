﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalEnquiryRequestTypeCode.  ISO2002 ID# _lY1lkZIgEeect698_YsnIA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalEnquiryRequestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lY1lkZIgEeect698_YsnIA")]
public partial class ExternalEnquiryRequestTypeCodeDropdownSource : EnumMetadataManager<ExternalEnquiryRequestTypeCode,IExternalEnquiryRequestTypeCodeDropdownRow,ExternalEnquiryRequestTypeCodeDropdownRow>
{
    public ExternalEnquiryRequestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalEnquiryRequestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
