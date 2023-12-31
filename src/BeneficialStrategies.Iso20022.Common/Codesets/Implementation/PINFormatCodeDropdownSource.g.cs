﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PINFormatCode.  ISO2002 ID# _TVCuCwEcEeCQm6a_G2yO_w_1593903666.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// PIN (Personal Identification Number) format used to encrypt the PIN block.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPINFormatCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVCuCwEcEeCQm6a_G2yO_w_1593903666")]
public partial class PINFormatCodeDropdownSource : EnumMetadataManager<PINFormatCode,IPINFormatCodeDropdownRow,PINFormatCodeDropdownRow>
{
    public PINFormatCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PINFormatCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
