﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AdditionalServiceTypeCode.  ISO2002 ID# _vnuScBZZEeiwvuY-sPnsNg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of additional service
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AdditionalServiceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAdditionalServiceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vnuScBZZEeiwvuY-sPnsNg")]
public partial class AdditionalServiceTypeCodeDropdownRow : EnumMetadataItem<AdditionalServiceTypeCode>, IAdditionalServiceTypeCodeDropdownRow
{
    /// <summary>
    /// Type of additional service
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AdditionalServiceTypeCodeDropdownRow(AdditionalServiceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
