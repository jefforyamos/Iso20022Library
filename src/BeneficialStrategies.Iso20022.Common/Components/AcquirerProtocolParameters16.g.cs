﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerProtocolParameters16.  ISO2002 ID# _HRi7MXDyEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[DataContract]
[XmlType]
public partial record AcquirerProtocolParameters16
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [DataMember]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [DataMember]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [DataMember]
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax35Text> ApplicationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [DataMember]
    public ValueList<AcquirerHostConfiguration9> Host { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [DataMember]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; } 
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [DataMember]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; } 
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [DataMember]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; } 
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 
    /// <summary>
    /// List of criterion to use when totals in reconciliation or batch must be split.
    /// </summary>
    [DataMember]
    public ValueList<ReconciliationCriteria1Code> SplitTotalCriteria { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// To notify that the acquirer expect to receive a completion advice after each update of reservation.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? CompletionAdviceMandated { get; init; } 
    /// <summary>
    /// Identification of available amount qualifier for a reservation. 
    /// </summary>
    [DataMember]
    public ValueList<TypeOfAmount8Code> AmountQualifierForReservation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; } 
    /// <summary>
    /// Indicates whether the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 
    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; } 
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [DataMember]
    public ValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; } 
    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; } 
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [DataMember]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; } 
    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; } 
    
    #nullable disable
}
