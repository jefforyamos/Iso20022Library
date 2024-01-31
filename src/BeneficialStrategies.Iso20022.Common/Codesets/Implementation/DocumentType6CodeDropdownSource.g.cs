﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DocumentType6Code.  ISO2002 ID# _xEXUIR78EeSxevWRRWxNAg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDocumentType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xEXUIR78EeSxevWRRWxNAg")]
public partial class DocumentType6CodeDropdownSource : EnumMetadataManager<DocumentType6Code,IDocumentType6CodeDropdownRow,DocumentType6CodeDropdownRow>
{
    public DocumentType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DocumentType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
