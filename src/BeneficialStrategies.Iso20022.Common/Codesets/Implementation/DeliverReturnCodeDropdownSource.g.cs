﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliverReturnCode.  ISO2002 ID# _YcMuRdp-Ed-ak6NoX_4Aeg_-662678761.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the collateral is to be delivered or returned.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliverReturnCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcMuRdp-Ed-ak6NoX_4Aeg_-662678761")]
public partial class DeliverReturnCodeDropdownSource : EnumMetadataManager<DeliverReturnCode,IDeliverReturnCodeDropdownRow,DeliverReturnCodeDropdownRow>
{
    public DeliverReturnCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliverReturnCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
