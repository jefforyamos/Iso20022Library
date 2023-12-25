﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDateFrequencyCode.  ISO2002 ID# _-M07Am7iEeKo25nLKvGr8w_-1381419165.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDateFrequencyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07Am7iEeKo25nLKvGr8w_-1381419165")]
public partial class ExternalDateFrequencyCodeDropdownSource : EnumMetadataManager<ExternalDateFrequencyCode,IExternalDateFrequencyCodeDropdownRow,ExternalDateFrequencyCodeDropdownRow>
{
    public ExternalDateFrequencyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDateFrequencyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
