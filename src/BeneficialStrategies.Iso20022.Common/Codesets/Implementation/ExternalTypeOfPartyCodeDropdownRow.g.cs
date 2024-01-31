﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalTypeOfPartyCode.  ISO2002 ID# _-MYPFW7iEeKo25nLKvGr8w_-77531611.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalTypeOfPartyCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalTypeOfPartyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MYPFW7iEeKo25nLKvGr8w_-77531611")]
public partial class ExternalTypeOfPartyCodeDropdownRow : EnumMetadataItem<ExternalTypeOfPartyCode>, IExternalTypeOfPartyCodeDropdownRow
{
    /// <summary>
    /// Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalTypeOfPartyCodeDropdownRow(ExternalTypeOfPartyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
