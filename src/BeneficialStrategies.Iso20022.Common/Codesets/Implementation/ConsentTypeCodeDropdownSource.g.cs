﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConsentTypeCode.  ISO2002 ID# _T9qiUCHmEeOQ7qT4JUI53A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of consent announced.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConsentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T9qiUCHmEeOQ7qT4JUI53A")]
public partial class ConsentTypeCodeDropdownSource : EnumMetadataManager<ConsentTypeCode,IConsentTypeCodeDropdownRow,ConsentTypeCodeDropdownRow>
{
    public ConsentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConsentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
