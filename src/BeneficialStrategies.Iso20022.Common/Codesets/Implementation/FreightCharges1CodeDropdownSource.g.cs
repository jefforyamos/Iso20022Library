﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FreightCharges1Code.  ISO2002 ID# _ar_modp-Ed-ak6NoX_4Aeg_-1465550015.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the arrangement as to the freight charges.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFreightCharges1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ar_modp-Ed-ak6NoX_4Aeg_-1465550015")]
public partial class FreightCharges1CodeDropdownSource : EnumMetadataManager<FreightCharges1Code,IFreightCharges1CodeDropdownRow,FreightCharges1CodeDropdownRow>
{
    public FreightCharges1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FreightCharges1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}