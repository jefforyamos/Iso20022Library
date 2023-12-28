﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingStatusCategory1Code.  ISO2002 ID# _-MrKBG7iEeKo25nLKvGr8w_-479292299.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingStatusCategory1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MrKBG7iEeKo25nLKvGr8w_-479292299")]
public partial class ExternalUndertakingStatusCategory1CodeDropdownSource : EnumMetadataManager<ExternalUndertakingStatusCategory1Code,IExternalUndertakingStatusCategory1CodeDropdownRow,ExternalUndertakingStatusCategory1CodeDropdownRow>
{
    public ExternalUndertakingStatusCategory1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingStatusCategory1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}