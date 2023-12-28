﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SWIFTServiceLevel2Code.  ISO2002 ID# _ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code identifying which SWIFT service level applies to the payment instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISWIFTServiceLevel2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378")]
public partial class SWIFTServiceLevel2CodeDropdownSource : EnumMetadataManager<SWIFTServiceLevel2Code,ISWIFTServiceLevel2CodeDropdownRow,SWIFTServiceLevel2CodeDropdownRow>
{
    public SWIFTServiceLevel2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SWIFTServiceLevel2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}