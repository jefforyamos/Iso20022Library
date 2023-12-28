﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionFrequencyType3Code.  ISO2002 ID# _r1AnQCXeEeO4bIO_HtGo9Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Automatic Reinvestment of Cash distributed by accumulating funds.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionFrequencyType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_r1AnQCXeEeO4bIO_HtGo9Q")]
public partial class CorporateActionFrequencyType3CodeDropdownSource : EnumMetadataManager<CorporateActionFrequencyType3Code,ICorporateActionFrequencyType3CodeDropdownRow,CorporateActionFrequencyType3CodeDropdownRow>
{
    public CorporateActionFrequencyType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionFrequencyType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
