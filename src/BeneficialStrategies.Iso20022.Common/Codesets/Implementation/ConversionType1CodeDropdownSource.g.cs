﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConversionType1Code.  ISO2002 ID# _bCNHNtp-Ed-ak6NoX_4Aeg_-673877093.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of conversion.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConversionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCNHNtp-Ed-ak6NoX_4Aeg_-673877093")]
public partial class ConversionType1CodeDropdownSource : EnumMetadataManager<ConversionType1Code,IConversionType1CodeDropdownRow,ConversionType1CodeDropdownRow>
{
    public ConversionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConversionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
