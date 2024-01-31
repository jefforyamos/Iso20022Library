﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalChannelCode.  ISO2002 ID# _-M07AW7iEeKo25nLKvGr8w_1800475441.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalChannelCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalChannelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07AW7iEeKo25nLKvGr8w_1800475441")]
public partial class ExternalChannelCodeDropdownRow : EnumMetadataItem<ExternalChannelCode>, IExternalChannelCodeDropdownRow
{
    /// <summary>
    /// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalChannelCodeDropdownRow(ExternalChannelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
