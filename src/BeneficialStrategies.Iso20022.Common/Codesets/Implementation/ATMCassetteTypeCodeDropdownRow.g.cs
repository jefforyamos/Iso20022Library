﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMCassetteTypeCode.  ISO2002 ID# _W-ddQIqfEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cassette.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMCassetteTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IATMCassetteTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_W-ddQIqfEeS4a4abTJTSSw")]
public partial class ATMCassetteTypeCodeDropdownRow : EnumMetadataItem<ATMCassetteTypeCode>, IATMCassetteTypeCodeDropdownRow
{
    /// <summary>
    /// Type of cassette.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMCassetteTypeCodeDropdownRow(ATMCassetteTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}