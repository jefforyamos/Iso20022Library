﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason18Code.  ISO2002 ID# _Zir1Ndp-Ed-ak6NoX_4Aeg_1336974420.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of an election advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zir1Ndp-Ed-ak6NoX_4Aeg_1336974420")]
public partial class RejectionReason18CodeDropdownSource : EnumMetadataManager<RejectionReason18Code,IRejectionReason18CodeDropdownRow,RejectionReason18CodeDropdownRow>
{
    public RejectionReason18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
