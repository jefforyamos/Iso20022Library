﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UndertakingStatus1Code.  ISO2002 ID# _IWcDAHymEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the undertaking transaction status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UndertakingStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IUndertakingStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IWcDAHymEeGWJuGCfvwOsQ")]
public partial class UndertakingStatus1CodeDropdownRow : EnumMetadataItem<UndertakingStatus1Code>, IUndertakingStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the undertaking transaction status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UndertakingStatus1CodeDropdownRow(UndertakingStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
