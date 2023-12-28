﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestigatedPartiesCode.  ISO2002 ID# _2BtERU4-EeGFgOSp_IATnQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the investigated parties.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestigatedPartiesCodeDropdownSource"/>.
/// Implements <seealso cref="IInvestigatedPartiesCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2BtERU4-EeGFgOSp_IATnQ")]
public partial class InvestigatedPartiesCodeDropdownRow : EnumMetadataItem<InvestigatedPartiesCode>, IInvestigatedPartiesCodeDropdownRow
{
    /// <summary>
    /// Specifies the investigated parties.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestigatedPartiesCodeDropdownRow(InvestigatedPartiesCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}