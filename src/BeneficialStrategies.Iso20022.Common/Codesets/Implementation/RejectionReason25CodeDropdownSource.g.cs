﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason25Code.  ISO2002 ID# _ZjlNFtp-Ed-ak6NoX_4Aeg_-1820710282.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason25CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZjlNFtp-Ed-ak6NoX_4Aeg_-1820710282")]
public partial class RejectionReason25CodeDropdownSource : EnumMetadataManager<RejectionReason25Code,IRejectionReason25CodeDropdownRow,RejectionReason25CodeDropdownRow>
{
    public RejectionReason25CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason25CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
