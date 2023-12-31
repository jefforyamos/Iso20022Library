﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CSCManagementCode.  ISO2002 ID# _TWii4QEcEeCQm6a_G2yO_w_1480882734.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CSCManagementCodeDropdownSource"/>.
/// Implements <seealso cref="ICSCManagementCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWii4QEcEeCQm6a_G2yO_w_1480882734")]
public partial class CSCManagementCodeDropdownRow : EnumMetadataItem<CSCManagementCode>, ICSCManagementCodeDropdownRow
{
    /// <summary>
    /// CSC (Card Security Code) management associated with the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CSCManagementCodeDropdownRow(CSCManagementCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
