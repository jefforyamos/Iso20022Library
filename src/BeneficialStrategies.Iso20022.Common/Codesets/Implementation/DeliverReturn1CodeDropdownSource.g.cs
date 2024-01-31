﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliverReturn1Code.  ISO2002 ID# _YcMuQtp-Ed-ak6NoX_4Aeg_2021261628.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral is to be delivered or returned.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliverReturn1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcMuQtp-Ed-ak6NoX_4Aeg_2021261628")]
public partial class DeliverReturn1CodeDropdownSource : EnumMetadataManager<DeliverReturn1Code,IDeliverReturn1CodeDropdownRow,DeliverReturn1CodeDropdownRow>
{
    public DeliverReturn1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliverReturn1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
