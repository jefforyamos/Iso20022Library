﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GDPRDataConsent1Code.  ISO2002 ID# _SQd7EJTWEemC09f0MxYkRg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GDPRDataConsent1CodeDropdownSource"/>.
/// Implements <seealso cref="IGDPRDataConsent1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SQd7EJTWEemC09f0MxYkRg")]
public partial class GDPRDataConsent1CodeDropdownRow : EnumMetadataItem<GDPRDataConsent1Code>, IGDPRDataConsent1CodeDropdownRow
{
    /// <summary>
    /// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GDPRDataConsent1CodeDropdownRow(GDPRDataConsent1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
