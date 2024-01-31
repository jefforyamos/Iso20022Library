﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalInformationType1Code.  ISO2002 ID# _TRd1lwEcEeCQm6a_G2yO_w_1586827309.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the information type, as published in an external information type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalInformationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalInformationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRd1lwEcEeCQm6a_G2yO_w_1586827309")]
public partial class ExternalInformationType1CodeDropdownRow : EnumMetadataItem<ExternalInformationType1Code>, IExternalInformationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the information type, as published in an external information type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalInformationType1CodeDropdownRow(ExternalInformationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
