﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartialSettlement1Code.  ISO2002 ID# _ZxlM0Np-Ed-ak6NoX_4Aeg_1725602440.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information about partial settlement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartialSettlement1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxlM0Np-Ed-ak6NoX_4Aeg_1725602440")]
public partial class PartialSettlement1CodeDropdownSource : EnumMetadataManager<PartialSettlement1Code,IPartialSettlement1CodeDropdownRow,PartialSettlement1CodeDropdownRow>
{
    public PartialSettlement1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartialSettlement1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
