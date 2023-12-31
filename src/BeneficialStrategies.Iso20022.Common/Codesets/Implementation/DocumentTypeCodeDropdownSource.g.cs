﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DocumentTypeCode.  ISO2002 ID# _aghWddp-Ed-ak6NoX_4Aeg_-1963478091.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDocumentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aghWddp-Ed-ak6NoX_4Aeg_-1963478091")]
public partial class DocumentTypeCodeDropdownSource : EnumMetadataManager<DocumentTypeCode,IDocumentTypeCodeDropdownRow,DocumentTypeCodeDropdownRow>
{
    public DocumentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DocumentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
