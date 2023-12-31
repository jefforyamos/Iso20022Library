﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalBillingRateIdentification1Code.  ISO2002 ID# _6WzSlpqlEeGSON8vddiWzQ_1145255535.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalBillingRateIdentification1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalBillingRateIdentification1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WzSlpqlEeGSON8vddiWzQ_1145255535")]
public partial class ExternalBillingRateIdentification1CodeDropdownRow : EnumMetadataItem<ExternalBillingRateIdentification1Code>, IExternalBillingRateIdentification1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalBillingRateIdentification1CodeDropdownRow(ExternalBillingRateIdentification1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
