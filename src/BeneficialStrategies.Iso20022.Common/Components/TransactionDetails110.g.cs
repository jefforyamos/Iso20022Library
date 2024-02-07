﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails110.  ISO2002 ID# _vE74e832Eee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record TransactionDetails110
     : IIsoXmlSerilizable<TransactionDetails110>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TradeIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification119? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount30 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace2? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required Quantity10Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection67? SettlementAmount { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the Sender expects the settlement amount to be credited or debited.
    /// </summary>
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate32Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate9Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    public required SettlementDetails160 SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties49? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties49? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification110? Investor { get; init; } 
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentification111? QualifiedForeignIntermediary { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (TradeIdentification is IsoRestrictedFINXMax16Text TradeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TradeIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoRestrictedFINXMax16Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(PoolIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoRestrictedFINXMax16Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(CorporateActionEventIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralTransactionIdentification is IsoRestrictedFINXMax16Text TripartyAgentServiceProviderCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyAgentServiceProviderCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientTripartyCollateralTransactionIdentification is IsoRestrictedFINXMax16Text ClientTripartyCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntTrptyCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientTripartyCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralInstructionIdentification is IsoRestrictedFINXMax16Text ClientCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralInstructionIdentification is IsoRestrictedFINXMax16Text TripartyAgentServiceProviderCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyAgentServiceProviderCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification119 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SafekeepingPlace is SafeKeepingPlace2 SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is PlaceOfTradeIdentification2 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfClearing is PlaceOfClearingIdentification1 PlaceOfClearingValue)
        {
            writer.WriteStartElement(null, "PlcOfClr", xmlNamespace );
            PlaceOfClearingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmQty", xmlNamespace );
        SettlementQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementAmount is AmountAndDirection67 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LateDeliveryDate is DateAndDateTime2Choice_ LateDeliveryDateValue)
        {
            writer.WriteStartElement(null, "LateDlvryDt", xmlNamespace );
            LateDeliveryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedSettlementDate is DateAndDateTime2Choice_ ExpectedSettlementDateValue)
        {
            writer.WriteStartElement(null, "XpctdSttlmDt", xmlNamespace );
            ExpectedSettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedValueDate is DateAndDateTime2Choice_ ExpectedValueDateValue)
        {
            writer.WriteStartElement(null, "XpctdValDt", xmlNamespace );
            ExpectedValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TradeDate is TradeDate9Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcknowledgedStatusTimeStamp is IsoISODateTime AcknowledgedStatusTimeStampValue)
        {
            writer.WriteStartElement(null, "AckdStsTmStmp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(AcknowledgedStatusTimeStampValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (MatchedStatusTimeStamp is IsoISODateTime MatchedStatusTimeStampValue)
        {
            writer.WriteStartElement(null, "MtchdStsTmStmp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(MatchedStatusTimeStampValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
        SettlementParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ReceivingSettlementParties is SettlementParties49 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties49 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Investor is PartyIdentification110 InvestorValue)
        {
            writer.WriteStartElement(null, "Invstr", xmlNamespace );
            InvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QualifiedForeignIntermediary is PartyIdentification111 QualifiedForeignIntermediaryValue)
        {
            writer.WriteStartElement(null, "QlfdFrgnIntrmy", xmlNamespace );
            QualifiedForeignIntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementInstructionProcessingAdditionalDetails is IsoRestrictedFINXMax350Text SettlementInstructionProcessingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmInstrPrcgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(SettlementInstructionProcessingAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransactionDetails110 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
