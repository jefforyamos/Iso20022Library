﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancellationRight1Code.  ISO2002 ID# _bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancellationRight1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690")]
public partial class CancellationRight1CodeDropdownSource : EnumMetadataManager<CancellationRight1Code,ICancellationRight1CodeDropdownRow,CancellationRight1CodeDropdownRow>
{
    public CancellationRight1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancellationRight1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}