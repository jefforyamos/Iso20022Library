﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Status1Code.  ISO2002 ID# _Vp1UUNp-Ed-ak6NoX_4Aeg_358546610.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Status1CodeDropdownSource"/>.
/// Implements <seealso cref="IStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp1UUNp-Ed-ak6NoX_4Aeg_358546610")]
public partial class Status1CodeDropdownRow : EnumMetadataItem<Status1Code>, IStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Status1CodeDropdownRow(Status1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
