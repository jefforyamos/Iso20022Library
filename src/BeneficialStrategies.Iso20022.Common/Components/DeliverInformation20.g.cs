﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliverInformation20.  ISO2002 ID# _DdRakZEHEem7fvtoGpNpow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record DeliverInformation20
     : IIsoXmlSerilizable<DeliverInformation20>
{
    #nullable enable
    
    /// <summary>
    /// Party that delivers (transferor) securities to the receiving agent (transferee).
    /// </summary>
    public PartyIdentification139? Transferor { get; init; } 
    /// <summary>
    /// Account from which the securities are to be delivered.
    /// </summary>
    public Account31? TransferorRegisteredAccount { get; init; } 
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    public Intermediary43? IntermediaryInformation { get; init; } 
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    /// <summary>
    /// Date used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedTradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Specifies if the settlement amount includes the stamp duty amount.
    /// </summary>
    public StampDutyType2Code? StampDuty { get; init; } 
    /// <summary>
    /// Deal amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    public Fees2? Fees { get; init; } 
    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    public Tax38? IndividualTax { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    public ForeignExchangeTerms37? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    public FundSettlementParameters15? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    
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
        if (Transferor is PartyIdentification139 TransferorValue)
        {
            writer.WriteStartElement(null, "Trfr", xmlNamespace );
            TransferorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferorRegisteredAccount is Account31 TransferorRegisteredAccountValue)
        {
            writer.WriteStartElement(null, "TrfrRegdAcct", xmlNamespace );
            TransferorRegisteredAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryInformation is Intermediary43 IntermediaryInformationValue)
        {
            writer.WriteStartElement(null, "IntrmyInf", xmlNamespace );
            IntermediaryInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DematerialisedIndicator is IsoYesNoIndicator DematerialisedIndicatorValue)
        {
            writer.WriteStartElement(null, "DmtrlsdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DematerialisedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference2Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BeneficiaryCertificationCompletion is BeneficiaryCertificationCompletion1Code BeneficiaryCertificationCompletionValue)
        {
            writer.WriteStartElement(null, "BnfcryCertfctnCmpltn", xmlNamespace );
            writer.WriteValue(BeneficiaryCertificationCompletionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedTradeDate is IsoISODate RequestedTradeDateValue)
        {
            writer.WriteStartElement(null, "ReqdTradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedTradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (RequestedSettlementDate is IsoISODate RequestedSettlementDateValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EffectiveSettlementDate is DateAndDateTime2Choice_ EffectiveSettlementDateValue)
        {
            writer.WriteStartElement(null, "FctvSttlmDt", xmlNamespace );
            EffectiveSettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is IsoActiveCurrencyAndAmount SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SettlementAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (StampDuty is StampDutyType2Code StampDutyValue)
        {
            writer.WriteStartElement(null, "StmpDty", xmlNamespace );
            writer.WriteValue(StampDutyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NetAmount is IsoActiveCurrencyAndAmount NetAmountValue)
        {
            writer.WriteStartElement(null, "NetAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Fees is Fees2 FeesValue)
        {
            writer.WriteStartElement(null, "Fees", xmlNamespace );
            FeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IndividualTax is Tax38 IndividualTaxValue)
        {
            writer.WriteStartElement(null, "IndvTax", xmlNamespace );
            IndividualTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms37 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementPartiesDetails is FundSettlementParameters15 SettlementPartiesDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmPtiesDtls", xmlNamespace );
            SettlementPartiesDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PhysicalTransfer is PhysicalTransferType1Code PhysicalTransferValue)
        {
            writer.WriteStartElement(null, "PhysTrf", xmlNamespace );
            writer.WriteValue(PhysicalTransferValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PhysicalTransferDetails is DeliveryParameters4 PhysicalTransferDetailsValue)
        {
            writer.WriteStartElement(null, "PhysTrfDtls", xmlNamespace );
            PhysicalTransferDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClientReference is AdditionalReference10 ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            ClientReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DeliverInformation20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
