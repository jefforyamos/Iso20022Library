﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CSCResultCode.  ISO2002 ID# _TWrswwEcEeCQm6a_G2yO_w_-323244249.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the printed CSC (Card Security Code) validation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CSCResultCodeDropdownSource"/>.
/// Implements <seealso cref="ICSCResultCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWrswwEcEeCQm6a_G2yO_w_-323244249")]
public partial class CSCResultCodeDropdownRow : EnumMetadataItem<CSCResultCode>, ICSCResultCodeDropdownRow
{
    /// <summary>
    /// Result of the printed CSC (Card Security Code) validation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CSCResultCodeDropdownRow(CSCResultCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
