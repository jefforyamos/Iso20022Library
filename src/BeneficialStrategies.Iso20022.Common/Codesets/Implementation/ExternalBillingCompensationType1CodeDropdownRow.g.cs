﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalBillingCompensationType1Code.  ISO2002 ID# _6WzSl5qlEeGSON8vddiWzQ_882310239.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalBillingCompensationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalBillingCompensationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WzSl5qlEeGSON8vddiWzQ_882310239")]
public partial class ExternalBillingCompensationType1CodeDropdownRow : EnumMetadataItem<ExternalBillingCompensationType1Code>, IExternalBillingCompensationType1CodeDropdownRow
{
    /// <summary>
    /// Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalBillingCompensationType1CodeDropdownRow(ExternalBillingCompensationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
