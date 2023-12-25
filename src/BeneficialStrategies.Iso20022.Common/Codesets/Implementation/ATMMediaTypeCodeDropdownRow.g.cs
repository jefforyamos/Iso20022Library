﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMMediaTypeCode.  ISO2002 ID# _jtniYIqdEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or category of media inside an ATM cassette.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMMediaTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IATMMediaTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jtniYIqdEeS4a4abTJTSSw")]
public partial class ATMMediaTypeCodeDropdownRow : EnumMetadataItem<ATMMediaTypeCode>, IATMMediaTypeCodeDropdownRow
{
    /// <summary>
    /// Type or category of media inside an ATM cassette.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMMediaTypeCodeDropdownRow(ATMMediaTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
