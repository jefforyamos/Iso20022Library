﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDateFrequency1Code.  ISO2002 ID# _-MOeEW7iEeKo25nLKvGr8w_1230837438.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDateFrequency1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MOeEW7iEeKo25nLKvGr8w_1230837438")]
public partial class ExternalDateFrequency1CodeDropdownSource : EnumMetadataManager<ExternalDateFrequency1Code,IExternalDateFrequency1CodeDropdownRow,ExternalDateFrequency1CodeDropdownRow>
{
    public ExternalDateFrequency1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDateFrequency1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}