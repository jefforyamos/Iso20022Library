﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUndertakingStatusCategoryCode.  ISO2002 ID# _-M07BW7iEeKo25nLKvGr8w_-365959647.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUndertakingStatusCategoryCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07BW7iEeKo25nLKvGr8w_-365959647")]
public partial class ExternalUndertakingStatusCategoryCodeDropdownSource : EnumMetadataManager<ExternalUndertakingStatusCategoryCode,IExternalUndertakingStatusCategoryCodeDropdownRow,ExternalUndertakingStatusCategoryCodeDropdownRow>
{
    public ExternalUndertakingStatusCategoryCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUndertakingStatusCategoryCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
