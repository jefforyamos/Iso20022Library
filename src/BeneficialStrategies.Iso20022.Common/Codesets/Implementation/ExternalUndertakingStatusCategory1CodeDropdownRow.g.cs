﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalUndertakingStatusCategory1Code.  ISO2002 ID# _-MrKBG7iEeKo25nLKvGr8w_-479292299.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalUndertakingStatusCategory1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalUndertakingStatusCategory1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MrKBG7iEeKo25nLKvGr8w_-479292299")]
public partial class ExternalUndertakingStatusCategory1CodeDropdownRow : EnumMetadataItem<ExternalUndertakingStatusCategory1Code>, IExternalUndertakingStatusCategory1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalUndertakingStatusCategory1CodeDropdownRow(ExternalUndertakingStatusCategory1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
