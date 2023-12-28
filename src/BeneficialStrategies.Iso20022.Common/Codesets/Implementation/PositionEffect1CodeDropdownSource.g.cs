﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PositionEffect1Code.  ISO2002 ID# _aHWBddp-Ed-ak6NoX_4Aeg_-238274604.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPositionEffect1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aHWBddp-Ed-ak6NoX_4Aeg_-238274604")]
public partial class PositionEffect1CodeDropdownSource : EnumMetadataManager<PositionEffect1Code,IPositionEffect1CodeDropdownRow,PositionEffect1CodeDropdownRow>
{
    public PositionEffect1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PositionEffect1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}