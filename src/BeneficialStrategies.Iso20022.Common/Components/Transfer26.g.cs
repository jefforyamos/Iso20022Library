﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer26.  ISO2002 ID# _3GogcRgnEeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
public partial record Transfer26
     : IIsoXmlSerilizable<Transfer26>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference2? CounterpartyReference { get; init; } 
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    public IsoISODate? TransferOrderDateForm { get; init; } 
    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// </summary>
    public TransferReason1? TransferReason { get; init; } 
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    public Unit3? UnitsDetails { get; init; } 
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    public CurrencyCode? TransferCurrency { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "TrfConfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferConfirmationReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TrfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CounterpartyReference is AdditionalReference2 CounterpartyReferenceValue)
        {
            writer.WriteStartElement(null, "CtrPtyRef", xmlNamespace );
            CounterpartyReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FctvTrfDt", xmlNamespace );
        EffectiveTransferDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RequestedSettlementDate is IsoISODate RequestedSettlementDateValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EffectiveSettlementDate is DateAndDateTimeChoice_ EffectiveSettlementDateValue)
        {
            writer.WriteStartElement(null, "FctvSttlmDt", xmlNamespace );
            EffectiveSettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is DateAndDateTimeChoice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferOrderDateForm is IsoISODate TransferOrderDateFormValue)
        {
            writer.WriteStartElement(null, "TrfOrdrDtForm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TransferOrderDateFormValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TransferReason is TransferReason1 TransferReasonValue)
        {
            writer.WriteStartElement(null, "TrfRsn", xmlNamespace );
            TransferReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "HldgsPlanTp", xmlNamespace );
        writer.WriteValue(HoldingsPlanType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlUnitsNb", xmlNamespace );
        TotalUnitsNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UnitsDetails is Unit3 UnitsDetailsValue)
        {
            writer.WriteStartElement(null, "UnitsDtls", xmlNamespace );
            UnitsDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AveragePrice is IsoActiveOrHistoricCurrencyAnd13DecimalAmount AveragePriceValue)
        {
            writer.WriteStartElement(null, "AvrgPric", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd13DecimalAmount(AveragePriceValue)); // data type ActiveOrHistoricCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TransferCurrency is CurrencyCode TransferCurrencyValue)
        {
            writer.WriteStartElement(null, "TrfCcy", xmlNamespace );
            writer.WriteValue(TransferCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OwnAccountTransferIndicator is IsoYesNoIndicator OwnAccountTransferIndicatorValue)
        {
            writer.WriteStartElement(null, "OwnAcctTrfInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(OwnAccountTransferIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NonStandardSettlementInformation is IsoMax350Text NonStandardSettlementInformationValue)
        {
            writer.WriteStartElement(null, "NonStdSttlmInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NonStandardSettlementInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (ReceivingAgentDetails is PartyIdentificationAndAccount93 ReceivingAgentDetailsValue)
        {
            writer.WriteStartElement(null, "RcvgAgtDtls", xmlNamespace );
            ReceivingAgentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringAgentDetails is PartyIdentificationAndAccount93 DeliveringAgentDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrgAgtDtls", xmlNamespace );
            DeliveringAgentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transfer26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
