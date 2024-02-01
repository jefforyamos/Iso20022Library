﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerProtocolParameters12.  ISO2002 ID# _IeZq4dX2Eeia9rtBTv_9KA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
public partial record AcquirerProtocolParameters12
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    public GenericIdentification53[] AcquirerIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    public IsoMax35Text[] ApplicationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    public AcquirerHostConfiguration6[] Host { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    public AcquirerProtocolParameters8? OnLineTransaction { get; init; } 
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    public AcquirerProtocolParameters8? OffLineTransaction { get; init; } 
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    public ExchangeConfiguration6? ReconciliationExchange { get; init; } 
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these information are present in the transactions.
    /// </summary>
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 
    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    public IsoTrueFalseIndicator? ReconciliationError { get; init; } 
    /// <summary>
    /// Indicates whether the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 
    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; } 
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    public BatchTransactionType1Code[] BatchTransferContent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; } 
    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; } 
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    public MessageItemCondition1[] MessageItem { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    public IsoTrueFalseIndicator? PrivateCardData { get; init; } 
    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; } 
    
    #nullable disable
}
