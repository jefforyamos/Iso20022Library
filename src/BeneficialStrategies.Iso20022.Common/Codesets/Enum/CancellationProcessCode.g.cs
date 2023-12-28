﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationProcessCode.  ISO2002 ID# _w2PhkB3nEeKWfegf-2AeBQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Configuration of the exchanges to perform the cancellation of a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w2PhkB3nEeKWfegf-2AeBQ")]
[Description(@"Configuration of the exchanges to perform the cancellation of a payment transaction.")]
public enum CancellationProcessCode
{
    /// <summary>
    /// Card payment transaction cannot be cancelled by the acquirer.
    /// Encoded/decoded by serializers as "NALW".
    /// </summary>
    [EnumMember(Value = "NALW")]
    [IsoId("_DapQ4B3oEeKWfegf-2AeBQ")]
    [Description(@"Card payment transaction cannot be cancelled by the acquirer.")]
    NotAllowed,
    
    /// <summary>
    /// Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch.
    /// Encoded/decoded by serializers as "ADVC".
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_H72yQB3oEeKWfegf-2AeBQ")]
    [Description(@"Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch.")]
    Advice,
    
    /// <summary>
    /// Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required.
    /// Encoded/decoded by serializers as "REQU".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_LWaNkB3oEeKWfegf-2AeBQ")]
    [Description(@"Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required.")]
    Request,
    
    /// <summary>
    /// Cancellation of the Card payment transaction is defined by the payment application.
    /// Encoded/decoded by serializers as "APPL".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_0TOPwAxsEeqdx6buGpCCQw")]
    [Description(@"Cancellation of the Card payment transaction is defined by the payment application.")]
    ApplicationLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationProcessCodeMetadataExtensions
{
    private static readonly CancellationProcessCodeDropdownSource _dropdownSource = new CancellationProcessCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationProcessCodeDropdownRow GetMetadata(this CancellationProcessCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


