﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PINEntrySecurityCharacteristic1Code.  ISO2002 ID# _8axYUKH3EeuiuNcvKhXmNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the security characteristic of the PIN entry device.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPINEntrySecurityCharacteristic1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8axYUKH3EeuiuNcvKhXmNQ")]
public partial class PINEntrySecurityCharacteristic1CodeDropdownSource : EnumMetadataManager<PINEntrySecurityCharacteristic1Code,IPINEntrySecurityCharacteristic1CodeDropdownRow,PINEntrySecurityCharacteristic1CodeDropdownRow>
{
    public PINEntrySecurityCharacteristic1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PINEntrySecurityCharacteristic1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
