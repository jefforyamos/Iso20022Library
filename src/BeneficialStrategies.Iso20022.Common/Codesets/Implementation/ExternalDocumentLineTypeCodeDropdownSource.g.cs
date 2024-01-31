﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDocumentLineTypeCode.  ISO2002 ID# _RxJesLf7EeeNBs0sDWdcSw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the document line type as published in an external document type code list.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDocumentLineTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RxJesLf7EeeNBs0sDWdcSw")]
public partial class ExternalDocumentLineTypeCodeDropdownSource : EnumMetadataManager<ExternalDocumentLineTypeCode,IExternalDocumentLineTypeCodeDropdownRow,ExternalDocumentLineTypeCodeDropdownRow>
{
    public ExternalDocumentLineTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDocumentLineTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
