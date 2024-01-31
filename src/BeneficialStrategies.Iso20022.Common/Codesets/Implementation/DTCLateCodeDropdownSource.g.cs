﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCLateCode.  ISO2002 ID# _1puekzL3EeKU9IrkkToqcw_1613949680.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies late announcements: wither the announcement was made before or after position capture.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCLateCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1puekzL3EeKU9IrkkToqcw_1613949680")]
public partial class DTCLateCodeDropdownSource : EnumMetadataManager<DTCLateCode,IDTCLateCodeDropdownRow,DTCLateCodeDropdownRow>
{
    public DTCLateCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCLateCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
