﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResolutionSubStatus1Code.  ISO2002 ID# _RMoRUDUHEe2tRf29bleifQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the sub-status of a resolution. 
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResolutionSubStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IResolutionSubStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RMoRUDUHEe2tRf29bleifQ")]
public partial class ResolutionSubStatus1CodeDropdownRow : EnumMetadataItem<ResolutionSubStatus1Code>, IResolutionSubStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the sub-status of a resolution. 
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResolutionSubStatus1CodeDropdownRow(ResolutionSubStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
