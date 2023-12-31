﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingDocumentTypeCode_Obsolete.  ISO2002 ID# _rJUs5nCcEe2v-4Te0Ownww.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingDocumentTypeCode_ObsoleteDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rJUs5nCcEe2v-4Te0Ownww")]
public partial class ExternalUndertakingDocumentTypeCode_ObsoleteDropdownSource : EnumMetadataManager<ExternalUndertakingDocumentTypeCode_Obsolete,IExternalUndertakingDocumentTypeCode_ObsoleteDropdownRow,ExternalUndertakingDocumentTypeCode_ObsoleteDropdownRow>
{
    public ExternalUndertakingDocumentTypeCode_ObsoleteDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingDocumentTypeCode_ObsoleteDropdownRow(enumValue, memberInfo))
    {
    }
}
