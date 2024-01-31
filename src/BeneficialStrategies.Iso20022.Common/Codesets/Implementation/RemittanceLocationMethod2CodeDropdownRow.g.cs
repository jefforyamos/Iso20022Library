﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RemittanceLocationMethod2Code.  ISO2002 ID# _ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RemittanceLocationMethod2CodeDropdownSource"/>.
/// Implements <seealso cref="IRemittanceLocationMethod2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090")]
public partial class RemittanceLocationMethod2CodeDropdownRow : EnumMetadataItem<RemittanceLocationMethod2Code>, IRemittanceLocationMethod2CodeDropdownRow
{
    /// <summary>
    /// Specifies the method used to deliver the remittance advice information.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RemittanceLocationMethod2CodeDropdownRow(RemittanceLocationMethod2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
