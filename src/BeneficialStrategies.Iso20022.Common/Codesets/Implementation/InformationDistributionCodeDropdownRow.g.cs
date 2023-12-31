﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InformationDistributionCode.  ISO2002 ID# _-jTPExOBEeKjmvxNCObNeQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how information is to be distributed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InformationDistributionCodeDropdownSource"/>.
/// Implements <seealso cref="IInformationDistributionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-jTPExOBEeKjmvxNCObNeQ")]
public partial class InformationDistributionCodeDropdownRow : EnumMetadataItem<InformationDistributionCode>, IInformationDistributionCodeDropdownRow
{
    /// <summary>
    /// Specifies how information is to be distributed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InformationDistributionCodeDropdownRow(InformationDistributionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
