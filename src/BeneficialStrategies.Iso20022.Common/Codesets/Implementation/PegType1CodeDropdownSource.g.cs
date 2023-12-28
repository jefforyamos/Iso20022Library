﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PegType1Code.  ISO2002 ID# _Z9p599p-Ed-ak6NoX_4Aeg_307440382.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPegType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z9p599p-Ed-ak6NoX_4Aeg_307440382")]
public partial class PegType1CodeDropdownSource : EnumMetadataManager<PegType1Code,IPegType1CodeDropdownRow,PegType1CodeDropdownRow>
{
    public PegType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PegType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
