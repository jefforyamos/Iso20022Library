﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferStatusTypeCode.  ISO2002 ID# _RqsCgFNYEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of transfer status or transfer event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RqsCgFNYEeijdq8ilaxyOA")]
[Description(@"Specifies a type of transfer status or transfer event.")]
[Derivations(typeof(TransferStatusType1Code),typeof(TransferStatusType2Code))]
// External derivations that should be provided by the proper interface are: 
public enum TransferStatusTypeCode
{
    /// <summary>
    /// Status report is sent in response to an account holding information request.
    /// Encoded/decoded by serializers as "S019".
    /// </summary>
    [EnumMember(Value = "S019")]
    [IsoId("_WVIYYFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to an account holding information request.")]
    AccountHoldingInformationRequest,
    
    /// <summary>
    /// Status report is sent in response to a portfolio transfer instruction.
    /// Encoded/decoded by serializers as "S012".
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_YfySEFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a portfolio transfer instruction.")]
    PortfolioTransferInstruction,
    
    /// <summary>
    /// Status report is sent in response to a transfer-out instruction.
    /// Encoded/decoded by serializers as "S001".
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_geE-UFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a transfer-out instruction.")]
    TransferOutInstruction,
    
    /// <summary>
    /// Status report is sent in response to a transfer-in instruction.
    /// Encoded/decoded by serializers as "S005".
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_nru30FNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a transfer-in instruction.")]
    TransferInInstruction,
    
    /// <summary>
    /// Status report advises one or more drawdowns.
    /// Encoded/decoded by serializers as "DRAW".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_rZUj4FNYEeijdq8ilaxyOA")]
    [Description(@"Status report advises one or more drawdowns.")]
    Drawdown,
    
    /// <summary>
    /// Status report advises one or more Benefit Crystallisation Events (BCE) have occurred.
    /// Encoded/decoded by serializers as "BCEV".
    /// </summary>
    [EnumMember(Value = "BCEV")]
    [IsoId("_tvbfoFNYEeijdq8ilaxyOA")]
    [Description(@"Status report advises one or more Benefit Crystallisation Events (BCE) have occurred.")]
    BenefitCrystallisationEvent,
    
    /// <summary>
    /// Status report advises cash is or has been instructed.
    /// Encoded/decoded by serializers as "PAYA".
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_VzEPYFUUEeiQFOf5GRHqeQ")]
    [Description(@"Status report advises cash is or has been instructed.")]
    PaymentAdvice,
    
    /// <summary>
    /// Status report is sent to provide information required for a CSD or ICSD settlement leg.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_HuLkYOi5EeifCsigq7uLaQ")]
    [Description(@"Status report is sent to provide information required for a CSD or ICSD settlement leg.")]
    CSDorICSDSettlementInformation,
    
    /// <summary>
    /// Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as "STAT".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_XKONINydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status.")]
    Status,
    
    /// <summary>
    /// Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_p16QMNydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status.")]
    Information,
    
    /// <summary>
    /// Status report is sent to provide the number of units following a conversion.
    /// Encoded/decoded by serializers as "CONV".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_7XAr0G-PEeuEaaCd4BkUFQ")]
    [Description(@"Status report is sent to provide the number of units following a conversion.")]
    ConversionStatus,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferStatusTypeCodeMetadataExtensions
{
    private static readonly TransferStatusTypeCodeDropdownSource _dropdownSource = new TransferStatusTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferStatusTypeCodeDropdownRow GetMetadata(this TransferStatusTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


