﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingDocumentType1Code.  ISO2002 ID# _-MrKAW7iEeKo25nLKvGr8w_11518920.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingDocumentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MrKAW7iEeKo25nLKvGr8w_11518920")]
public partial class ExternalUndertakingDocumentType1CodeDropdownSource : EnumMetadataManager<ExternalUndertakingDocumentType1Code,IExternalUndertakingDocumentType1CodeDropdownRow,ExternalUndertakingDocumentType1CodeDropdownRow>
{
    public ExternalUndertakingDocumentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingDocumentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}