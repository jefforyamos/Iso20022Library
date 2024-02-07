﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegulatoryReporting4.  ISO2002 ID# _I6JesTS3EeOW7s4n9SUZ3A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Includes data elements that can be used for reporting to trade repositories, it is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular trade confirmations.
/// </summary>
public partial record RegulatoryReporting4
     : IIsoXmlSerilizable<RegulatoryReporting4>
{
    #nullable enable
    
    /// <summary>
    /// Regulatory transaction reporting information from the Trading Side party.
    /// </summary>
    public TradingSideTransactionReporting1? TradingSideTransactionReporting { get; init; } 
    /// <summary>
    /// Regulatory transaction reporting information from the Counterparty Side party.
    /// </summary>
    public CounterpartySideTransactionReporting1? CounterpartySideTransactionReporting { get; init; } 
    /// <summary>
    /// Identifies an agency or separate corporation of a futures exchange responsible for settling and
    /// clearing trades, collecting and maintaining margins, regulating delivery and reporting trade data. This can also be known as a Central Counterparty (CCP).
    /// </summary>
    public PartyIdentification73Choice_? CentralCounterpartyClearingHouse { get; init; } 
    /// <summary>
    /// Identifies the party that is a member of the clearing house (CCP) and that acts as a liaison between the investor and the Cntral Counterparty (CCP).
    /// </summary>
    public PartyIdentification73Choice_? ClearingBroker { get; init; } 
    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; } 
    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    public IsoMax35Text? ClearedProductIdentification { get; init; } 
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    public IsoMax35Text? ExecutionVenue { get; init; } 
    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    public IsoYesNoIndicator? NonStandardFlag { get; init; } 
    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    public IsoExact42Text? LinkSwapIdentification { get; init; } 
    /// <summary>
    /// Specifies the financial nature of the reporting counterparty.
    /// </summary>
    public IsoYesNoIndicator? FinancialNatureOfTheCounterpartyIndicator { get; init; } 
    /// <summary>
    /// Specifies if the collateral is posted on a portfolio basis.
    /// </summary>
    public IsoYesNoIndicator? CollateralPortfolioIndicator { get; init; } 
    /// <summary>
    /// Identifies the portfolio code to which the trade belongs if the collateral is posted on a portfolio basis (and not trade by trade).
    /// </summary>
    public IsoMax10Text? CollateralPortfolioCode { get; init; } 
    /// <summary>
    /// Indicates if the trade results from portfolio compression.
    /// </summary>
    public IsoYesNoIndicator? PortfolioCompressionIndicator { get; init; } 
    /// <summary>
    /// Specifies the corporate sector of the counterparty.
    /// </summary>
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the counterparty has entered into a trade with a non-European Economic Area (EEA) counterparty that is not subject to the reporting obligation.
    /// </summary>
    public IsoYesNoIndicator? TradeWithNonEEACounterpartyIndicator { get; init; } 
    /// <summary>
    /// To indicate if a reported trade falls under the definition of intragroup transaction, as defined by European Securities and Markets Authority (ESMA) in the Technical Standards.
    /// </summary>
    public IsoYesNoIndicator? IntragroupTradeIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the contract is objectively measurable as directly linked to the non-financial counterparty's commercial or treasury financing activity.
    /// </summary>
    public IsoYesNoIndicator? CommercialOrTreasuryFinancingIndicator { get; init; } 
    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    public IsoMax210Text? AdditionalReportingInformation { get; init; } 
    
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
        if (TradingSideTransactionReporting is TradingSideTransactionReporting1 TradingSideTransactionReportingValue)
        {
            writer.WriteStartElement(null, "TradgSdTxRptg", xmlNamespace );
            TradingSideTransactionReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CounterpartySideTransactionReporting is CounterpartySideTransactionReporting1 CounterpartySideTransactionReportingValue)
        {
            writer.WriteStartElement(null, "CtrPtySdTxRptg", xmlNamespace );
            CounterpartySideTransactionReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CentralCounterpartyClearingHouse is PartyIdentification73Choice_ CentralCounterpartyClearingHouseValue)
        {
            writer.WriteStartElement(null, "CntrlCtrPtyClrHs", xmlNamespace );
            CentralCounterpartyClearingHouseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingBroker is PartyIdentification73Choice_ ClearingBrokerValue)
        {
            writer.WriteStartElement(null, "ClrBrkr", xmlNamespace );
            ClearingBrokerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingExceptionParty is PartyIdentification73Choice_ ClearingExceptionPartyValue)
        {
            writer.WriteStartElement(null, "ClrXcptnPty", xmlNamespace );
            ClearingExceptionPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingBrokerIdentification is ClearingBrokerIdentification1 ClearingBrokerIdentificationValue)
        {
            writer.WriteStartElement(null, "ClrBrkrId", xmlNamespace );
            ClearingBrokerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingThresholdIndicator is IsoYesNoIndicator ClearingThresholdIndicatorValue)
        {
            writer.WriteStartElement(null, "ClrThrshldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ClearingThresholdIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ClearedProductIdentification is IsoMax35Text ClearedProductIdentificationValue)
        {
            writer.WriteStartElement(null, "ClrdPdctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClearedProductIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UnderlyingProductIdentifier is UnderlyingProductIdentifier1Code UnderlyingProductIdentifierValue)
        {
            writer.WriteStartElement(null, "UndrlygPdctIdr", xmlNamespace );
            writer.WriteValue(UnderlyingProductIdentifierValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AllocationIndicator is AllocationIndicator1Code AllocationIndicatorValue)
        {
            writer.WriteStartElement(null, "AllcnInd", xmlNamespace );
            writer.WriteValue(AllocationIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CollateralisationIndicator is CollateralisationIndicator1Code CollateralisationIndicatorValue)
        {
            writer.WriteStartElement(null, "CollstnInd", xmlNamespace );
            writer.WriteValue(CollateralisationIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExecutionVenue is IsoMax35Text ExecutionVenueValue)
        {
            writer.WriteStartElement(null, "ExctnVn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ExecutionVenueValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ExecutionTimestamp is DateAndDateTimeChoice_ ExecutionTimestampValue)
        {
            writer.WriteStartElement(null, "ExctnTmstmp", xmlNamespace );
            ExecutionTimestampValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonStandardFlag is IsoYesNoIndicator NonStandardFlagValue)
        {
            writer.WriteStartElement(null, "NonStdFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NonStandardFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (LinkSwapIdentification is IsoExact42Text LinkSwapIdentificationValue)
        {
            writer.WriteStartElement(null, "LkSwpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact42Text(LinkSwapIdentificationValue)); // data type Exact42Text System.String
            writer.WriteEndElement();
        }
        if (FinancialNatureOfTheCounterpartyIndicator is IsoYesNoIndicator FinancialNatureOfTheCounterpartyIndicatorValue)
        {
            writer.WriteStartElement(null, "FinNtrOfTheCtrPtyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FinancialNatureOfTheCounterpartyIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CollateralPortfolioIndicator is IsoYesNoIndicator CollateralPortfolioIndicatorValue)
        {
            writer.WriteStartElement(null, "CollPrtflInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CollateralPortfolioIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CollateralPortfolioCode is IsoMax10Text CollateralPortfolioCodeValue)
        {
            writer.WriteStartElement(null, "CollPrtflCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10Text(CollateralPortfolioCodeValue)); // data type Max10Text System.String
            writer.WriteEndElement();
        }
        if (PortfolioCompressionIndicator is IsoYesNoIndicator PortfolioCompressionIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtflCmprssnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PortfolioCompressionIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CorporateSectorIndicator is CorporateSectorIdentifier1Code CorporateSectorIndicatorValue)
        {
            writer.WriteStartElement(null, "CorpSctrInd", xmlNamespace );
            writer.WriteValue(CorporateSectorIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TradeWithNonEEACounterpartyIndicator is IsoYesNoIndicator TradeWithNonEEACounterpartyIndicatorValue)
        {
            writer.WriteStartElement(null, "TradWthNonEEACtrPtyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(TradeWithNonEEACounterpartyIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (IntragroupTradeIndicator is IsoYesNoIndicator IntragroupTradeIndicatorValue)
        {
            writer.WriteStartElement(null, "NtrgrpTradInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(IntragroupTradeIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CommercialOrTreasuryFinancingIndicator is IsoYesNoIndicator CommercialOrTreasuryFinancingIndicatorValue)
        {
            writer.WriteStartElement(null, "ComrclOrTrsrFincgInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CommercialOrTreasuryFinancingIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalReportingInformation is IsoMax210Text AdditionalReportingInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRptgInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(AdditionalReportingInformationValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
    }
    public static RegulatoryReporting4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
