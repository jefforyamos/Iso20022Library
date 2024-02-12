﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerProtocolParameters4.  ISO2002 ID# _tiYEcR3kEeKWfegf-2AeBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_tiYEcR3kEeKWfegf-2AeBQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acquirer Protocol Parameters")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerProtocolParameters4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerProtocolParameters4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerProtocolParameters4( FinancialCapture1Code reqFinancialCapture )
    {
        FinancialCapture = reqFinancialCapture;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_tuRycR3kEeKWfegf-2AeBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Capture")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialCapture1Code FinancialCapture { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialCapture1Code FinancialCapture { get; init; } 
    #else
    public FinancialCapture1Code FinancialCapture { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_tuRydR3kEeKWfegf-2AeBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Batch Transfer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration2? BatchTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration2? BatchTransfer { get; init; } 
    #else
    public ExchangeConfiguration2? BatchTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_tuRyeR3kEeKWfegf-2AeBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Completion Exchange")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration3? CompletionExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration3? CompletionExchange { get; init; } 
    #else
    public ExchangeConfiguration3? CompletionExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_dHz9MB3pEeKWfegf-2AeBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Exchange")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationProcess1Code? CancellationExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationProcess1Code? CancellationExchange { get; init; } 
    #else
    public CancellationProcess1Code? CancellationExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
