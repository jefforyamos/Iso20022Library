﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CSCManagement1Code.  ISO2002 ID# _TS9qYQEcEeCQm6a_G2yO_w_-804127704.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CSCManagement1CodeDropdownSource"/>.
/// Implements <seealso cref="ICSCManagement1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TS9qYQEcEeCQm6a_G2yO_w_-804127704")]
public partial class CSCManagement1CodeDropdownRow : EnumMetadataItem<CSCManagement1Code>, ICSCManagement1CodeDropdownRow
{
    /// <summary>
    /// CSC (Card Security Code) management associated with the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CSCManagement1CodeDropdownRow(CSCManagement1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}