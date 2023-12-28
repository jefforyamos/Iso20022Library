﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DocumentType3Code.  ISO2002 ID# _agEqidp-Ed-ak6NoX_4Aeg_665910872.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDocumentType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_agEqidp-Ed-ak6NoX_4Aeg_665910872")]
public partial class DocumentType3CodeDropdownSource : EnumMetadataManager<DocumentType3Code,IDocumentType3CodeDropdownRow,DocumentType3CodeDropdownRow>
{
    public DocumentType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DocumentType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}