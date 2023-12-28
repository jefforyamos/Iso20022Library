﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OpeningClosing1Code.  ISO2002 ID# _aOytRtp-Ed-ak6NoX_4Aeg_1505902353.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information relative to the processing of the trade.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOpeningClosing1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOytRtp-Ed-ak6NoX_4Aeg_1505902353")]
public partial class OpeningClosing1CodeDropdownSource : EnumMetadataManager<OpeningClosing1Code,IOpeningClosing1CodeDropdownRow,OpeningClosing1CodeDropdownRow>
{
    public OpeningClosing1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OpeningClosing1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
