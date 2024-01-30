﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerProtocolParameters3.  ISO2002 ID# _X2K2sR3kEeKWfegf-2AeBQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
public partial record AcquirerProtocolParameters3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    public GenericIdentification32? AcquirerIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    public IsoMax35Text? ApplicationIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    public AcquirerHostConfiguration2? Host { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    public AcquirerProtocolParameters4? OnLineTransaction { get; init; } 
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    public AcquirerProtocolParameters4? OffLineTransaction { get; init; } 
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    public ExchangeConfiguration2? ReconciliationExchange { get; init; } 
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these informations are present in the transactions.
    /// </summary>
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 
    /// <summary>
    /// Indicates that response messages and an AcceptorCompletionAdvice message following an authorisation exchange must contain protected or plain card data.
    /// </summary>
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    public BatchTransactionType1Code? BatchTransferContent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    public MessageItemCondition1? MessageItem { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    
    #nullable disable
}
