﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCLinkTypeCode.  ISO2002 ID# _1rziMDL3EeKU9IrkkToqcw_1576727948.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies types of linked events.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCLinkTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1rziMDL3EeKU9IrkkToqcw_1576727948")]
public partial class DTCCLinkTypeCodeDropdownSource : EnumMetadataManager<DTCCLinkTypeCode,IDTCCLinkTypeCodeDropdownRow,DTCCLinkTypeCodeDropdownRow>
{
    public DTCCLinkTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCLinkTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
