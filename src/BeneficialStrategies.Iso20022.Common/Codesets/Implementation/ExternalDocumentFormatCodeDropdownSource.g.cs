﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDocumentFormatCode.  ISO2002 ID# _-M07BG7iEeKo25nLKvGr8w_1805570785.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDocumentFormatCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07BG7iEeKo25nLKvGr8w_1805570785")]
public partial class ExternalDocumentFormatCodeDropdownSource : EnumMetadataManager<ExternalDocumentFormatCode,IExternalDocumentFormatCodeDropdownRow,ExternalDocumentFormatCodeDropdownRow>
{
    public ExternalDocumentFormatCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDocumentFormatCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
