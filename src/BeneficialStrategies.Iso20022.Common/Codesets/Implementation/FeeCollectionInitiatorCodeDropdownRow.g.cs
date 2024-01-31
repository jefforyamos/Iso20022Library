﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FeeCollectionInitiatorCode.  ISO2002 ID# _9YEBsCxJEeyg-aG5nXcnfg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the initiator of the fee collection message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FeeCollectionInitiatorCodeDropdownSource"/>.
/// Implements <seealso cref="IFeeCollectionInitiatorCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9YEBsCxJEeyg-aG5nXcnfg")]
public partial class FeeCollectionInitiatorCodeDropdownRow : EnumMetadataItem<FeeCollectionInitiatorCode>, IFeeCollectionInitiatorCodeDropdownRow
{
    /// <summary>
    /// Specifies the initiator of the fee collection message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FeeCollectionInitiatorCodeDropdownRow(FeeCollectionInitiatorCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
