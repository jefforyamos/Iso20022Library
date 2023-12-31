﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingTypeCode.  ISO2002 ID# _-M07AG7iEeKo25nLKvGr8w_-1585779072.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external undertaking type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07AG7iEeKo25nLKvGr8w_-1585779072")]
public partial class ExternalUndertakingTypeCodeDropdownSource : EnumMetadataManager<ExternalUndertakingTypeCode,IExternalUndertakingTypeCodeDropdownRow,ExternalUndertakingTypeCodeDropdownRow>
{
    public ExternalUndertakingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
