﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingStatus3Code.  ISO2002 ID# _VopBgdp-Ed-ak6NoX_4Aeg_1443081782.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the state of a payment at the clearing agent side is pending.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VopBgdp-Ed-ak6NoX_4Aeg_1443081782")]
public partial class PendingStatus3CodeDropdownSource : EnumMetadataManager<PendingStatus3Code,IPendingStatus3CodeDropdownRow,PendingStatus3CodeDropdownRow>
{
    public PendingStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
