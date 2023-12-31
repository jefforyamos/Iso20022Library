﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RemittanceLocationMethodCode.  ISO2002 ID# _ZshGodp-Ed-ak6NoX_4Aeg_-702329779.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RemittanceLocationMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IRemittanceLocationMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZshGodp-Ed-ak6NoX_4Aeg_-702329779")]
public partial class RemittanceLocationMethodCodeDropdownRow : EnumMetadataItem<RemittanceLocationMethodCode>, IRemittanceLocationMethodCodeDropdownRow
{
    /// <summary>
    /// Specifies the method used to deliver the remittance advice information.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RemittanceLocationMethodCodeDropdownRow(RemittanceLocationMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
