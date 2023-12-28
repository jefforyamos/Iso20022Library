﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDocumentTypeCode.  ISO2002 ID# _8jvwwJGCEeeBGrZP1w0opg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the document type as published in an external document type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDocumentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8jvwwJGCEeeBGrZP1w0opg")]
public partial class ExternalDocumentTypeCodeDropdownSource : EnumMetadataManager<ExternalDocumentTypeCode,IExternalDocumentTypeCodeDropdownRow,ExternalDocumentTypeCodeDropdownRow>
{
    public ExternalDocumentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDocumentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}