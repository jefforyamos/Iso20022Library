﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDebtorActivationCancellationReason1Code.  ISO2002 ID# _90jEy_GAEemQ7oqCO5NTQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90jEy_GAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDebtorActivationCancellationReasonCode))]
public enum ExternalDebtorActivationCancellationReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvBsMvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as "NotUniqueReference".
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvBsNfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as "RegulatoryReason".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvK2IvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as "TechnicalRejection".
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uvK2JfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as "UnknownCreditor".
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uvUnIvRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDebtorActivationCancellationReason1CodeMetadataExtensions
{
    private static readonly ExternalDebtorActivationCancellationReason1CodeDropdownSource _dropdownSource = new ExternalDebtorActivationCancellationReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDebtorActivationCancellationReason1CodeDropdownRow GetMetadata(this ExternalDebtorActivationCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


