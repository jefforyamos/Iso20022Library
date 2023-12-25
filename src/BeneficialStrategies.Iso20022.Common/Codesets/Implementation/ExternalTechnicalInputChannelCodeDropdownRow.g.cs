﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalTechnicalInputChannelCode.  ISO2002 ID# _d3jk8Lf9Eee9KIDjEHK7ZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the technical input channel, as published in an external technical input channel code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalTechnicalInputChannelCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalTechnicalInputChannelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_d3jk8Lf9Eee9KIDjEHK7ZQ")]
public partial class ExternalTechnicalInputChannelCodeDropdownRow : EnumMetadataItem<ExternalTechnicalInputChannelCode>, IExternalTechnicalInputChannelCodeDropdownRow
{
    /// <summary>
    /// Specifies the technical input channel, as published in an external technical input channel code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalTechnicalInputChannelCodeDropdownRow(ExternalTechnicalInputChannelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
