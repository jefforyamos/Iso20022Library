﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PINRequestType1Code.  ISO2002 ID# _VB20AN7AEeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of PIN Service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PINRequestType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPINRequestType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VB20AN7AEeiwsev40qZGEQ")]
public partial class PINRequestType1CodeDropdownRow : EnumMetadataItem<PINRequestType1Code>, IPINRequestType1CodeDropdownRow
{
    /// <summary>
    /// Type of PIN Service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PINRequestType1CodeDropdownRow(PINRequestType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
