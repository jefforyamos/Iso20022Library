﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DocumentType2Code.  ISO2002 ID# _af7gl9p-Ed-ak6NoX_4Aeg_-1135079340.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDocumentType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_af7gl9p-Ed-ak6NoX_4Aeg_-1135079340")]
public partial class DocumentType2CodeDropdownSource : EnumMetadataManager<DocumentType2Code,IDocumentType2CodeDropdownRow,DocumentType2CodeDropdownRow>
{
    public DocumentType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DocumentType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
