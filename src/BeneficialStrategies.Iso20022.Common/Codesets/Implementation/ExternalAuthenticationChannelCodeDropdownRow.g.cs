﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalAuthenticationChannelCode.  ISO2002 ID# _gTbMYI8qEeeBmcwCTnMfBg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction authentication channel, as published in an external authentication channel code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalAuthenticationChannelCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalAuthenticationChannelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gTbMYI8qEeeBmcwCTnMfBg")]
public partial class ExternalAuthenticationChannelCodeDropdownRow : EnumMetadataItem<ExternalAuthenticationChannelCode>, IExternalAuthenticationChannelCodeDropdownRow
{
    /// <summary>
    /// Specifies the transaction authentication channel, as published in an external authentication channel code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalAuthenticationChannelCodeDropdownRow(ExternalAuthenticationChannelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
