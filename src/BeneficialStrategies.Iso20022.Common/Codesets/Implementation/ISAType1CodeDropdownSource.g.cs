﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ISAType1Code.  ISO2002 ID# _adZJ-Np-Ed-ak6NoX_4Aeg_948801052.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current year ISA.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IISAType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adZJ-Np-Ed-ak6NoX_4Aeg_948801052")]
public partial class ISAType1CodeDropdownSource : EnumMetadataManager<ISAType1Code,IISAType1CodeDropdownRow,ISAType1CodeDropdownRow>
{
    public ISAType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ISAType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}