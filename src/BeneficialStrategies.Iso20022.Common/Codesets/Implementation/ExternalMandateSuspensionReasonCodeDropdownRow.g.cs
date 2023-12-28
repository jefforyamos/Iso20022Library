﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalMandateSuspensionReasonCode.  ISO2002 ID# _Kipi0PS8EeiAX8EjdnKKRw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalMandateSuspensionReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalMandateSuspensionReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Kipi0PS8EeiAX8EjdnKKRw")]
public partial class ExternalMandateSuspensionReasonCodeDropdownRow : EnumMetadataItem<ExternalMandateSuspensionReasonCode>, IExternalMandateSuspensionReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalMandateSuspensionReasonCodeDropdownRow(ExternalMandateSuspensionReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}