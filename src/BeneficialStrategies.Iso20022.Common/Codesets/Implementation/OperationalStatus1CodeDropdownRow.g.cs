﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OperationalStatus1Code.  ISO2002 ID# _EwU6kCDZEeWCLu74WLgP4w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the operational status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OperationalStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IOperationalStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EwU6kCDZEeWCLu74WLgP4w")]
public partial class OperationalStatus1CodeDropdownRow : EnumMetadataItem<OperationalStatus1Code>, IOperationalStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the operational status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OperationalStatus1CodeDropdownRow(OperationalStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
