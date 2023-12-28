﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RemittanceLocationMethod1Code.  ISO2002 ID# _ZsOLt9p-Ed-ak6NoX_4Aeg_91898271.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RemittanceLocationMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="IRemittanceLocationMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZsOLt9p-Ed-ak6NoX_4Aeg_91898271")]
public partial class RemittanceLocationMethod1CodeDropdownRow : EnumMetadataItem<RemittanceLocationMethod1Code>, IRemittanceLocationMethod1CodeDropdownRow
{
    /// <summary>
    /// Specifies the method used to deliver the remittance advice information.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RemittanceLocationMethod1CodeDropdownRow(RemittanceLocationMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
