﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingDocumentTypeCode.  ISO2002 ID# _-MrKA27iEeKo25nLKvGr8w_-2015115819.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingDocumentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MrKA27iEeKo25nLKvGr8w_-2015115819")]
public partial class ExternalUndertakingDocumentTypeCodeDropdownSource : EnumMetadataManager<ExternalUndertakingDocumentTypeCode,IExternalUndertakingDocumentTypeCodeDropdownRow,ExternalUndertakingDocumentTypeCodeDropdownRow>
{
    public ExternalUndertakingDocumentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingDocumentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
