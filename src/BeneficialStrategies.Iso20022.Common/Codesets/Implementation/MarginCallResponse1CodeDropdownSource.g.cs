﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarginCallResponse1Code.  ISO2002 ID# _Yc8VJtp-Ed-ak6NoX_4Aeg_-352735605.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarginCallResponse1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yc8VJtp-Ed-ak6NoX_4Aeg_-352735605")]
public partial class MarginCallResponse1CodeDropdownSource : EnumMetadataManager<MarginCallResponse1Code,IMarginCallResponse1CodeDropdownRow,MarginCallResponse1CodeDropdownRow>
{
    public MarginCallResponse1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarginCallResponse1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
