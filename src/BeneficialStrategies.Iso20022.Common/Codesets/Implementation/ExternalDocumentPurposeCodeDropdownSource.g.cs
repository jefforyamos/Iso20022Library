﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDocumentPurposeCode.  ISO2002 ID# _Aeu_oJGDEeeBGrZP1w0opg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the document purpose as published in an external document purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDocumentPurposeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Aeu_oJGDEeeBGrZP1w0opg")]
public partial class ExternalDocumentPurposeCodeDropdownSource : EnumMetadataManager<ExternalDocumentPurposeCode,IExternalDocumentPurposeCodeDropdownRow,ExternalDocumentPurposeCodeDropdownRow>
{
    public ExternalDocumentPurposeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDocumentPurposeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
