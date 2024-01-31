﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AgreementItemAction1Code.  ISO2002 ID# _OTgzMjc5-AOSNFX-8224496.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of action concerning registration information.
/// The default value is OPEN.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AgreementItemAction1CodeDropdownSource"/>.
/// Implements <seealso cref="IAgreementItemAction1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OTgzMjc5-AOSNFX-8224496")]
public partial class AgreementItemAction1CodeDropdownRow : EnumMetadataItem<AgreementItemAction1Code>, IAgreementItemAction1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of action concerning registration information.
    /// The default value is OPEN.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AgreementItemAction1CodeDropdownRow(AgreementItemAction1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
